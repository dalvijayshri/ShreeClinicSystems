namespace Com.Shree.ClinicSystemControllers
{
    partial class frmAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.dgDrSchedule = new System.Windows.Forms.DataGridView();
            this.dgAppointmentReport = new System.Windows.Forms.DataGridView();
            this.txtAptID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtptotime = new System.Windows.Forms.DateTimePicker();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ttmNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.ttmBookAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAppointmentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpfromtime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboConsultant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContactno = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.dtpSearchAppointment = new System.Windows.Forms.DateTimePicker();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentReport)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(963, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Appointment Reports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Appointment Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Doctors Schedule";
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.dgDrSchedule);
            this.leftPanel.Location = new System.Drawing.Point(0, 356);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(583, 321);
            this.leftPanel.TabIndex = 13;
            // 
            // dgDrSchedule
            // 
            this.dgDrSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDrSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.dgDrSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDrSchedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgDrSchedule.Location = new System.Drawing.Point(0, 39);
            this.dgDrSchedule.Name = "dgDrSchedule";
            this.dgDrSchedule.RowTemplate.Height = 24;
            this.dgDrSchedule.Size = new System.Drawing.Size(583, 282);
            this.dgDrSchedule.TabIndex = 4;
            // 
            // dgAppointmentReport
            // 
            this.dgAppointmentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAppointmentReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppointmentReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgAppointmentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointmentReport.Location = new System.Drawing.Point(616, 200);
            this.dgAppointmentReport.Name = "dgAppointmentReport";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAppointmentReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dgAppointmentReport.RowTemplate.Height = 24;
            this.dgAppointmentReport.Size = new System.Drawing.Size(976, 477);
            this.dgAppointmentReport.TabIndex = 15;
            this.dgAppointmentReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAppointmentReport_CellContentClick);
            this.dgAppointmentReport.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAppointmentReport_CellMouseClick);
            // 
            // txtAptID
            // 
            this.txtAptID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAptID.Location = new System.Drawing.Point(479, 13);
            this.txtAptID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAptID.Name = "txtAptID";
            this.txtAptID.Size = new System.Drawing.Size(94, 27);
            this.txtAptID.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Appointment ID";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "To Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "From Time";
            // 
            // dtptotime
            // 
            this.dtptotime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptotime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtptotime.Location = new System.Drawing.Point(368, 154);
            this.dtptotime.Name = "dtptotime";
            this.dtptotime.ShowUpDown = true;
            this.dtptotime.Size = new System.Drawing.Size(205, 24);
            this.dtptotime.TabIndex = 5;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttmNewAppointment,
            this.ttmBookAppointment,
            this.updateAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.displayAppointmentToolStripMenuItem,
            this.printAppointmentReportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1562, 94);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ttmNewAppointment
            // 
            this.ttmNewAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttmNewAppointment.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.Add;
            this.ttmNewAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttmNewAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ttmNewAppointment.Name = "ttmNewAppointment";
            this.ttmNewAppointment.Size = new System.Drawing.Size(166, 90);
            this.ttmNewAppointment.Text = "&NewAppointment";
            this.ttmNewAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttmNewAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttmNewAppointment.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // ttmBookAppointment
            // 
            this.ttmBookAppointment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttmBookAppointment.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.Appointment;
            this.ttmBookAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttmBookAppointment.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ttmBookAppointment.Name = "ttmBookAppointment";
            this.ttmBookAppointment.Size = new System.Drawing.Size(176, 90);
            this.ttmBookAppointment.Text = "&Book Appointment";
            this.ttmBookAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttmBookAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ttmBookAppointment.Click += new System.EventHandler(this.ttmBookAppointment_Click);
            // 
            // updateAppointmentToolStripMenuItem
            // 
            this.updateAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateAppointmentToolStripMenuItem.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.update;
            this.updateAppointmentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateAppointmentToolStripMenuItem.Name = "updateAppointmentToolStripMenuItem";
            this.updateAppointmentToolStripMenuItem.Size = new System.Drawing.Size(194, 90);
            this.updateAppointmentToolStripMenuItem.Text = "&Update Appointment";
            this.updateAppointmentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateAppointmentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.updateAppointmentToolStripMenuItem.Click += new System.EventHandler(this.updateAppointmentToolStripMenuItem_Click);
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAppointmentToolStripMenuItem.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.psd_delete_icon;
            this.cancelAppointmentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(187, 90);
            this.cancelAppointmentToolStripMenuItem.Text = "&Cancel Appointment";
            this.cancelAppointmentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem2.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.registration60x60;
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 90);
            this.toolStripMenuItem2.Text = "&Registration";
            this.toolStripMenuItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // displayAppointmentToolStripMenuItem
            // 
            this.displayAppointmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAppointmentToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayAppointmentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.displayAppointmentToolStripMenuItem.Name = "displayAppointmentToolStripMenuItem";
            this.displayAppointmentToolStripMenuItem.Size = new System.Drawing.Size(194, 90);
            this.displayAppointmentToolStripMenuItem.Text = "&Display Appointment";
            this.displayAppointmentToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.displayAppointmentToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.displayAppointmentToolStripMenuItem.Click += new System.EventHandler(this.displayAppointmentToolStripMenuItem_Click);
            // 
            // printAppointmentReportToolStripMenuItem
            // 
            this.printAppointmentReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printAppointmentReportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printAppointmentReportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printAppointmentReportToolStripMenuItem.Name = "printAppointmentReportToolStripMenuItem";
            this.printAppointmentReportToolStripMenuItem.Size = new System.Drawing.Size(234, 90);
            this.printAppointmentReportToolStripMenuItem.Text = "&Print Appointment Report";
            this.printAppointmentReportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dtpfromtime
            // 
            this.dtpfromtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfromtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpfromtime.Location = new System.Drawing.Point(105, 154);
            this.dtpfromtime.Name = "dtpfromtime";
            this.dtpfromtime.ShowUpDown = true;
            this.dtpfromtime.Size = new System.Drawing.Size(194, 24);
            this.dtpfromtime.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = " Date";
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd-mm-yy";
            this.dtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(387, 108);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(193, 24);
            this.dtpdate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Consultant/Dr.";
            // 
            // cmboConsultant
            // 
            this.cmboConsultant.FormattingEnabled = true;
            this.cmboConsultant.Location = new System.Drawing.Point(105, 112);
            this.cmboConsultant.Name = "cmboConsultant";
            this.cmboConsultant.Size = new System.Drawing.Size(237, 24);
            this.cmboConsultant.TabIndex = 2;
            this.cmboConsultant.SelectedIndexChanged += new System.EventHandler(this.cmboConsultant_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Patient Name";
            // 
            // txtContactno
            // 
            this.txtContactno.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactno.Location = new System.Drawing.Point(105, 63);
            this.txtContactno.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactno.Name = "txtContactno";
            this.txtContactno.Size = new System.Drawing.Size(256, 27);
            this.txtContactno.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAptID);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtptotime);
            this.panel2.Controls.Add(this.dtpfromtime);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtpdate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmboConsultant);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtContactno);
            this.panel2.Controls.Add(this.txtPName);
            this.panel2.Location = new System.Drawing.Point(12, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 191);
            this.panel2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contact No";
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(105, 13);
            this.txtPName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(256, 27);
            this.txtPName.TabIndex = 0;
            // 
            // dtpSearchAppointment
            // 
            this.dtpSearchAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchAppointment.Location = new System.Drawing.Point(1128, 115);
            this.dtpSearchAppointment.Name = "dtpSearchAppointment";
            this.dtpSearchAppointment.Size = new System.Drawing.Size(200, 22);
            this.dtpSearchAppointment.TabIndex = 17;
            this.dtpSearchAppointment.ValueChanged += new System.EventHandler(this.dtpSearchAppointment_ValueChanged);
            // 
            // cmbSearch
            // 
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Date",
            "Patient Name",
            "Consultant Name"});
            this.cmbSearch.Location = new System.Drawing.Point(683, 117);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(208, 24);
            this.cmbSearch.TabIndex = 16;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(916, 114);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 27);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.Text = "Enter Here";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::Com.Shree.ClinicSystemControllers.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(1344, 101);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 50);
            this.btnSearch.TabIndex = 41;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1423, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "label11";
            // 
            // frmAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 698);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.dtpSearchAppointment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.dgAppointmentReport);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panel2);
            this.Name = "frmAppointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.frmAppointment_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDrSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentReport)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.DataGridView dgDrSchedule;
        private System.Windows.Forms.DataGridView dgAppointmentReport;
        private System.Windows.Forms.TextBox txtAptID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtptotime;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ttmNewAppointment;
        private System.Windows.Forms.ToolStripMenuItem ttmBookAppointment;
        private System.Windows.Forms.ToolStripMenuItem updateAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem displayAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAppointmentReportToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpfromtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboConsultant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContactno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.DateTimePicker dtpSearchAppointment;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label11;
    }
}

