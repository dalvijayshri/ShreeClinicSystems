using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Com.Shree.ClinicSystemModels;

namespace Com.Shree.ClinicSystemDAO
{
    public class AppointmentDAO:DBCommon
    {
        
        private SqlCommand Cmd;
        public bool IsValidConnection;
        private string SP_Procedure = "AppointmentSP";
        private string Table_Name = "Appointment";
        private string Primary_Key = "AppointmentID";
        public AppointmentDAO()
        {
           
        }
        public DataSet Load(AppointmentDO ObjAppointmentDO)
        {
            DataSet DS = new DataSet();
            return DS = ExecuteDataset(OpenConnection(), SP_Procedure, true, ObjAppointmentDO.SQLParameters);
        }

      public AppointmentDO Loaddr(AppointmentDO Obj1)
        {
        SqlDataReader dr;

        dr = ExecuteDataReader(OpenConnection(), CommandType.StoredProcedure, SP_Procedure, Obj1.SQLParameters);
        AppointmentDO objDOPatientIntro = new AppointmentDO(dr);
        return objDOPatientIntro;
        dr.Close();
        dr.Dispose();
        objDOPatientIntro = null;
         }

    public void Save(AppointmentDO Obj1, bool IsNew)
         {
        if (IsNew)
        {
            CallInsert(Obj1);

        }
        else
        {
            CallUpdate(Obj1);
        }
        Obj1 = null;
     }

    private void CallInsert(AppointmentDO Obj1)
    {  
        ExecuteNonQuery(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
    }

    private void CallUpdate(AppointmentDO Obj1)
    {
        ExecuteNonQuery(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
    }

    public void Delete(AppointmentDO Obj1)
    {
      ExecuteNonQuery(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
    }

    public int GetMaxCount()
    {
        int i = GetMaxId(Table_Name, Primary_Key);
        return i + 1;
    }
        public DataTable AllAppointmentList(AppointmentDO objAppointmentDO)
        {
            DataTable dt;
            dt = ExecuteDatable(SP_Procedure,true ,objAppointmentDO.SQLParameters);
            return dt;
        }
      
    }

    }

