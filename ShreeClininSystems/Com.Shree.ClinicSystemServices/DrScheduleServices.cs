using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Com.Shree.ClinicSystemModels;
using Com.Shree.ClinicSystemDAO;
using System.Data;

namespace Com.Shree.ClinicSystemServices
{
  public  class DrScheduleServices
    {
      DALDrSchedule objDALDrSchedule;
      public DrScheduleServices()
      {
          objDALDrSchedule = new DALDrSchedule();
      }

      public DataTable getAllDrSchedule(DODrSchedule objDODrSchedule)
        {

            DataTable dt = objDALDrSchedule.DrScheduleList(objDODrSchedule);
           

            return dt;
        }
      public DataTable getSelectedDrSchedule(DODrSchedule objDODrSchedule)
        {

            DataTable dt = objDALDrSchedule.SelectedDrSchedule(objDODrSchedule);


            return dt;
        }
    }
}
