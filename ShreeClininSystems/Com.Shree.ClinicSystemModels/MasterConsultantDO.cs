using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Com.Shree.ClinicSystemModels
{
    public class MasterConsultantDO
    {
        private int _ConsultantID;
        private int _EmployeeID;
        private DateTime _CreatedDate;
        private int _Flag;

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

        public int EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }
        public DateTime CreatedDate
        {
            get
            {
                return _CreatedDate;
            }
            set
            {
                _CreatedDate = value;
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

        public MasterConsultantDO(SqlDataReader dr)
        {
            dr.Read();
            _ConsultantID = Convert.ToInt32(dr["ConsultantID"]);
            _EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
            _CreatedDate = Convert.ToDateTime(dr["CreatedDate"]);
            dr.Close();
        }
        //private int _ConsultantID;
        //private int _EmployeeID;
        //private DateTime _CreatedDate;
        //private int _Flag;
        public MasterConsultantDO()
        {
            _ConsultantID = 0;
            _EmployeeID = 0;
            _CreatedDate = System.DateTime.Now; ;
            _Flag = 5;
        }

        public MasterConsultantDO(int ConsultantID, int EmployeeID, DateTime CreatedDate, int Flag)
        {
            _ConsultantID = ConsultantID;
            _EmployeeID = EmployeeID;
            _CreatedDate = CreatedDate;
            _Flag = Flag;
        }

        public SqlParameter[] SQLParameters
        {
            get
            {
                SqlParameter[] Parameters = new SqlParameter[4];
                Parameters[0] = new SqlParameter("@ConsultantID", ConsultantID);
                Parameters[1] = new SqlParameter("@EmployeeID", EmployeeID);
                Parameters[2] = new SqlParameter("@CreatedDate", CreatedDate);
                Parameters[3] = new SqlParameter("@Flag", Flag);
                return Parameters;
            }
        }
    }
}
