namespace ThePostenSigningDLL
{
    partial class ParamDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCertThumbprint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrganizationNo = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ddSubject = new System.Windows.Forms.ComboBox();
            this.ddTitle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddWorkflowNames = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ddStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ddJobID = new System.Windows.Forms.ComboBox();
            this.txtNewWorkflowName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNumberOfPolls = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPollingSeconds = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.ddFAvailability = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ddAvailability = new System.Windows.Forms.ComboBox();
            this.ddNINInSignature = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTableColumnName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ddMNationalID = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ddMeMail = new System.Windows.Forms.ComboBox();
            this.ddMPhone = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ddMStatus = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_LoadTableData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ddRecieverNIN = new System.Windows.Forms.ComboBox();
            this.ddRecieverEmail = new System.Windows.Forms.ComboBox();
            this.ddRecieverPhone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddEnvironment = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCertThumbprint
            // 
            this.txtCertThumbprint.Location = new System.Drawing.Point(184, 46);
            this.txtCertThumbprint.Name = "txtCertThumbprint";
            this.txtCertThumbprint.Size = new System.Drawing.Size(275, 20);
            this.txtCertThumbprint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "VAT Reg NUmber: *";
            // 
            // txtOrganizationNo
            // 
            this.txtOrganizationNo.Location = new System.Drawing.Point(184, 20);
            this.txtOrganizationNo.Name = "txtOrganizationNo";
            this.txtOrganizationNo.Size = new System.Drawing.Size(275, 20);
            this.txtOrganizationNo.TabIndex = 0;
            // 
            // btn_OK
            // 
            this.btn_OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OK.Location = new System.Drawing.Point(434, 585);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(118, 39);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "Save";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Cancel.Location = new System.Drawing.Point(582, 585);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(124, 39);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(27, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cert. Thumbprint: *";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(732, 142);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(274, 20);
            this.txtCategoryName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(591, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category Number: *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThePostenSigningDLL.Properties.Resources.postenLogo;
            this.pictureBox1.Location = new System.Drawing.Point(968, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 38);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ddSubject
            // 
            this.ddSubject.FormattingEnabled = true;
            this.ddSubject.Location = new System.Drawing.Point(187, 28);
            this.ddSubject.Name = "ddSubject";
            this.ddSubject.Size = new System.Drawing.Size(275, 21);
            this.ddSubject.TabIndex = 16;
            // 
            // ddTitle
            // 
            this.ddTitle.FormattingEnabled = true;
            this.ddTitle.Location = new System.Drawing.Point(187, 58);
            this.ddTitle.Name = "ddTitle";
            this.ddTitle.Size = new System.Drawing.Size(275, 21);
            this.ddTitle.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(-307, -153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Field for Phonenumber:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(31, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Field for Subject: *";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(31, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Field for Title: *";
            // 
            // ddWorkflowNames
            // 
            this.ddWorkflowNames.FormattingEnabled = true;
            this.ddWorkflowNames.Location = new System.Drawing.Point(731, 113);
            this.ddWorkflowNames.Name = "ddWorkflowNames";
            this.ddWorkflowNames.Size = new System.Drawing.Size(275, 21);
            this.ddWorkflowNames.TabIndex = 23;
            this.ddWorkflowNames.SelectedIndexChanged += new System.EventHandler(this.ddWorkflowNames_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(591, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Select Workflow:*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(31, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Field for Status: *";
            // 
            // ddStatus
            // 
            this.ddStatus.FormattingEnabled = true;
            this.ddStatus.Location = new System.Drawing.Point(186, 122);
            this.ddStatus.Name = "ddStatus";
            this.ddStatus.Size = new System.Drawing.Size(275, 21);
            this.ddStatus.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(30, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 15);
            this.label13.TabIndex = 27;
            this.label13.Text = "Field for JobID: ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ddJobID
            // 
            this.ddJobID.FormattingEnabled = true;
            this.ddJobID.Location = new System.Drawing.Point(187, 89);
            this.ddJobID.Name = "ddJobID";
            this.ddJobID.Size = new System.Drawing.Size(275, 21);
            this.ddJobID.TabIndex = 28;
            // 
            // txtNewWorkflowName
            // 
            this.txtNewWorkflowName.Location = new System.Drawing.Point(731, 84);
            this.txtNewWorkflowName.Name = "txtNewWorkflowName";
            this.txtNewWorkflowName.Size = new System.Drawing.Size(231, 20);
            this.txtNewWorkflowName.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(591, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 15);
            this.label14.TabIndex = 30;
            this.label14.Text = "Add New Workflow:";
            // 
            // btn_Add
            // 
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Add.Location = new System.Drawing.Point(968, 84);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(70, 20);
            this.btn_Add.TabIndex = 31;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtNumberOfPolls);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtPollingSeconds);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtCertThumbprint);
            this.groupBox3.Controls.Add(this.txtOrganizationNo);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(36, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 141);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server Config";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(27, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 15);
            this.label21.TabIndex = 10;
            this.label21.Text = "Iterations per poll: *";
            // 
            // txtNumberOfPolls
            // 
            this.txtNumberOfPolls.Location = new System.Drawing.Point(183, 102);
            this.txtNumberOfPolls.Name = "txtNumberOfPolls";
            this.txtNumberOfPolls.Size = new System.Drawing.Size(275, 20);
            this.txtNumberOfPolls.TabIndex = 9;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(26, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 15);
            this.label20.TabIndex = 8;
            this.label20.Text = "Polling interval (seconds):*";
            // 
            // txtPollingSeconds
            // 
            this.txtPollingSeconds.Location = new System.Drawing.Point(183, 74);
            this.txtPollingSeconds.Name = "txtPollingSeconds";
            this.txtPollingSeconds.Size = new System.Drawing.Size(275, 20);
            this.txtPollingSeconds.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.ddFAvailability);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.ddAvailability);
            this.groupBox4.Controls.Add(this.ddNINInSignature);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.ddStatus);
            this.groupBox4.Controls.Add(this.ddJobID);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.ddTitle);
            this.groupBox4.Controls.Add(this.ddSubject);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(36, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1030, 208);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Signing Job";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label27.Location = new System.Drawing.Point(30, 158);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(113, 15);
            this.label27.TabIndex = 41;
            this.label27.Text = "Field for Availability:";
            // 
            // ddFAvailability
            // 
            this.ddFAvailability.FormattingEnabled = true;
            this.ddFAvailability.Location = new System.Drawing.Point(187, 155);
            this.ddFAvailability.Name = "ddFAvailability";
            this.ddFAvailability.Size = new System.Drawing.Size(275, 21);
            this.ddFAvailability.TabIndex = 40;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(770, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 15);
            this.label23.TabIndex = 39;
            this.label23.Text = "Week(s)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(560, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(148, 15);
            this.label22.TabIndex = 38;
            this.label22.Text = "Default signing availablity:";
            // 
            // ddAvailability
            // 
            this.ddAvailability.FormattingEnabled = true;
            this.ddAvailability.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.ddAvailability.Location = new System.Drawing.Point(695, 61);
            this.ddAvailability.Name = "ddAvailability";
            this.ddAvailability.Size = new System.Drawing.Size(67, 21);
            this.ddAvailability.TabIndex = 37;
            this.ddAvailability.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ddNINInSignature
            // 
            this.ddNINInSignature.FormattingEnabled = true;
            this.ddNINInSignature.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.ddNINInSignature.Location = new System.Drawing.Point(695, 28);
            this.ddNINInSignature.Name = "ddNINInSignature";
            this.ddNINInSignature.Size = new System.Drawing.Size(275, 21);
            this.ddNINInSignature.TabIndex = 36;
            this.ddNINInSignature.SelectedIndexChanged += new System.EventHandler(this.ddNINInSignature_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label25.Location = new System.Drawing.Point(564, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 15);
            this.label25.TabIndex = 35;
            this.label25.Text = "Show NIN in Signature:";
            // 
            // txtTableColumnName
            // 
            this.txtTableColumnName.Location = new System.Drawing.Point(163, 24);
            this.txtTableColumnName.Name = "txtTableColumnName";
            this.txtTableColumnName.Size = new System.Drawing.Size(204, 20);
            this.txtTableColumnName.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(32, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Table Number:";
            // 
            // ddMNationalID
            // 
            this.ddMNationalID.FormattingEnabled = true;
            this.ddMNationalID.Location = new System.Drawing.Point(162, 57);
            this.ddMNationalID.Name = "ddMNationalID";
            this.ddMNationalID.Size = new System.Drawing.Size(275, 21);
            this.ddMNationalID.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(32, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Field for National ID:";
            // 
            // ddMeMail
            // 
            this.ddMeMail.FormattingEnabled = true;
            this.ddMeMail.Location = new System.Drawing.Point(162, 85);
            this.ddMeMail.Name = "ddMeMail";
            this.ddMeMail.Size = new System.Drawing.Size(275, 21);
            this.ddMeMail.TabIndex = 37;
            // 
            // ddMPhone
            // 
            this.ddMPhone.FormattingEnabled = true;
            this.ddMPhone.Location = new System.Drawing.Point(162, 112);
            this.ddMPhone.Name = "ddMPhone";
            this.ddMPhone.Size = new System.Drawing.Size(275, 21);
            this.ddMPhone.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(32, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 15);
            this.label17.TabIndex = 39;
            this.label17.Text = "Field for E-mail:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(32, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 15);
            this.label18.TabIndex = 40;
            this.label18.Text = "Field for Phone:";
            // 
            // ddMStatus
            // 
            this.ddMStatus.FormattingEnabled = true;
            this.ddMStatus.Location = new System.Drawing.Point(162, 140);
            this.ddMStatus.Name = "ddMStatus";
            this.ddMStatus.Size = new System.Drawing.Size(275, 21);
            this.ddMStatus.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(32, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(91, 15);
            this.label19.TabIndex = 42;
            this.label19.Text = "Field for Status:";
            // 
            // btn_LoadTableData
            // 
            this.btn_LoadTableData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_LoadTableData.Location = new System.Drawing.Point(384, 24);
            this.btn_LoadTableData.Name = "btn_LoadTableData";
            this.btn_LoadTableData.Size = new System.Drawing.Size(70, 20);
            this.btn_LoadTableData.TabIndex = 38;
            this.btn_LoadTableData.Text = "Load";
            this.btn_LoadTableData.UseVisualStyleBackColor = true;
            this.btn_LoadTableData.Click += new System.EventHandler(this.btn_LoadTableData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LoadTableData);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.ddMStatus);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.ddMPhone);
            this.groupBox1.Controls.Add(this.ddMeMail);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.ddMNationalID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtTableColumnName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(568, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 178);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiple Signers";
            // 
            // ddRecieverNIN
            // 
            this.ddRecieverNIN.FormattingEnabled = true;
            this.ddRecieverNIN.Location = new System.Drawing.Point(189, 26);
            this.ddRecieverNIN.Name = "ddRecieverNIN";
            this.ddRecieverNIN.Size = new System.Drawing.Size(275, 21);
            this.ddRecieverNIN.TabIndex = 7;
            // 
            // ddRecieverEmail
            // 
            this.ddRecieverEmail.FormattingEnabled = true;
            this.ddRecieverEmail.Location = new System.Drawing.Point(189, 55);
            this.ddRecieverEmail.Name = "ddRecieverEmail";
            this.ddRecieverEmail.Size = new System.Drawing.Size(275, 21);
            this.ddRecieverEmail.TabIndex = 8;
            // 
            // ddRecieverPhone
            // 
            this.ddRecieverPhone.FormattingEnabled = true;
            this.ddRecieverPhone.Location = new System.Drawing.Point(189, 83);
            this.ddRecieverPhone.Name = "ddRecieverPhone";
            this.ddRecieverPhone.Size = new System.Drawing.Size(275, 21);
            this.ddRecieverPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Field for National ID Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(32, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Field for E-Mail: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(33, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Field for Phonenumber:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ddRecieverPhone);
            this.groupBox2.Controls.Add(this.ddRecieverEmail);
            this.groupBox2.Controls.Add(this.ddRecieverNIN);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(36, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 179);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Singel Signer";
            // 
            // ddEnvironment
            // 
            this.ddEnvironment.FormattingEnabled = true;
            this.ddEnvironment.Items.AddRange(new object[] {
            "DifiTest",
            "Production"});
            this.ddEnvironment.Location = new System.Drawing.Point(732, 29);
            this.ddEnvironment.Name = "ddEnvironment";
            this.ddEnvironment.Size = new System.Drawing.Size(148, 21);
            this.ddEnvironment.TabIndex = 40;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(222, 585);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(161, 20);
            this.label24.TabIndex = 43;
            this.label24.Text = "* Mandatory fields";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(727, 63);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(328, 17);
            this.label26.TabIndex = 44;
            this.label26.Text = "Type the name of your signing workflow then add it";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(729, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Environment:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // ParamDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1106, 652);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.ddEnvironment);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNewWorkflowName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ddWorkflowNames);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ParamDialog";
            this.Text = "ParamDialog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCertThumbprint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrganizationNo;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ddSubject;
        private System.Windows.Forms.ComboBox ddTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ddWorkflowNames;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ddStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ddJobID;
        private System.Windows.Forms.TextBox txtNewWorkflowName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPollingSeconds;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNumberOfPolls;
        private System.Windows.Forms.ComboBox ddNINInSignature;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTableColumnName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ddMNationalID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ddMeMail;
        private System.Windows.Forms.ComboBox ddMPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ddMStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_LoadTableData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ddRecieverNIN;
        private System.Windows.Forms.ComboBox ddRecieverEmail;
        private System.Windows.Forms.ComboBox ddRecieverPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddEnvironment;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox ddAvailability;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox ddFAvailability;
    }
}