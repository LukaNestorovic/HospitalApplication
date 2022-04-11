/***********************************************************************
 * Module:  MedicalRecord.cs
 * Author:  lukaa
 * Purpose: Definition of the Class MedicalRecord
 ***********************************************************************/

using System;

namespace Model
{
   public class MedicalRecord
   {
      public String Allergies { get; set; }
      
      public Patient patient { get; set; }

        public MedicalRecord(string allergies, Patient patient)
        {
            Allergies = allergies;
            this.patient = patient;
        }

        public MedicalRecord()
        {
        }
    }
}