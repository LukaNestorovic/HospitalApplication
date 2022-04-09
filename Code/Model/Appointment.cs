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
   
      public DateTime DateTime;
      public String Descripton;
      public int Duration;
      public Boolean Emergency;
      public int Id;
      
      public Patient patient;
      public Doctor doctor;
      public Room room;
   
   }
}