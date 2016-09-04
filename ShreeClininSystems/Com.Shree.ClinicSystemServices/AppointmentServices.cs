using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Shree.ClinicSystemDAO;
using System.Data;
using Com.Shree.ClinicSystemModels;

namespace Com.Shree.ClinicSystemServices
{
    public class AppointmentServices
    {
        AppointmentDAO objAppointmentDAO;
        public AppointmentServices()
        {
            objAppointmentDAO = new AppointmentDAO();
        }
        public DataTable getAllAppointmentList(AppointmentDO objAppointmentDO)
        {
            DataTable dt = objAppointmentDAO.AllAppointmentList(objAppointmentDO);
                return dt;
        }
        public void getBookChangeAppointment(AppointmentDO objAppointmentDO,bool isbookchange)
        {
            objAppointmentDAO.Save(objAppointmentDO, isbookchange);
        }
        public void getCancelAppointment(AppointmentDO objAppointmentDO)
        {
            objAppointmentDAO.Delete(objAppointmentDO);
        }
    }
}
