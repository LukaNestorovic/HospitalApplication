/***********************************************************************
 * Module:  HospitalSurvey.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Model.HospitalSurvey
 ***********************************************************************/

using System;

namespace Model
{
   public class HospitalSurvey
   {
      public int Grade { get; set; }
      public int Id { get; set; }
      
      public Patient patient { get; set; }

        public HospitalSurvey(int grade, int id, Patient patient)
        {
            Grade = grade;
            Id = id;
            this.patient = patient;
        }

        public HospitalSurvey()
        {
        }
    }
}