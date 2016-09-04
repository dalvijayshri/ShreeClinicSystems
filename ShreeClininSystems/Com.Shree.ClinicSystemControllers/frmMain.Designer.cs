namespace Com.Shree.ClinicSystemControllers
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.linkLabelEdit = new System.Windows.Forms.LinkLabel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.oPDmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmOPDConsultation = new System.Windows.Forms.ToolStripMenuItem();
            this.billingmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LLLogout = new System.Windows.Forms.LinkLabel();
            this.lblTime = new System.Windows.Forms.Label();
            this.LLChangePassword = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblHospitalName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMiddle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelEdit
            // 
            this.linkLabelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelEdit.AutoSize = true;
            this.linkLabelEdit.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelEdit.Location = new System.Drawing.Point(1297, 652);
            this.linkLabelEdit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelEdit.Name = "linkLabelEdit";
            this.linkLabelEdit.Size = new System.Drawing.Size(32, 17);
            this.linkLabelEdit.TabIndex = 150;
            this.linkLabelEdit.TabStop = true;
            this.linkLabelEdit.Text = "Edit";
            this.linkLabelEdit.Visible = false;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlMiddle.BackgroundImage = global::Com.Shree.ClinicSystemControllers.Properties.Resources.bgcolor_hr1;
            this.pnlMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMiddle.Controls.Add(this.menuStrip1);
            this.pnlMiddle.Controls.Add(this.panel1);
            this.pnlMiddle.Controls.Add(this.pnlTop);
            this.pnlMiddle.Controls.Add(this.panel2);
            this.pnlMiddle.Controls.Add(this.pnlBottom);
            this.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMiddle.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMiddle.Location = new System.Drawing.Point(0, 0);
            this.pnlMiddle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(1442, 677);
            this.pnlMiddle.TabIndex = 151;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationmenu,
            this.oPDmenu,
            this.billingmenu,
            this.adminmenu});
            this.menuStrip1.Location = new System.Drawing.Point(4, 57);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 68);
            this.menuStrip1.TabIndex = 158;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationmenu
            // 
            this.registrationmenu.BackColor = System.Drawing.Color.Transparent;
            this.registrationmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmAppointment,
            this.ttmRegistration});
            this.registrationmenu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationmenu.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.registration60x60;
            this.registrationmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.registrationmenu.Name = "registrationmenu";
            this.registrationmenu.Size = new System.Drawing.Size(325, 64);
            this.registrationmenu.Text = "&Registration";
            // 
            // ttmAppointment
            // 
            this.ttmAppointment.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttmAppointment.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ttmAppointment.Image = ((System.Drawing.Image)(resources.GetObject("ttmAppointment.Image")));
            this.ttmAppointment.Name = "ttmAppointment";
            this.ttmAppointment.Size = new System.Drawing.Size(249, 38);
            this.ttmAppointment.Text = "&Appointment";
            // 
            // ttmRegistration
            // 
            this.ttmRegistration.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttmRegistration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ttmRegistration.Image = ((System.Drawing.Image)(resources.GetObject("ttmRegistration.Image")));
            this.ttmRegistration.Name = "ttmRegistration";
            this.ttmRegistration.Size = new System.Drawing.Size(249, 38);
            this.ttmRegistration.Text = "&Registration";
            // 
            // oPDmenu
            // 
            this.oPDmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmOPDConsultation});
            this.oPDmenu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oPDmenu.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.opdimage2;
            this.oPDmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.oPDmenu.Name = "oPDmenu";
            this.oPDmenu.Size = new System.Drawing.Size(185, 64);
            this.oPDmenu.Text = "&OPD";
            // 
            // ttmOPDConsultation
            // 
            this.ttmOPDConsultation.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttmOPDConsultation.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ttmOPDConsultation.Image = ((System.Drawing.Image)(resources.GetObject("ttmOPDConsultation.Image")));
            this.ttmOPDConsultation.Name = "ttmOPDConsultation";
            this.ttmOPDConsultation.Size = new System.Drawing.Size(297, 38);
            this.ttmOPDConsultation.Text = "&OPD Consultation";
            this.ttmOPDConsultation.Click += new System.EventHandler(this.ttmOPDConsultation_Click);
            // 
            // billingmenu
            // 
            this.billingmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.billingmenu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.billingmenu.Name = "billingmenu";
            this.billingmenu.Size = new System.Drawing.Size(154, 64);
            this.billingmenu.Text = "&Billing";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(333, 38);
            this.toolStripMenuItem1.Text = "&OPD Pending List";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(333, 38);
            this.toolStripMenuItem2.Text = "&OPD Lab Pending List";
            // 
            // adminmenu
            // 
            this.adminmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.adminmenu.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adminmenu.Name = "adminmenu";
            this.adminmenu.Size = new System.Drawing.Size(160, 64);
            this.adminmenu.Text = "&Admin";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(226, 38);
            this.toolStripMenuItem3.Text = "&Master";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem4.Image")));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(226, 38);
            this.toolStripMenuItem4.Text = "&MIS Report";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.LLLogout);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.LLChangePassword);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Location = new System.Drawing.Point(1089, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 111);
            this.panel1.TabIndex = 156;
            // 
            // LLLogout
            // 
            this.LLLogout.ActiveLinkColor = System.Drawing.Color.Blue;
            this.LLLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLLogout.AutoSize = true;
            this.LLLogout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LLLogout.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LLLogout.Location = new System.Drawing.Point(255, 76);
            this.LLLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLLogout.Name = "LLLogout";
            this.LLLogout.Size = new System.Drawing.Size(81, 29);
            this.LLLogout.TabIndex = 1;
            this.LLLogout.TabStop = true;
            this.LLLogout.Text = "Logout";
            this.LLLogout.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(4, 10);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(335, 31);
            this.lblTime.TabIndex = 118;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LLChangePassword
            // 
            this.LLChangePassword.ActiveLinkColor = System.Drawing.Color.Blue;
            this.LLChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LLChangePassword.AutoSize = true;
            this.LLChangePassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LLChangePassword.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.LLChangePassword.Location = new System.Drawing.Point(143, 44);
            this.LLChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LLChangePassword.Name = "LLChangePassword";
            this.LLChangePassword.Size = new System.Drawing.Size(184, 29);
            this.LLChangePassword.TabIndex = 0;
            this.LLChangePassword.TabStop = true;
            this.LLChangePassword.Text = "Change Password";
            this.LLChangePassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Salmon;
            this.btnCancel.Location = new System.Drawing.Point(236, 76);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 33);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Location = new System.Drawing.Point(140, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 33);
            this.btnSave.TabIndex = 119;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPassword.Location = new System.Drawing.Point(137, 44);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 32);
            this.txtPassword.TabIndex = 120;
            this.txtPassword.Text = "New Password";
            this.txtPassword.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlTop.BackgroundImage = global::Com.Shree.ClinicSystemControllers.Properties.Resources.bgcolor_hr;
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Controls.Add(this.pnlLogo);
            this.pnlTop.Controls.Add(this.lblHospitalName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1442, 52);
            this.pnlTop.TabIndex = 122;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.BackgroundImage = global::Com.Shree.ClinicSystemControllers.Properties.Resources.Sneha_Specialty_logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(4, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(64, 53);
            this.pnlLogo.TabIndex = 19;
            // 
            // lblHospitalName
            // 
            this.lblHospitalName.BackColor = System.Drawing.Color.Transparent;
            this.lblHospitalName.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospitalName.ForeColor = System.Drawing.Color.White;
            this.lblHospitalName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHospitalName.Location = new System.Drawing.Point(62, 0);
            this.lblHospitalName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHospitalName.Name = "lblHospitalName";
            this.lblHospitalName.Size = new System.Drawing.Size(565, 48);
            this.lblHospitalName.TabIndex = 18;
            this.lblHospitalName.Text = "Sneha Clinic";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Com.Shree.ClinicSystemControllers.Properties.Resources.logo_Main_Screen;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(438, 201);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 335);
            this.panel2.TabIndex = 18;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBottom.Controls.Add(this.label3);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBottom.Location = new System.Drawing.Point(0, 649);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1442, 28);
            this.pnlBottom.TabIndex = 119;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(923, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(501, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Project By : MARS Medisciences Pvt Ltd | www.marsmedisciences.com";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 677);
            this.Controls.Add(this.linkLabelEdit);
            this.Controls.Add(this.pnlMiddle);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMiddle.ResumeLayout(false);
            this.pnlMiddle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelEdit;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblHospitalName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel LLLogout;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.LinkLabel LLChangePassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationmenu;
        private System.Windows.Forms.ToolStripMenuItem ttmAppointment;
        private System.Windows.Forms.ToolStripMenuItem ttmRegistration;
        private System.Windows.Forms.ToolStripMenuItem oPDmenu;
        private System.Windows.Forms.ToolStripMenuItem ttmOPDConsultation;
        private System.Windows.Forms.ToolStripMenuItem billingmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem adminmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}