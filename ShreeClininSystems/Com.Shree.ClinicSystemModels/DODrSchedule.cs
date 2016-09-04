using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Com.Shree.ClinicSystemModels
{
    public class DODrSchedule
    {

        private int _ConsultantID;
        private int _EmployeeID;
        private int _StartTime;
        private int _EndTime;
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
        public int StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                _StartTime = value;
            }
        }

        public int EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                _EndTime = value;
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
        public DODrSchedule()
        {
            _ConsultantID = 0;
            _EmployeeID = 0;
            _StartTime = 0;
            _EndTime = 0;
            _Flag = 1;

        }
        public SqlParameter[] SQLParameters
        {
            get
            {
                SqlParameter[] Parameters = new SqlParameter[5];
                Parameters[0] = new SqlParameter("@ConsultantID", ConsultantID);
                Parameters[1] = new SqlParameter("@EmployeeID", EmployeeID);
                Parameters[2] = new SqlParameter("@StartTime", StartTime);
                Parameters[3] = new SqlParameter("@EndTime", EndTime);
                Parameters[4] = new SqlParameter("@Flag", Flag);
                return Parameters;
            }
        }
      
    }
}
