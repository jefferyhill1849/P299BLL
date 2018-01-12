using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P299BLL
{
    public class Industry
    {
        private int industID;
        private string industDescript;
        private string industType;
        private string notes;

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

        public string IndustDescript
        {
            get
            {
                return industDescript;
            }

            set
            {
                industDescript = value;
            }
        }

        public string IndustType
        {
            get
            {
                return industType;
            }

            set
            {
                industType = value;
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

