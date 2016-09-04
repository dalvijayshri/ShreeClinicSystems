namespace Com.Shree.ClinicSystemControllers
{
    partial class frmRegistration
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
            this.dgvPatientList = new System.Windows.Forms.DataGridView();
            this.gbNavigation = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpatientdetails = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMrMrs = new System.Windows.Forms.ComboBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbUnknown = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.tabcontact = new System.Windows.Forms.TabPage();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.cmbConsultant = new System.Windows.Forms.ComboBox();
            this.cmbRefferedBy = new System.Windows.Forms.ComboBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConsultant = new System.Windows.Forms.Label();
            this.lblRefferedBy = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBloodgroup = new System.Windows.Forms.ComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.gbNavigation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabpatientdetails.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.tabcontact.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatientList
            // 
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Location = new System.Drawing.Point(209, 523);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowTemplate.Height = 24;
            this.dgvPatientList.Size = new System.Drawing.Size(1125, 267);
            this.dgvPatientList.TabIndex = 51;
            // 
            // gbNavigation
            // 
            this.gbNavigation.Controls.Add(this.btnRefresh);
            this.gbNavigation.Controls.Add(this.btnLast);
            this.gbNavigation.Controls.Add(this.btnNext);
            this.gbNavigation.Controls.Add(this.btnFirst);
            this.gbNavigation.Controls.Add(this.btnPrevious);
            this.gbNavigation.Location = new System.Drawing.Point(223, 443);
            this.gbNavigation.Name = "gbNavigation";
            this.gbNavigation.Size = new System.Drawing.Size(907, 74);
            this.gbNavigation.TabIndex = 50;
            this.gbNavigation.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Gray;
            this.btnRefresh.Location = new System.Drawing.Point(685, 9);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 54);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.Olive;
            this.btnLast.Location = new System.Drawing.Point(518, 21);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(110, 42);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "&Last >|";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Olive;
            this.btnNext.Location = new System.Drawing.Point(356, 22);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(131, 42);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "&Next >>|";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.Olive;
            this.btnFirst.Location = new System.Drawing.Point(36, 21);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(98, 42);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "|< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Olive;
            this.btnPrevious.Location = new System.Drawing.Point(162, 21);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(140, 42);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "|<<&Prvious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpatientdetails);
            this.tabControl1.Controls.Add(this.tabcontact);
            this.tabControl1.Controls.Add(this.tabOther);
            this.tabControl1.ItemSize = new System.Drawing.Size(500, 40);
            this.tabControl1.Location = new System.Drawing.Point(76, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(16, 7);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1185, 305);
            this.tabControl1.TabIndex = 49;
            // 
            // tabpatientdetails
            // 
            this.tabpatientdetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabpatientdetails.Controls.Add(this.txtWeight);
            this.tabpatientdetails.Controls.Add(this.label9);
            this.tabpatientdetails.Controls.Add(this.label8);
            this.tabpatientdetails.Controls.Add(this.dtpDOB);
            this.tabpatientdetails.Controls.Add(this.cmbBloodgroup);
            this.tabpatientdetails.Controls.Add(this.label6);
            this.tabpatientdetails.Controls.Add(this.label5);
            this.tabpatientdetails.Controls.Add(this.cmbMrMrs);
            this.tabpatientdetails.Controls.Add(this.gbGender);
            this.tabpatientdetails.Controls.Add(this.txtAge);
            this.tabpatientdetails.Controls.Add(this.lblAge);
            this.tabpatientdetails.Controls.Add(this.label2);
            this.tabpatientdetails.Controls.Add(this.label1);
            this.tabpatientdetails.Controls.Add(this.txtLName);
            this.tabpatientdetails.Controls.Add(this.txtMName);
            this.tabpatientdetails.Controls.Add(this.lblName);
            this.tabpatientdetails.Controls.Add(this.txtFName);
            this.tabpatientdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpatientdetails.Location = new System.Drawing.Point(4, 44);
            this.tabpatientdetails.Name = "tabpatientdetails";
            this.tabpatientdetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabpatientdetails.Size = new System.Drawing.Size(1177, 257);
            this.tabpatientdetails.TabIndex = 0;
            this.tabpatientdetails.Text = "Patient Details";
            this.tabpatientdetails.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 137;
            this.label5.Text = "Mr/Mrs/Miss";
            // 
            // cmbMrMrs
            // 
            this.cmbMrMrs.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMrMrs.FormattingEnabled = true;
            this.cmbMrMrs.Items.AddRange(new object[] {
            "Mr. ",
            "Miss. ",
            "Mrs. ",
            "Mast. "});
            this.cmbMrMrs.Location = new System.Drawing.Point(188, 22);
            this.cmbMrMrs.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMrMrs.Name = "cmbMrMrs";
            this.cmbMrMrs.Size = new System.Drawing.Size(199, 27);
            this.cmbMrMrs.TabIndex = 0;
            this.cmbMrMrs.Text = "Select";
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbUnknown);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(498, 25);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(282, 130);
            this.gbGender.TabIndex = 4;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbUnknown
            // 
            this.rbUnknown.AutoSize = true;
            this.rbUnknown.Location = new System.Drawing.Point(84, 95);
            this.rbUnknown.Name = "rbUnknown";
            this.rbUnknown.Size = new System.Drawing.Size(115, 29);
            this.rbUnknown.TabIndex = 2;
            this.rbUnknown.TabStop = true;
            this.rbUnknown.Text = "Unknown";
            this.rbUnknown.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(84, 27);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(98, 29);
            this.rbFemale.TabIndex = 1;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(84, 62);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(76, 29);
            this.rbMale.TabIndex = 0;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(967, 188);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(152, 27);
            this.txtAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(879, 188);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(50, 29);
            this.lblAge.TabIndex = 133;
            this.lblAge.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 131;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 130;
            this.label1.Text = "Middle Name";
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(188, 207);
            this.txtLName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(199, 27);
            this.txtLName.TabIndex = 3;
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(188, 137);
            this.txtMName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(199, 27);
            this.txtMName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(57, 69);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 24);
            this.lblName.TabIndex = 129;
            this.lblName.Text = "First Name";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(188, 66);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(199, 27);
            this.txtFName.TabIndex = 1;
            // 
            // tabcontact
            // 
            this.tabcontact.Controls.Add(this.label7);
            this.tabcontact.Controls.Add(this.textBox1);
            this.tabcontact.Controls.Add(this.txtEmailID);
            this.tabcontact.Controls.Add(this.label3);
            this.tabcontact.Controls.Add(this.txtState);
            this.tabcontact.Controls.Add(this.lblState);
            this.tabcontact.Controls.Add(this.txtCity);
            this.tabcontact.Controls.Add(this.txtPhone);
            this.tabcontact.Controls.Add(this.lblPhone);
            this.tabcontact.Controls.Add(this.lblCity);
            this.tabcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontact.Location = new System.Drawing.Point(4, 44);
            this.tabcontact.Name = "tabcontact";
            this.tabcontact.Padding = new System.Windows.Forms.Padding(3);
            this.tabcontact.Size = new System.Drawing.Size(1177, 257);
            this.tabcontact.TabIndex = 1;
            this.tabcontact.Text = "Contact Details";
            this.tabcontact.UseVisualStyleBackColor = true;
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(314, 203);
            this.txtEmailID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(343, 27);
            this.txtEmailID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 162;
            this.label3.Text = "Email";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(314, 89);
            this.txtState.Margin = new System.Windows.Forms.Padding(4);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(343, 27);
            this.txtState.TabIndex = 9;
            this.txtState.Text = "Maharashtra";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(146, 89);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(64, 29);
            this.lblState.TabIndex = 161;
            this.lblState.Text = "State";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(314, 45);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(343, 27);
            this.txtCity.TabIndex = 8;
            this.txtCity.Text = "Pune";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(314, 143);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(343, 27);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(146, 143);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(76, 29);
            this.lblPhone.TabIndex = 160;
            this.lblPhone.Text = "Phone";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(146, 45);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(51, 29);
            this.lblCity.TabIndex = 159;
            this.lblCity.Text = "City";
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add(this.button9);
            this.tabOther.Controls.Add(this.button8);
            this.tabOther.Controls.Add(this.cmbConsultant);
            this.tabOther.Controls.Add(this.cmbRefferedBy);
            this.tabOther.Controls.Add(this.txtRemark);
            this.tabOther.Controls.Add(this.label4);
            this.tabOther.Controls.Add(this.lblConsultant);
            this.tabOther.Controls.Add(this.lblRefferedBy);
            this.tabOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOther.Location = new System.Drawing.Point(4, 44);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(1177, 257);
            this.tabOther.TabIndex = 2;
            this.tabOther.Text = "Other Details";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.ForestGreen;
            this.button9.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.addlogo;
            this.button9.Location = new System.Drawing.Point(453, 135);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(57, 37);
            this.button9.TabIndex = 103;
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.ForestGreen;
            this.button8.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.addlogo;
            this.button8.Location = new System.Drawing.Point(453, 67);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button8.Size = new System.Drawing.Size(57, 37);
            this.button8.TabIndex = 102;
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // cmbConsultant
            // 
            this.cmbConsultant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultant.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultant.FormattingEnabled = true;
            this.cmbConsultant.Location = new System.Drawing.Point(220, 69);
            this.cmbConsultant.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConsultant.Name = "cmbConsultant";
            this.cmbConsultant.Size = new System.Drawing.Size(204, 31);
            this.cmbConsultant.TabIndex = 13;
            // 
            // cmbRefferedBy
            // 
            this.cmbRefferedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefferedBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRefferedBy.FormattingEnabled = true;
            this.cmbRefferedBy.Location = new System.Drawing.Point(220, 141);
            this.cmbRefferedBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRefferedBy.Name = "cmbRefferedBy";
            this.cmbRefferedBy.Size = new System.Drawing.Size(204, 31);
            this.cmbRefferedBy.TabIndex = 14;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(575, 100);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(518, 106);
            this.txtRemark.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 101;
            this.label4.Text = "Remark";
            // 
            // lblConsultant
            // 
            this.lblConsultant.AutoSize = true;
            this.lblConsultant.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultant.Location = new System.Drawing.Point(51, 67);
            this.lblConsultant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsultant.Name = "lblConsultant";
            this.lblConsultant.Size = new System.Drawing.Size(121, 29);
            this.lblConsultant.TabIndex = 100;
            this.lblConsultant.Text = "Consultant";
            // 
            // lblRefferedBy
            // 
            this.lblRefferedBy.AutoSize = true;
            this.lblRefferedBy.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefferedBy.Location = new System.Drawing.Point(51, 139);
            this.lblRefferedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefferedBy.Name = "lblRefferedBy";
            this.lblRefferedBy.Size = new System.Drawing.Size(125, 29);
            this.lblRefferedBy.TabIndex = 99;
            this.lblRefferedBy.Text = "Reffered By";
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "By Patient Name",
            "By PID"});
            this.cmbSearchBy.Location = new System.Drawing.Point(29, 491);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(126, 27);
            this.cmbSearchBy.TabIndex = 45;
            this.cmbSearchBy.Text = "Select";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(35, 601);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 71);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(30, 547);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(131, 27);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.Text = "Enter Here";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(30, 433);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(153, 29);
            this.lblSearch.TabIndex = 48;
            this.lblSearch.Text = "Search Patient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 139;
            this.label6.Text = "Blood Group";
            // 
            // cmbBloodgroup
            // 
            this.cmbBloodgroup.FormattingEnabled = true;
            this.cmbBloodgroup.ItemHeight = 25;
            this.cmbBloodgroup.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-",
            ""});
            this.cmbBloodgroup.Location = new System.Drawing.Point(659, 188);
            this.cmbBloodgroup.Name = "cmbBloodgroup";
            this.cmbBloodgroup.Size = new System.Drawing.Size(121, 33);
            this.cmbBloodgroup.TabIndex = 140;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.toolStripMenuItem1,
            this.updateAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1349, 97);
            this.menuStrip2.TabIndex = 52;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookToolStripMenuItem.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.treattLogo;
            this.bookToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(125, 93);
            this.bookToolStripMenuItem.Text = "&New Patient ";
            this.bookToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.save;
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(75, 93);
            this.toolStripMenuItem1.Text = "&Save";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // updateAppointmentToolStripMenuItem
            // 
            this.updateAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppointmentToolStripMenuItem.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.patientedit;
            this.updateAppointmentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.updateAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateAppointmentToolStripMenuItem.Name = "updateAppointmentToolStripMenuItem";
            this.updateAppointmentToolStripMenuItem.Size = new System.Drawing.Size(86, 93);
            this.updateAppointmentToolStripMenuItem.Text = "&Update ";
            this.updateAppointmentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAppointmentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentToolStripMenuItem.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.deletepatint;
            this.cancelAppointmentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancelAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(79, 93);
            this.cancelAppointmentToolStripMenuItem.Text = "&Delete ";
            this.cancelAppointmentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.printer_icon;
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 93);
            this.toolStripMenuItem2.Text = "&Print OPD Paper";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(814, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 187);
            this.textBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 164;
            this.label7.Text = "Address";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(872, 119);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(247, 30);
            this.dtpDOB.TabIndex = 6;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(867, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 29);
            this.label8.TabIndex = 142;
            this.label8.Text = "Select Date of Birth";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(955, 20);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(164, 27);
            this.txtWeight.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(867, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 29);
            this.label9.TabIndex = 144;
            this.label9.Text = "Weight";
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 814);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dgvPatientList);
            this.Controls.Add(this.gbNavigation);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmbSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "frmRegistration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.gbNavigation.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabpatientdetails.ResumeLayout(false);
            this.tabpatientdetails.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.tabcontact.ResumeLayout(false);
            this.tabcontact.PerformLayout();
            this.tabOther.ResumeLayout(false);
            this.tabOther.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientList;
        private System.Windows.Forms.GroupBox gbNavigation;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpatientdetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMrMrs;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbUnknown;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TabPage tabcontact;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ComboBox cmbConsultant;
        private System.Windows.Forms.ComboBox cmbRefferedBy;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConsultant;
        private System.Windows.Forms.Label lblRefferedBy;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbBloodgroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label9;
    }
}