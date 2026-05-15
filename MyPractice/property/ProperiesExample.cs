using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPractice.property
{
    internal class ProperiesExample
    {

        #region  // Latest 
        //public ProperiesExample(int _stdId,string _stdName,string _country )
        //{
        //    StdId = _stdId;
        //    StdName = _stdName;

        //    Country = _country;
        //}


        //public int StdId { get; set; } = 000;

        //public string StdName { get; set; } = "No given Any Name";

        //public string StdGender { get; set; } = "Other";

        //public long StdPhone { get; set; } 

        //public string Country { get; set; } = "India";

        #endregion



        public ProperiesExample(int _stdId, string _stdName, string _country)
        {
            this._StdId = _stdId;
            this._StdName = _stdName;

            this._Country = _country;
        }
        private int _StdId=0000;
        private string _StdName;
        private long _StdPhone;
        private string _Country;
        private string _StdGender;


        public int StdId {
            get
            { 
             return _StdId;
            }
            set {
                StdId=value;
            }
        } 
            

        public string StdName
        {
            get
            {
                return _StdName;
            }
            set
            {
                _StdName=value;
            }
        } 

        public string StdGender { get { return _StdGender; } set { _StdGender = value; } }

        public long StdPhone { get { return _StdPhone; } set { _StdPhone = value; } }

        public string Country { get {return _Country } set { _Country = value; } }






    }
}
