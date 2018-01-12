using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P299BLL
{
    public class Interview
    {
        private int interviewID;
        private int corpID;
        private int contactID;
        private DateTime interviewDate;
        private string outcome;
        private int jobID;
        private string notes;

        public int InterviewID
        {
            get
            {
                return interviewID;
            }

            set
            {
                interviewID = value;
            }
        }

        public int CorpID
        {
            get
            {
                return corpID;
            }

            set
            {
                corpID = value;
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
                contactID = value;
            }
        }

        public int JobID
        {
            get
            {
                return jobID;
            }

            set
            {
                jobID = value;
            }
        }

        public DateTime InterviewDate
        {
            get
            {
                return interviewDate;
            }

            set
            {
                interviewDate = value;
            }
        }

        public string Outcome
        {
            get
            {
                return outcome;
            }

            set
            {
                outcome = value;
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