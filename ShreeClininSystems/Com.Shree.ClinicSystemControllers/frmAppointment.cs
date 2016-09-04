using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Com.Shree.ClinicSystemModels;
using Com.Shree.ClinicSystemServices;
using System.Windows.Forms;

namespace Com.Shree.ClinicSystemControllers
{
    public partial class frmAppointment : Form
    {
        AppointmentServices objAppointmentservices;
        MasterConsultantServices objMasterConsultantSerices;
        DrScheduleServices objDrScheduleServices;
        
       
        public void DeclareAllObj()
        {
            try
            {
               
                objAppointmentservices = new AppointmentServices();
                objMasterConsultantSerices = new MasterConsultantServices();
                objDrScheduleServices = new DrScheduleServices();
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public frmAppointment()
        {
            try
            {

                InitializeComponent();

                DeclareAllObj();
                FillCombo(false);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void FillCombo(bool update)
        {

        }

        private void frmAppointment_Load(object sender, EventArgs e)
        {
            defaultloadallControlValues();
          

        }
          public void defaultloadallControlValues()
          {
            
            
              try
              {
                  //Default gridview load with all dr schedule
                  DODrSchedule objdodrschedule = new DODrSchedule();
                  //objdodrschedule.Flag = 1;
                  dgDrSchedule.DataSource = objDrScheduleServices.getAllDrSchedule(objdodrschedule);
                  //Consultant Combobox load
                  MasterConsultantDO objMasterConsultantDO = new MasterConsultantDO();
                  objMasterConsultantDO.Flag = 4;//To load combobox with consultant full name as display member and Consultant Id as value member
                  DataTable dt = objMasterConsultantSerices.getConsultantList(objMasterConsultantDO);
                  cmboConsultant.DataSource = dt;
                  cmboConsultant.ValueMember = "ConsultantID";
                  cmboConsultant.DisplayMember = "Name";
                  DataRow drr;
                  drr = dt.NewRow();
                  drr["ConsultantID"] = "0";
                  drr["Name"] = "$---Select---$";
                  dt.Rows.Add(drr);
                  dt.DefaultView.Sort = "Name asc";

                  //-------------------------

                  cmboConsultant.DataSource = dt;
                  cmboConsultant.DisplayMember = "Name";
                  cmboConsultant.ValueMember = "ConsultantID";
                  cmboConsultant.Text = "$---Select---$";

                  //  //All Appointment Load
                  refreshAppointmentList();

                  //Searchcombo box initialized
                  cmbSearch.Text = "Search Appointment By";

              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }
          }
        public void refreshAppointmentList()
          {
              AppointmentDO objAppointmentDO = new AppointmentDO();
              objAppointmentDO.Flag = 4;
              dgAppointmentReport.DataSource = objAppointmentservices.getAllAppointmentList(objAppointmentDO);
          }

          private void cmboConsultant_SelectedIndexChanged(object sender, EventArgs e)
          {
              try
              {
                  if (cmboConsultant.SelectedIndex > 0)
                  {
                      DODrSchedule objdodrschedule = new DODrSchedule();
                      objdodrschedule.ConsultantID = Convert.ToInt32(cmboConsultant.SelectedValue);
                      objdodrschedule.Flag = 2;
                      DataTable dt = objDrScheduleServices.getSelectedDrSchedule(objdodrschedule);
                      dgDrSchedule.DataSource = dt;
                  }
              }
              catch(Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }
          }

          private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
          {
             
          }

          private void btnSearch_Click(object sender, EventArgs e)
          {
              try
              {
                  AppointmentDO objAppointmentDO = new AppointmentDO();
                  if (cmbSearch.SelectedText=="Date")
                  {
                      
                      objAppointmentDO.Flag = 5;
                      objAppointmentDO.AppointmentDate = dtpSearchAppointment.Value;
                      dgAppointmentReport.DataSource = objAppointmentservices.getAllAppointmentList(objAppointmentDO);
                  }
                  if(cmbSearch.Text=="Patient Name")
                  {
                      objAppointmentDO.Flag = 6;
                      objAppointmentDO.PatientName = txtSearch.Text;
                     
                      dgAppointmentReport.DataSource = objAppointmentservices.getAllAppointmentList(objAppointmentDO);
                  }
                  if (cmbSearch.Text == "Consultant Name")
                  {
                      objAppointmentDO.Flag = 7;
                      objAppointmentDO.ConsultantName= txtSearch.Text;
                      dgAppointmentReport.DataSource = objAppointmentservices.getAllAppointmentList(objAppointmentDO);
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());
              }
          }

          private void bookToolStripMenuItem_Click(object sender, EventArgs e)
          {
              txtPName.Clear();
              txtContactno.Clear();
              cmboConsultant.SelectedIndex = 0;
          }

        

          private void dgAppointmentReport_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
          {
              txtAptID.Text = dgAppointmentReport.SelectedRows[0].Cells[0].Value.ToString();
              txtPName.Text = dgAppointmentReport.SelectedRows[0].Cells[1].Value.ToString();
              txtContactno.Text = dgAppointmentReport.SelectedRows[0].Cells[2].Value.ToString();
              cmboConsultant.Text = dgAppointmentReport.SelectedRows[0].Cells[3].Value.ToString();
              dtpfromtime.Text = dgAppointmentReport.SelectedRows[0].Cells[5].Value.ToString();
              dtptotime.Text = dgAppointmentReport.SelectedRows[0].Cells[6].Value.ToString();
              dtpdate.Text = dgAppointmentReport.SelectedRows[0].Cells[7].Value.ToString();

          }

          private void ttmBookAppointment_Click(object sender, EventArgs e)
          {
              try
              {
                  AppointmentDO objAppointmentDO = new AppointmentDO();
                  objAppointmentDO.PatientName = txtPName.Text;
                  objAppointmentDO.ContactNo = txtContactno.Text;

                  objAppointmentDO.ConsultantID = (int)cmboConsultant.SelectedValue;
                  objAppointmentDO.ConsultantName = cmboConsultant.Text;
                  //System.Console.WriteLine("********************* Consultant Name" + cmboConsultant.Text + "88888888888" + objdoappointment.ConsultantName);

                  objAppointmentDO.FromTime = dtpfromtime.Value.ToShortTimeString();
                  objAppointmentDO.ToTime = dtptotime.Value.ToShortTimeString();
                  objAppointmentDO.AppointmentDate = dtpdate.Value;
                  objAppointmentDO.Flag = 1;
                  objAppointmentservices.getBookChangeAppointment(objAppointmentDO,true);
                  MessageBox.Show("Appointment Booked Successfully");
                  refreshAppointmentList();

              }
              catch (Exception exp)
              {
                  MessageBox.Show(exp.ToString());
              }
          }

          private void updateAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
          {
              try
              {
                  AppointmentDO objAppointmentDO = new AppointmentDO();
                  objAppointmentDO.PatientName = txtPName.Text;
                  objAppointmentDO.ContactNo = txtPName.Text;
                  objAppointmentDO.AppointmentID = Convert.ToInt32(txtAptID.Text);
                  objAppointmentDO.ConsultantID = (int)cmboConsultant.SelectedValue;
                  objAppointmentDO.ConsultantName = cmboConsultant.Text;
                  //System.Console.WriteLine("********************* Consultant Name" + cmboConsultant.Text + "88888888888" + objdoappointment.ConsultantName);

                  objAppointmentDO.FromTime = dtpfromtime.Value.ToShortTimeString();
                  objAppointmentDO.ToTime = dtptotime.Value.ToShortTimeString();
                  objAppointmentDO.AppointmentDate = dtpdate.Value.Date;
                  objAppointmentDO.Flag = 2;
                  objAppointmentservices.getBookChangeAppointment(objAppointmentDO,false);
                  MessageBox.Show("Appointment Changed Successfully");
                  refreshAppointmentList();


              }
              catch (Exception exp)
              {
                  MessageBox.Show(exp.ToString());
              }
          }

          private void dgAppointmentReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
          {

          }

          private void cancelAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
          {
              AppointmentDO objAppointmentDO = new AppointmentDO();
              objAppointmentDO.Flag = 3;
              objAppointmentDO.AppointmentID = Convert.ToInt32(txtAptID.Text);
              objAppointmentservices.getCancelAppointment(objAppointmentDO);
              MessageBox.Show("Appointment Cancelled Successfully");
              refreshAppointmentList();
          }

          private void displayAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
          {
              refreshAppointmentList();
          }

          private void toolStripMenuItem2_Click(object sender, EventArgs e)
          {
              string PName=txtPName.Text;
              string ContactNo=txtContactno.Text;
              frmRegistration f=new frmRegistration( PName,ContactNo);
              f.Show();
          }

          private void dtpSearchAppointment_ValueChanged(object sender, EventArgs e)
          {
              AppointmentDO objAppointmentDO = new AppointmentDO();
            

                  objAppointmentDO.Flag = 5;
                  objAppointmentDO.AppointmentDate = dtpSearchAppointment.Value.Date;
                  label11.Text = dtpSearchAppointment.Value.Date.ToShortDateString();
                  dgAppointmentReport.DataSource = objAppointmentservices.getAllAppointmentList(objAppointmentDO);
                  refreshAppointmentList();
          }

         
    }
}
