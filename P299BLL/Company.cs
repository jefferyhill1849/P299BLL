using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P299BLL
{
    public class Company
    {
        private int compID;
        private int industID;
        private string compName;
        private string compStreet;
        private string compCity;
        private string compZip;
        private string compDescript;
        private string compPhone;
        private string compFax;
        private string webAddress;
        private string notes;

        public int CompID
        {
            get
            {
                return compID;
            }

            set
            {
            }
        }

        public int IndustID
        {
            get
            {
                return industID;
            }

            set
            {
            }
        }

        public string CorpName
        {
            get
            {
                return compName;
            }

            set
            {
                compName = value;
            }
        }

        public string CorpAddress
        {
            get
            {
                return compStreet;
            }

            set
            {
                compStreet = value;
            }
        }

        public string CorpCity
        {
            get
            {
                return compCity;
            }

            set
            {
                compCity = value;
            }
        }

        public string CorpZip
        {
            get
            {
                return compZip;
            }

            set
            {
                compZip = value;
            }
        }

        public string CorpDescript
        {
            get
            {
                return compDescript;
            }

            set
            {
                compDescript = value;
            }
        }

        public string CorpPhone
        {
            get
            {
                return compPhone;
            }

            set
            {
                compPhone = value;
            }
        }

        public string CorpFax
        {
            get
            {
                return compFax;
            }

            set
            {
                compFax = value;
            }
        }

        public string WebAddress
        {
            get
            {
                return webAddress;
            }

            set
            {
                webAddress = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
    }
}

