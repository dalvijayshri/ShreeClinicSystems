using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Shree.ClinicSystemModels;
using Com.Shree.ClinicSystemDAO;
using System.Data;

namespace Com.Shree.ClinicSystemServices
{
   public  class MasterConsultantServices
    {
       private string SP_Procedure = "SP_Master_Consultant";
       MasterConsultantDAO objMasterConsultantDAO;
       public MasterConsultantServices()
       {
           objMasterConsultantDAO = new MasterConsultantDAO();
       }
        public DataSet Load(MasterConsultantDO Obj1)
        {
            DataSet DS = new DataSet();
            return DS = objMasterConsultantDAO.ExecuteDataset(objMasterConsultantDAO.OpenConnection(), SP_Procedure, true, Obj1.SQLParameters);
        }
       public DataTable getConsultantList(MasterConsultantDO obj)
        {
            //DataTable dt = objMasterConsultantDAO.LoadConsultantCombo(obj);
            DataTable dt = objMasterConsultantDAO.LoadConsultantDT(obj);
            return dt;
        }
    }
}
