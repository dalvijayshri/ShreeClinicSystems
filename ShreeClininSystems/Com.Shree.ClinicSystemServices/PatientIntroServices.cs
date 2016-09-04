using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Com.Shree.ClinicSystemDAO;
namespace Com.Shree.ClinicSystemServices
{
   public class PatientIntroServices
    {
       public DataTable getPatientList()
        {
            PatientIntroDAO objpatientintrodao = new PatientIntroDAO();
            return objpatientintrodao.Load();
        }
    }
}
