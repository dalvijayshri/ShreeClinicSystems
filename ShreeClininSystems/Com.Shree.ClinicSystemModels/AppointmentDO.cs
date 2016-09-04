using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Com.Shree.ClinicSystemModels
{
    public class AppointmentDO
    {
        private int _AppointmentID;
        private string _PatientName;
        private string _ContactNo;
        private string _ConsultantName;
        private int _ConsultantID;

        private string _FromTime;
        private string _ToTime;
        private DateTime _AppointmentDate;

       
        private int _Flag;
        public int AppointmentID
        {
            get
            {
                return _AppointmentID;
            }
            set
            {
                _AppointmentID = value;
            }
        }

        public string PatientName
        {
            get
            {
                return _PatientName;
            }
            set
            {
                _PatientName = value;
            }
        }
        public string ContactNo
        {
            get
            {
                return _ContactNo;
            }
            set
            {
                _ContactNo = value;
            }
        }
        public string ConsultantName
        {
            get
            {
                return _ConsultantName;
            }
            set
            {
                _ConsultantName = value;
            }
        }
        public int ConsultantID
        {
            get
            {
                return _ConsultantID;
            }
            set
            {
                _ConsultantID = value;
            }
        }
        public string FromTime
        {
            get
            {
                return _FromTime;
            }
            set
            {
                _FromTime = value;
            }
        }
        public string ToTime
        {
            get
            {
                return _ToTime;
            }
            set
            {
                _ToTime = value;
            }
        }
        public DateTime AppointmentDate
        {
            get
            {
                return _AppointmentDate;
            }
            set
            {
                _AppointmentDate = value;
            }
        }
     
        public int Flag
        {
            get
            {
                return _Flag;
            }
            set
            {
                _Flag = value;
            }
        }
        public AppointmentDO(SqlDataReader dr)
    {
        dr.Read();
        _AppointmentID = Convert.ToInt32(dr["AppointmentID"]);
        _PatientName = Convert.ToString(dr["PatientName"]);
        _ContactNo = Convert.ToString(dr["ContactNo"]);
        _ConsultantName = Convert.ToString(dr["ConsultantName"]);
        _ConsultantID = Convert.ToInt32(dr["ConsultantID"]);
        _FromTime = Convert.ToString(dr["FromTime"]);
        _ToTime = Convert.ToString(dr["ToTime"]);
        _AppointmentDate = Convert.ToDateTime(dr["AppointmentDate"]);
        _Flag = Convert.ToInt32(dr["Flag"]);
        dr.Close();
    }

   public AppointmentDO()
    {

        _AppointmentID = 0;
        _PatientName = "";
        _ContactNo = "";
        _ConsultantName = "";
        _ConsultantID = 0;
        _FromTime = "";
        _ToTime = "";
        _AppointmentDate = System.DateTime.Now;
        _Flag = 0;
                   
    }
   public AppointmentDO(int AppointmentID, string PatientName, string ContactNo, string ConsultantName, int ConsultantID, string _FromTime,string ToTime,DateTime AppointmentDate,int Flag )
    {
        _AppointmentID = AppointmentID;
        _PatientName = PatientName;
        _ContactNo = ContactNo;
        _ConsultantName = ConsultantName;
        _ConsultantID = ConsultantID;
        _FromTime = FromTime;
        _ToTime = ToTime;
        _AppointmentDate = AppointmentDate;
        _Flag = Flag;
      
    }

   public SqlParameter[] SQLParameters
   {
       get
       {
           SqlParameter[] Parameters = new SqlParameter[9];

           Parameters[0] = new SqlParameter("@AppointmentID", AppointmentID);
           Parameters[1] = new SqlParameter("@PatientName", PatientName);
           Parameters[2] = new SqlParameter("@ContactNo", ContactNo);
           Parameters[3] = new SqlParameter("@ConsultantName", ConsultantName);
           Parameters[4] = new SqlParameter("@ConsultantID", ConsultantID);
           Parameters[5] = new SqlParameter("@FromTime", FromTime);
           Parameters[6] = new SqlParameter("@ToTime", ToTime);
           Parameters[7] = new SqlParameter("@AppointmentDate", AppointmentDate);
           Parameters[8] = new SqlParameter("@Flag", Flag);
           return Parameters;
       }
   }
    }
}
