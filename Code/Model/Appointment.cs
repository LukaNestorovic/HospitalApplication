/***********************************************************************
 * Module:  Appointment.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Appointment
 ***********************************************************************/

using System;

namespace Model
{
   public class Appointment
   {
      public float GetDoctorGrade()
      {
         // TODO: implement
         return 0.0F;
      }
   
      public Doctor doctor;
      public Patient patient;
   
      private DateTime DateTime;
      private String Descripton;
      private int Duration;
      private Boolean Emergency;
      private int Id;
      private Boolean Taken;
   
   }
}