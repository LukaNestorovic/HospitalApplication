/***********************************************************************
 * Module:  ExamReport.cs
 * Author:  lukaa
 * Purpose: Definition of the Class ExamReport
 ***********************************************************************/

using System;

namespace Model
{
   public class ExamReport
   {
      public void Operation1()
      {
         // TODO: implement
      }
   
      public String Therhapy { get; set; }
      public String Diagnosis { get; set; }
      public String Symptoms { get; set; }
      public int Id { get; set; }
      
      public Doctor doctor { get; set; }
      public Patient patient { get; set; }

        public ExamReport(string therhapy, string diagnosis, string symptoms, int id, Doctor doctor, Patient patient)
        {
            Therhapy = therhapy;
            Diagnosis = diagnosis;
            Symptoms = symptoms;
            Id = id;
            this.doctor = doctor;
            this.patient = patient;
        }

        public ExamReport()
        {
        }
    }
}