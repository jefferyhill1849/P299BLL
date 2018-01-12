using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P299BLL
{
    public class Positions
    {
        private int compID;
        private int jobID;
        private string jobName;
        private string jobType;
        private string description;
        private string notes;

        public int JobID
        {
            get
            {
                return jobID;
            }

            set
            {
            }
        }

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

        public string JobName
        {
            get
            {
                return jobName;
            }

            set
            {
                jobName = value;
            }
        }

        public string JobType
        {
            get
            {
                return jobType;
            }

            set
            {
                jobType = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
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

