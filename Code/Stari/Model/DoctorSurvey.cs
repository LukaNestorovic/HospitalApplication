/***********************************************************************
 * Module:  Survey.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Survey
 ***********************************************************************/

using System;

namespace Model
{
   public class DoctorSurvey
   {
      public int Id { get; set; }
      public int Grade { get; set; }
      
      public Patient patient { get; set; }
      public Doctor doctor { get; set; }

        public DoctorSurvey(int id, int grade, Patient patient, Doctor doctor)
        {
            Id = id;
            Grade = grade;
            this.patient = patient;
            this.doctor = doctor;
        }

        public DoctorSurvey()
        {
        }
    }
}