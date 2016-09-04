using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Com.Shree.ClinicSystemModels;

namespace Com.Shree.ClinicSystemDAO
{
    public class MasterConsultantDAO:DBCommon
    {
         private SqlConnection conn;
        private SqlCommand Cmd;
        public bool IsValidConnection;



        private string SP_Procedure = "SP_Master_Consultant";
        private string Table_Name = "Master_Consultant";
        private string Primary_Key = "ConsultantID";
        public MasterConsultantDAO()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataSet Load(MasterConsultantDO Obj1)
        {
            DataSet DS = new DataSet();
            return DS = ExecuteDataset(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
        }
        public DataTable LoadConsultantDT(MasterConsultantDO Obj1)
        {
            DataTable DS = new DataTable();
            return DS = ExecuteDatable(SP_Procedure, true, Obj1.SQLParameters);
        }

        public MasterConsultantDO Loaddr(MasterConsultantDO Obj1)
        {
            SqlDataReader dr;

            dr = ExecuteDataReader(OpenConnection(), CommandType.StoredProcedure, SP_Procedure, Obj1.SQLParameters);
            MasterConsultantDO objDOMaster_Consultant = new MasterConsultantDO(dr);
            return objDOMaster_Consultant;
            dr.Close();
            dr.Dispose();
            objDOMaster_Consultant = null;
        }

        public void Save(MasterConsultantDO Obj1, bool IsNew)
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

        private void CallInsert(MasterConsultantDO Obj1)
        {
            ExecuteNonQuery(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
        }

        private void CallUpdate(MasterConsultantDO Obj1)
        {
            ExecuteNonQuery(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
        }

        public void Delete(MasterConsultantDO Obj1)
        {
         ExecuteNonQuery(OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
        }
        public int GetMaxCount()
        {
            int i = GetMaxId(Table_Name, Primary_Key);
            return i + 1;
        }
        //public DataTable LoadConsultantCombo(MasterConsultantDO objMasterConsultantDO)
        //{
        //    try
        //    {
        //        SqlCommand com = new SqlCommand(SP_Procedure, OpenConnection());
        //        com.CommandType = CommandType.StoredProcedure;

        //        com.Parameters.AddWithValue("@ConsultantID", objMasterConsultantDO.ConsultantID);
        //        com.Parameters.AddWithValue("@EmployeeID", objMasterConsultantDO.EmployeeID);
        //        com.Parameters.AddWithValue("@CreatedDate", objMasterConsultantDO.CreatedDate);
        //        com.Parameters.AddWithValue("@Flag", objMasterConsultantDO.Flag);
        //        SqlDataAdapter da = new SqlDataAdapter(com);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
              
        //        return dt;
        //    }
        //    catch(Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        CloseConnection();
        //    }
        //}
    }
}
