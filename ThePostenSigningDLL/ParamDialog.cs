using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Therefore.API;

namespace ThePostenSigningDLL
{
    public partial class ParamDialog : Form
    {
        public ParamDialog()
        {
            InitializeComponent();

            // Load values for stored workflows from the Registry - skip certificationThumbprint and organizationNO
            try
            {
            RegistryKey key = Registry.LocalMachine;
            key = key.OpenSubKey("SOFTWARE").OpenSubKey("Canon");
            if (key != null)
            {
                List<string> regSubKeyNames = new List<string>();
                foreach (string wfName in key.GetSubKeyNames())
                {
                    if (wfName == "OrganizationNo" || wfName == "CertThumbprint" || wfName == "Environment")
                    {
                        continue;
                    }
                    regSubKeyNames.Add(wfName);
                } 
                ddWorkflowNames.DataSource = regSubKeyNames;
                ddWorkflowNames.Text = "";
            }
            }
            catch (Exception e)
            {
                MessageBox.Show("It appears no workflow has been configured yet. Please add add one to get started.");
            }

        }

        //Contains the Category No for the related Category (Can never be a case)
        private int theCatNumber;

        public int TheCatNumber
        {
            get { return theCatNumber; }
            set
            {
                theCatNumber = value;
                txtCategoryName.Text = theCatNumber.ToString();
            }
        }

        //When hitting OK - Save values to Registry and close the ParamDialog
        private void btn_OK_Click(object sender, EventArgs e)
        {

            RegistryKey key = Registry.LocalMachine;
            key = key.OpenSubKey("SOFTWARE", true).CreateSubKey("Canon");
            
            //Certificate and Polling
            key.SetValue("OrganizationNo", txtOrganizationNo.Text);
            key.SetValue("CertThumbprint", txtCertThumbprint.Text);
            key.SetValue("PolingInterval", txtPollingSeconds.Text);
            key.SetValue("NumberOfPolls", txtNumberOfPolls.Text);

            //which environment should be used (applies for both service and dll
            key.SetValue("Environment", ddEnvironment.Text);

            key = key.CreateSubKey(ddWorkflowNames.Text);


            //Singel signer
            key.SetValue("RecieverEmailFieldName", ddRecieverEmail.Text);
            key.SetValue("RecieverNINFieldName", ddRecieverNIN.Text);
            key.SetValue("RecieverPhoneFieldName", ddRecieverPhone.Text);

            //JOB properties
            key.SetValue("SubjectFieldName", ddSubject.Text);
            key.SetValue("TitleFieldName", ddTitle.Text);
            key.SetValue("StatusFieldName", ddStatus.Text);
            key.SetValue("CategoryNo", txtCategoryName.Text);
            key.SetValue("JobIDFieldName", ddJobID.Text);
            key.SetValue("AvailabilityFieldName", ddFAvailability.Text);

            key.SetValue("DefaultAvailablity", ddAvailability.Text);
            key.SetValue("NINInSignature", ddNINInSignature.Text);

            //Multiple signers
            key.SetValue("M_TableFieldNo", txtTableColumnName.Text);
            key.SetValue("M_MailFieldName", ddMeMail.Text);
            key.SetValue("M_StatusFieldName", ddMStatus.Text);
            key.SetValue("M_PhoneFieldName", ddMPhone.Text);
            key.SetValue("M_NINFieldName", ddMNationalID.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        //When hitting Cancel - Do Nothing
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ddWorkflowNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Open registry and find the certificate information
            RegistryKey key = Registry.LocalMachine;
            key = key.OpenSubKey("SOFTWARE").OpenSubKey("Canon");

            txtOrganizationNo.Text = key.GetValue("OrganizationNo").ToString();
            txtCertThumbprint.Text = key.GetValue("CertThumbprint").ToString();
            txtNumberOfPolls.Text = key.GetValue("NumberOfPolls").ToString();
            txtPollingSeconds.Text = key.GetValue("PolingInterval").ToString();
            ddEnvironment.Text = key.GetValue("Environment").ToString();

            //Find the correct workflow from the users pick
            key = key.OpenSubKey(ddWorkflowNames.Text);

            //Connect to the server and load fields from the Category
            TheServer server = new TheServer();
            server.Connect(TheClientType.CustomApplication);
             
            TheCategory category = new TheCategory();
            category.Load(Convert.ToInt32(txtCategoryName.Text), server);

            List<string> sAllFields = new List<string>();

            TheFieldList listOfField = new TheFieldList();
            listOfField.Category = category;
            listOfField.AddAll();

            //Define lists to hold datasources for the comboboxes.
            List<string> sAllFieldsEmail = new List<string>();
            List<string> sAllFieldsNIN = new List<string>();
            List<string> sAllFieldsPhone = new List<string>();
            List<string> sddFAvailability = new List<string>();
            List<string> sAllFieldsSubject = new List<string>();
            List<string> sAllFieldsTitle = new List<string>();
            List<string> sAllFieldsStatus = new List<string>();
            List<string> sAllFieldsJobID = new List<string>();

            //Fields that are not mandatory can have empty strings
            sddFAvailability.Add("");
            sAllFieldsJobID.Add("");
            sAllFieldsNIN.Add("");
            sAllFieldsPhone.Add("");

            //Fill datatsources with fields from the cateogry
            for (int i = 0; i<listOfField.Count; i++)
            {
                string temp = category.FieldNoToColName(listOfField[i]);
                if(temp == "")
                {
                    TheCategoryField tField = category.GetFieldByFieldNo(listOfField[i]);
                    temp = listOfField[i].ToString() + " | " + tField.Caption;

                }
                sAllFields.Add(temp);
                sAllFieldsNIN.Add(temp);
                sAllFieldsEmail.Add(temp);
                sAllFieldsPhone.Add(temp);
                sddFAvailability.Add(temp);
                sAllFieldsSubject.Add(temp);
                sAllFieldsTitle.Add(temp);
                sAllFieldsStatus.Add(temp);
                sAllFieldsJobID.Add(temp);
            }

            //Define datasources for comboboxes
            ddRecieverEmail.DataSource = sAllFieldsEmail;
            ddRecieverNIN.DataSource = sAllFieldsNIN;
            ddRecieverPhone.DataSource = sAllFieldsPhone;
            ddFAvailability.DataSource = sddFAvailability;
            ddSubject.DataSource = sAllFieldsSubject;
            ddTitle.DataSource = sAllFieldsTitle;
            ddStatus.DataSource = sAllFieldsStatus;
            ddJobID.DataSource = sAllFieldsJobID;

            //Fill Text and comboboxes with values from Registry
            //Single Signer
            ddRecieverEmail.Text = key.GetValue("RecieverEmailFieldName").ToString();
            ddRecieverNIN.Text = key.GetValue("RecieverNINFieldName").ToString();
            ddRecieverPhone.Text = key.GetValue("RecieverPhoneFieldName").ToString();

            //Multiple Signers
            txtTableColumnName.Text = key.GetValue("M_TableFieldNo").ToString();
            ddMeMail.Text = key.GetValue("M_MailFieldName").ToString();
            ddMStatus.Text = key.GetValue("M_StatusFieldName").ToString();
            ddMPhone.Text = key.GetValue("M_PhoneFieldName").ToString();
            ddMNationalID.Text = key.GetValue("M_NINFieldName").ToString();

            //Job properties
            ddSubject.Text = key.GetValue("SubjectFieldName").ToString();
            ddTitle.Text = key.GetValue("TitleFieldName").ToString();
            ddStatus.Text = key.GetValue("StatusFieldName").ToString();
            ddJobID.Text = key.GetValue("JobIDFieldName").ToString();
            ddFAvailability.Text = key.GetValue("AvailabilityFieldName").ToString();

            ddNINInSignature.Text = key.GetValue("NINInSignature").ToString();
            ddAvailability.Text = key.GetValue("DefaultAvailablity").ToString();

            //Disconnecting from the server
            server.Disconnect();
        }

        //Add a new workflow name to the Registry and reload the list
        private void btn_Add_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.LocalMachine;
            RegistryKey newSubKey = Registry.LocalMachine;
            key = key.OpenSubKey("SOFTWARE", true).CreateSubKey("Canon", true);
            newSubKey = key.CreateSubKey(txtNewWorkflowName.Text);

            List<string> regSubKeyNames = new List<string>();
            foreach (string wfName in key.GetSubKeyNames())
            {
                if (wfName == "OrganizationNo" || wfName == "CertThumbprint" || wfName == "PollingSeconds" || wfName == "PollIterations")
                {
                    continue;
                }
                regSubKeyNames.Add(wfName);
            }
            ddWorkflowNames.DataSource = regSubKeyNames;
            ddWorkflowNames.Text = "";
            ddWorkflowNames.Update();
            ddWorkflowNames.Refresh();

        }

        //Load the Fields for the Multiple signer option
        private void btn_LoadTableData_Click(object sender, EventArgs e)
        {

            TheServer server = new TheServer();
            server.Connect(TheClientType.CustomApplication);

            TheCategory aCat = new TheCategory();
            List<string> listOfTableFieldsNIN = new List<string>();
            List<string> listOfTableFieldsPhone = new List<string>();
            List<string> listOfTableFieldsEmail = new List<string>();
            List<string> listOfTableFieldsStatus = new List<string>();


            aCat.Load(Convert.ToInt32(txtCategoryName.Text), server);

            TheObjectList anObjectList = new TheObjectList();

            anObjectList = aCat.GetTableFields(Convert.ToInt32(txtTableColumnName.Text));
           
            foreach(int k in anObjectList)
            {
                listOfTableFieldsNIN.Add(aCat.FieldNoToColName(k).ToString());
                listOfTableFieldsPhone.Add(aCat.FieldNoToColName(k).ToString());
                listOfTableFieldsEmail.Add(aCat.FieldNoToColName(k).ToString());
                listOfTableFieldsStatus.Add(aCat.FieldNoToColName(k).ToString());

            }

            ddMNationalID.DataSource = listOfTableFieldsNIN;
            ddMeMail.DataSource = listOfTableFieldsEmail;
            ddMPhone.DataSource = listOfTableFieldsPhone;
            ddMStatus.DataSource = listOfTableFieldsStatus;

            ddMNationalID.Refresh();
            ddMStatus.Refresh();
            ddMPhone.Refresh();
            ddMeMail.Refresh();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ddNINInSignature_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
