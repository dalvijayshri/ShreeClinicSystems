using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Shree.ClinicSystemModels
{
    public class PatientIntroDO
    {

        private string _MRMS, _PatientFName
                      , _PatientMName
                      , _PatientLName
                      , _Address
                      , _Gender
                      , _City
                      , _State
                      , _Phone
            // , _Mobile
                      , _Remarks
                      ,_BloodGroup
                      , _EmailID
                       , _PatientIdWithSr;
        private DateTime _AddedOn,_DOB;

        private int _PatientId,
            _Age
                   , _ReferredId
                   , _ConsultantId
                   , _AddedBy;
        private decimal _Weight;

        private int _Flag;

        public int PatientId
        {
            get
            {
                return _PatientId;
            }
            set
            {
                _PatientId = value;
            }
        }
        public string PatientFName
        {
            get
            {
                return _PatientFName;
            }
            set
            {
                _PatientFName = value;
            }
        }
        public string EmailID
        {
            get
            {
                return _EmailID;
            }
            set
            {
                _EmailID = value;
            }
        }
        public string PatientMName
        {
            get
            {
                return _PatientMName;
            }
            set
            {
                _PatientMName = value;
            }
        }
        public string PatientLName
        {
            get
            {
                return _PatientLName;
            }
            set
            {
                _PatientLName = value;
            }
        }
        public string BloodGroup
        {
            get
            {
                return _BloodGroup;
            }
            set
            {
                _BloodGroup = value;
            }
        }
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }
        }
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
      
        public string Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                _Gender = value;
            }
        }

       
       
        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
            }
        }

        public string State
        {
            get
            {
                return _State;
            }
            set
            {
                _State = value;
            }
        }
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
        
       
        public int ReferredId
        {
            get
            {
                return _ReferredId;
            }
            set
            {
                _ReferredId = value;
            }
        }
        public int ConsultantId
        {
            get
            {
                return _ConsultantId;
            }
            set
            {
                _ConsultantId = value;
            }
        }
        public string Remarks
        {
            get
            {
                return _Remarks;
            }
            set
            {
                _Remarks = value;
            }
        }
        public int AddedBy
        {
            get
            {
                return _AddedBy;
            }
            set
            {
                _AddedBy = value;
            }
        }
        public DateTime AddedOn
        {
            get
            {
                return _AddedOn;
            }
            set
            {
                _AddedOn = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return _DOB;
            }
            set
            {
                _DOB = value;
            }
        }
        public string MRMS
        {
            get
            {
                return _MRMS;
            }
            set
            {
                _MRMS = value;
            }
        }
        //---------------------
        public string PatientIdWithSr
        {
            get
            {
                return _PatientIdWithSr;
            }
            set
            {
                _PatientIdWithSr = value;
            }
        }
        public decimal Weight
        {
            get
            {
                return _Weight;
            }
            set
            {
                _Weight = value;
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
    }
}
