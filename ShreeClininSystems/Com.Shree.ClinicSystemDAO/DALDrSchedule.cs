using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Shree.ClinicSystemModels;
using System.Data;
using System.Data.SqlClient;

namespace Com.Shree.ClinicSystemDAO
{
    public class DALDrSchedule:DBCommon
    {
        //private SqlConnection conn;
        //private SqlCommand Cmd;
        public bool IsValidConnection;



        private string SP_Procedure = "DrScheduleSP";
        //private string Table_Name = "DrSchedule";
        //private string Primary_Key = "ConsultantID";


        //public DataTable getselectedDrSchedule(DODrSchedule objdodrschedule)
        //{
        //    int id = objdodrschedule.ConsultantID;

        //    DataTable dt = new DataTable();
        //    SqlConnection con = new SqlConnection("Data Source=USCMPPAJADHAV3\\SQLEXPRESS;Initial Catalog=Db_BNH;Integrated Security=True");
        //    SqlCommand com = new SqlCommand("select e.EmpFName as Doctors_First_Name,e.EmpLName as  Doctors_Last_Name,d.StartTime as INTime,d.EndTime as OUTTime from DrSchedule d,Master_Employee e where e.EmpId=d.EmpId and d.ConsultantID=@id", con);
        //    com.Parameters.AddWithValue("@id", id);
        //    SqlDataAdapter da = new SqlDataAdapter(com);
        //    da.Fill(dt);

        //    return dt;
        //}
        public DataTable DrScheduleList(DODrSchedule obj)
        {
            DataTable dt = ExecuteDatable(SP_Procedure,true,obj.SQLParameters);

            return dt;

        }
        public DataTable SelectedDrSchedule(DODrSchedule obj)
        {
            DataTable dt = ExecuteDatable(SP_Procedure, true,obj.SQLParameters);

            return dt;
        }
    }
}
