using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Com.Shree.ClinicSystemServices;

namespace Com.Shree.ClinicSystemControllers
{
    public partial class frmRegistration : Form
    {
        PatientIntroServices objpatientintroservices;
        public frmRegistration()
        {
            InitializeComponent();
            objpatientintroservices = new PatientIntroServices();
        }
        public frmRegistration(string PName,string ContactNo)
        {
            InitializeComponent();
            objpatientintroservices = new PatientIntroServices();
            txtFName.Text = PName;
            txtPhone.Text = ContactNo;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Today.Year - dtpDOB.Value.Year).ToString();
           
        
       
   
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            dgvPatientList.DataSource = objpatientintroservices.getPatientList();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
