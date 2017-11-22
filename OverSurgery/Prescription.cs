using System;
using System.Collections.Generic;

namespace OverSurgery
{
    public class Prescription
    {
        int id;
        GeneralPractitioner gp;
        Patient patient;
        DateTime prescribed;
        DateTime expires;
        List<Medication> medications;

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

        public DateTime Prescribed
        {
            get
            {
                return prescribed;
            }

            set
            {
                prescribed = value;
            }
        }

        public DateTime Expires
        {
            get
            {
                return expires;
            }

            set
            {
                expires = value;
            }
        }

        public List<Medication> Medications
        {
            get
            {
                return medications;
            }

            set
            {
                medications = value;
            }
        }
    }
}