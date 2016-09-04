using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Shree.ClinicSystemModels;
using Com.Shree.ClinicSystemServices;
namespace Com.Shree.ClinicSystemControllers
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ttmAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment f = new frmAppointment();
            //f.MdiParent = this;
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //AppointmentServices s = new AppointmentServices();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ttmOPDConsultation_Click(object sender, EventArgs e)
        {

        }
    }
}
