using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P299BLL
{
    public class Contacts
    {
        private int compID;
        private int contactID;
        private string firstName;
        private string lastName;
        private string phoneNum;
        private string contactTitle;
        private string methOfContact;
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

        public int ContactID
        {
            get
            {
                return contactID;
            }

            set
            {
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string PhoneNum
        {
            get
            {
                return phoneNum;
            }

            set
            {
                phoneNum = value;
            }
        }

        public string ContactTitle
        {
            get
            {
                return contactTitle;
            }

            set
            {
                contactTitle = value;
            }
        }

        public string MethOfContact
        {
            get
            {
                return methOfContact;
            }

            set
            {
                methOfContact = value;
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