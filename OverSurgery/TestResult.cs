using System;

namespace OverSurgery
{
    public class TestResult
    {
        int id;
        GeneralPractitioner gp;
        Patient patient;
        string title;
        string description;
        string result;
        string remark;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public GeneralPractitioner Gp
        {
            get
            {
                return gp;
            }

            set
            {
                gp = value;
            }
        }

        public Patient Patient
        {
            get
            {
                return patient;
            }

            set
            {
                patient = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
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

        public string Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
            }
        }

        public string Remark
        {
            get
            {
                return remark;
            }

            set
            {
                remark = value;
            }
        }
    }
}