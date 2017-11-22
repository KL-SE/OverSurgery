using System;

namespace OverSurgery
{
    public class Appointment
    {
        int id;
        DateTime dateTime;
        GeneralPractitioner gp;
        Patient patient;
        bool cancelled;

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

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }

            set
            {
                dateTime = value;
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

        public bool Cancelled
        {
            get
            {
                return cancelled;
            }

            set
            {
                cancelled = value;
            }
        }
    }
}