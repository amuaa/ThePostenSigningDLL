using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Therefore.AddIn;
using Therefore.API;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Digipost.Signature.Api.Client.Core;
using System.Text.RegularExpressions;
using System.Security.Cryptography.X509Certificates;
using Digipost.Signature.Api.Client.Portal;
using System.Timers;
using Digipost.Signature.Api.Client.Portal.Enums;
using Digipost.Signature.Api.Client.Core.Exceptions;
using Microsoft.Win32;
using Digipost.Signature.Api.Client.Core.Identifier;
using System.IO;

namespace ThePostenSigningDLL
{
    [Guid("96022231-EC97-4885-9F28-F3BA6A0791E2"), ComVisible(true)]
    public class Run : ITheWorkflowSyncEvtEx
    {
        //Show the settings dialog from the solution designer. Pass the categoryNo as a parameter
        public string ShowSettingsDlg(int nCtgryNo, string bstrParams)
        {
            ParamDialog paramDialog = new ParamDialog() { TheCatNumber = nCtgryNo };
            paramDialog.ShowDialog();
            if (paramDialog.DialogResult == DialogResult.OK)
            {
                return paramDialog.TheCatNumber.ToString();
            }
            return bstrParams;
        }
        //Function for removing unwanted chars from the thumbprint 
        public string CleanThumbprint(string mmcThumbprint)
        {
            //replace spaces, non word chars and convert to uppercase
            return Regex.Replace(mmcThumbprint, @"\s|\W", "").ToUpper();
        }
        //The main function which is performed each time a document is sent to the workflow
        void ITheWorkflowSyncEvtEx.ProcAutomaticInst(int nInstanceNo, int nTokenNo, string bstrParams)
        {
            try
            {
                TheServer server = new TheServer();
                server.Connect(TheClientType.CustomApplication);

                //create a TheWFInstance object and load the workflow item by using the instance number
                TheWFInstance wfInstance = new TheWFInstance();
                wfInstance.Load(server, nInstanceNo);

                //the GetLinkedDocAt method gives back the document number 
                //of the document this workflow item belongs to
                TheWFDocument wfDoc = wfInstance.GetLinkedDocAt(0);

                int nDocNo = wfInstance.GetLinkedDocAt(0).DocNo;

                //with the document number you can retrieve the document
                TheDocument theDoc = new TheDocument();
                string strTheDoc = theDoc.Retrieve(wfDoc.DocNo, "", server);

                //A temporary location for storing files which are extracted from Therefore (and will be sent for signing).

                string extractFile = theDoc.ExtractStream(0, Path.GetTempPath());

                string sOrganizationNo;
                string sCertThumbprint;
                string sRecieverEmail, vRecieverEmail = null;
                string sRecieverNIN, vRecieverNIN = null;
                string sRecieverPhone, vRecieverPhone = null;
                string sSubject, vSubject;
                string sTitle, vTitle;
                string vReference;
                string sStatus;
                string sMStatus = "";
                string sJobId;
                string sTableFieldNo = "";
                string sNINInSignature;
                string sEnvironment;
                string sDebugMode;
                int iDebugMode = 0;
                int sDefaultAvailability = 4;
                string sFAvailability = "";

                //Load information about which fields to use in the category from the Registry
                RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                key = key.OpenSubKey("SOFTWARE").OpenSubKey("Canon");


                sOrganizationNo = key.GetValue("OrganizationNo").ToString();
                sCertThumbprint = key.GetValue("CertThumbprint").ToString();
                sEnvironment = key.GetValue("Environment").ToString();
                sDebugMode = key.GetValue("DebugMode").ToString();
                if (sDebugMode != "")
                {
                    iDebugMode = Convert.ToInt32(sDebugMode);
                }
                key = key.OpenSubKey(wfInstance.ProcessName);
                sRecieverEmail = key.GetValue("RecieverEmailFieldName").ToString();
                sRecieverNIN = key.GetValue("RecieverNINFieldName").ToString();

                sRecieverPhone = key.GetValue("RecieverPhoneFieldName").ToString();
                sSubject = key.GetValue("SubjectFieldName").ToString();
                sTitle = key.GetValue("TitleFieldName").ToString();

                sStatus = key.GetValue("StatusFieldName").ToString();
                sJobId = key.GetValue("JobIDFieldName").ToString();
                sNINInSignature = key.GetValue("NINInSignature").ToString();
                sDefaultAvailability = Convert.ToInt32(key.GetValue("DefaultAvailablity").ToString());
                sFAvailability = key.GetValue("AvailabilityFieldName").ToString();

                //If there are multiple signers, we need to use a table for storing the data
                sTableFieldNo = key.GetValue("M_TableFieldNo").ToString();
                if (sTableFieldNo != "")
                {

                    sRecieverEmail = key.GetValue("M_MailFieldName").ToString();
                    sMStatus = key.GetValue("M_StatusFieldName").ToString();
                    sRecieverPhone = key.GetValue("M_PhoneFieldName").ToString();
                    sRecieverNIN = key.GetValue("M_NINFieldName").ToString();

                }

                //Creating a list which contains all Signers (POSTEN)
                List<Signer> listOfSigners = new List<Signer>();

                //loading the indexdata related to the document
                TheIndexData indata = new TheIndexData();
                TheTableDataType inTddata = new TheTableDataType();
                indata = theDoc.IndexData;

                //If only one signer:
                if (sTableFieldNo == "")
                {
                    if (!String.IsNullOrEmpty(sRecieverEmail))
                        vRecieverEmail = indata.GetValueByColName(sRecieverEmail);
                    if (!String.IsNullOrEmpty(sRecieverPhone))
                        vRecieverPhone = indata.GetValueByColName(sRecieverPhone);
                    if (!String.IsNullOrEmpty(sRecieverNIN))
                        vRecieverNIN = indata.GetValueByColName(sRecieverNIN);
                    if (!string.IsNullOrEmpty(vRecieverNIN) && !string.IsNullOrEmpty(vRecieverEmail) && !string.IsNullOrEmpty(vRecieverPhone))
                    {
                        listOfSigners.Add(new Signer(new PersonalIdentificationNumber(vRecieverNIN), new Notifications(
                                                                                                                          new Email(vRecieverEmail),
                                                                                                                            new Sms(vRecieverPhone))));
                    }
                    else if (!string.IsNullOrEmpty(vRecieverEmail) && !string.IsNullOrEmpty(vRecieverPhone))
                    {
                        listOfSigners.Add(new Signer(new ContactInformation { Email = new Email(vRecieverEmail), Sms = new Sms(vRecieverPhone) }));
                    }
                    else if (!string.IsNullOrEmpty(vRecieverEmail))
                    {
                        listOfSigners.Add(new Signer(new ContactInformation { Email = new Email(vRecieverEmail) }));
                    }
                    if (iDebugMode > 0)
                    {
                        foreach (Signer logSigner in listOfSigners)
                        {
                            Library.WriteErrorLog("Signatør lagt til: " + logSigner.Identifier.ToString() + System.Environment.NewLine);
                        }
                    }
                }
                //IF multiple signers:
                else
                {

                    inTddata = indata.GetTableValue(Convert.ToInt32(sTableFieldNo));
                    for (int l = 0; l < inTddata.RowCount; l++)
                    {
                        vRecieverEmail = inTddata.GetValue(sRecieverEmail, l);
                        vRecieverPhone = inTddata.GetValue(sRecieverPhone, l).ToString();
                        vRecieverNIN = inTddata.GetValue(sRecieverNIN, l);
                        if (!string.IsNullOrEmpty(vRecieverNIN) && !string.IsNullOrEmpty(vRecieverEmail) && !string.IsNullOrEmpty(vRecieverPhone))
                        {
                            listOfSigners.Add(new Signer(new PersonalIdentificationNumber(vRecieverNIN), new Notifications(
                                                                                                                              new Email(vRecieverEmail),
                                                                                                                                new Sms(vRecieverPhone))));
                        }
                        else if (!string.IsNullOrEmpty(vRecieverEmail) && !string.IsNullOrEmpty(vRecieverPhone))
                        {
                            listOfSigners.Add(new Signer(new ContactInformation { Email = new Email(vRecieverEmail), Sms = new Sms(vRecieverPhone) }));
                        }
                        else if (!string.IsNullOrEmpty(vRecieverEmail))
                        {
                            listOfSigners.Add(new Signer(new ContactInformation { Email = new Email(vRecieverEmail) }));
                        }
                        if (l == 9)
                        {
                            break;
                        }
                    }
                }

                //Get information from the category which is needed to create a signing job

                vReference = indata.DocNo.ToString();
                vTitle = indata.GetValueByColName(sTitle);
                vSubject = indata.GetValueByColName(sSubject);


                //Get the certificate from the sigature store on the locale computer
                X509Store storeMy = new X509Store(StoreName.My, StoreLocation.LocalMachine);
                X509Certificate2 tekniskAvsenderSertifikat;
                try
                {
                    storeMy.Open(OpenFlags.ReadOnly);
                    var certs = storeMy.Certificates;

                    tekniskAvsenderSertifikat = certs.Find(
                        X509FindType.FindByThumbprint, CleanThumbprint(sCertThumbprint), false)[0];
                    if (iDebugMode > 0)
                    {
                        Library.WriteErrorLog("Certificate found: " + tekniskAvsenderSertifikat.ToString() + System.Environment.NewLine);
                    }
                }
                finally
                {
                    storeMy.Close();
                }
                //POSTEN: Portalclient
                PortalClient portalClient = null;

                Digipost.Signature.Api.Client.Core.Environment env = Digipost.Signature.Api.Client.Core.Environment.DifiTest;
                if (sEnvironment == "Production")
                {
                    env = Digipost.Signature.Api.Client.Core.Environment.Production;
                }

                //POSTEN: Create Client Configuration
                ClientConfiguration clientconfiguration = new ClientConfiguration(
                    env,
                    CleanThumbprint(sCertThumbprint),
                    new Sender(sOrganizationNo.Trim()));
                if (iDebugMode > 0)
                {
                    Library.WriteErrorLog("Client configured : " + clientconfiguration.ToString() + System.Environment.NewLine);
                }

                portalClient = new PortalClient(clientconfiguration);
                if (iDebugMode > 0)
                {
                    Library.WriteErrorLog("Portal configured : " + portalClient.ToString() + System.Environment.NewLine);
                }

                //POSTEN: Document
                Document documentToSign = new Document(
                    vTitle,
                    vSubject,
                    FileType.Pdf,
                    extractFile);
                if (iDebugMode > 0)
                {
                    Library.WriteErrorLog("Document configured : " + documentToSign.ToString() + System.Environment.NewLine);
                    Library.WriteErrorLog("PDF Path : " + extractFile + System.Environment.NewLine);
                }
                //POSTEN: Job
                Job job = new Job(
                    documentToSign,
                    listOfSigners,
                    vReference
                    );
                TimeSpan aTS = new TimeSpan(4 * 7, 0, 0, 0, 0);
                Library.WriteErrorLog("SF Availability : " + sFAvailability.ToString() + System.Environment.NewLine);
                if (!String.IsNullOrEmpty(sFAvailability))
                {
                    string aValue = "";
                    if (sFAvailability.Contains("|"))
                    {
                        Library.WriteErrorLog("SF Availability contains  pipe" + System.Environment.NewLine);
                        char[] splits = { '|' };
                        aValue = indata.GetValueByFieldNo(Convert.ToInt32(sFAvailability.Split(splits)[0].Trim()));
                        Library.WriteErrorLog("SF Availability is " + aValue + System.Environment.NewLine);
                    }
                    else {
                        aValue = indata.GetValueByColName(sFAvailability);
                    }
                    if (!String.IsNullOrEmpty(aValue))
                    {
                        char[] cH = { ' ' };
                        string aMeaning = aValue.Split(cH)[1];
                        int iValue = Convert.ToInt32(aValue.Split(cH)[0]);
                        if (aMeaning == "timer")
                        {
                            aTS = new TimeSpan(0, iValue, 0, 0, 0);
                        }
                        else if (aMeaning == "hour")
                        {
                            aTS = new TimeSpan(0, iValue, 0, 0, 0);
                        }
                        else if (aMeaning == "time")
                        {
                            aTS = new TimeSpan(0, iValue, 0, 0, 0);
                        }
                        else if (aMeaning == "hours")
                        {
                            aTS = new TimeSpan(0, iValue, 0, 0, 0);
                        }
                        else if (aMeaning == "uker")
                        {
                            aTS = new TimeSpan(iValue * 7, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "uke")
                        {
                            aTS = new TimeSpan(iValue * 7, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "week")
                        {
                            aTS = new TimeSpan(iValue * 7, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "weeks")
                        {
                            aTS = new TimeSpan(iValue * 7, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "dager")
                        {
                            aTS = new TimeSpan(iValue, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "dag")
                        {
                            aTS = new TimeSpan(iValue, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "day")
                        {
                            aTS = new TimeSpan(iValue, 0, 0, 0, 0);
                        }
                        else if (aMeaning == "days")
                        {
                            aTS = new TimeSpan(iValue, 0, 0, 0, 0);
                        }
                    }
                }
                else
                {
                    aTS = new TimeSpan(sDefaultAvailability * 7, 0, 0, 0, 0);

                }
                job.Availability = new Availability();

                job.Availability.AvailableFor = aTS;


                if (iDebugMode > 0)
                {
                    Library.WriteErrorLog("List of Signers : " + listOfSigners.ToString() + System.Environment.NewLine);

                    Library.WriteErrorLog("job configured : " + job.ToString() + System.Environment.NewLine);
                }

                //POSTEN: A job Response which acutally creates the signing job.


                JobResponse x = portalClient.Create(job).Result;
                if (iDebugMode > 0)
                {
                    Library.WriteErrorLog("JobResponse created : " + x.ToString() + System.Environment.NewLine);
                }


                //If multiple signers:
                if (sTableFieldNo != "")
                {
                    for (int l = 0; l < inTddata.RowCount; l++)
                    {
                        inTddata.SetValue(sMStatus, l, "Sendt for signering: " + x.ToString());
                        if (l == 9)
                        {
                            break;
                        }
                    }
                    indata.SetTableValue(Convert.ToInt32(sTableFieldNo), inTddata);
                    indata.SetValueByColName(sJobId, x.JobId.ToString());

                }
                //Update the status of the signing job in Therefore
                indata.SetValueByColName(sStatus, "Sendt for signering: " + x.ToString());
                indata.SetValueByColName(sJobId, x.JobId.ToString());
                indata.SaveChanges(server);

                if (System.IO.File.Exists(extractFile))
                {
                    try
                    {
                        System.IO.File.Delete(extractFile);
                    }
                    catch (Exception ex)
                    {
                        Library.WriteErrorLog("Could not delete file: " + ex.Message);
                    }
                }


                //get the next task in the workflow and finish the current task
                TheWFTask wfTask = wfInstance.GetNextTaskAt(0);
                wfInstance.ClaimInstance(server);
                wfInstance.FinishCurrentTask(server, wfTask.TaskNo, "");
            }
            catch (Exception ex)
            {
                //IF something goes wrong - write it to a log file.
                //Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Library.WriteErrorLog("Base: " + ex.GetBaseException().Message + "|| Inner Base: " + ex.GetBaseException().InnerException.Message + " || Message: " + ex.Message + "  || INNER: " + ex.InnerException.Message + System.Environment.NewLine);
                }
                else
                {
                    Library.WriteErrorLog("Base: " + ex.GetBaseException().Message + "|| Inner Base: " + ex.GetBaseException().InnerException.Message + " || Message: " + ex.Message + System.Environment.NewLine);
                }

            }

        }
    }
}
