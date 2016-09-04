using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Com.Shree.ClinicSystemDAO
{
   public class PatientIntroDAO:DBCommon
    {

        public DataTable Load()
        {
        
            SqlCommand com = new SqlCommand("select * from PatientIntro",OpenConnection());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
