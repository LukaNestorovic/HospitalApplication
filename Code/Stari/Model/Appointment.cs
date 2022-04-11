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
   
      public DateTime DateTime { get; set; }
      public String Descripton { get; set; }
      public int Duration { get; set; }
      public Boolean Emergency { get; set; }
      public int Id { get; set; }
      
      public Patient patient { get; set; }
      public Doctor doctor { get; set; }
      public Room room { get; set; }

        public Appointment(DateTime dateTime, string descripton, int duration, bool emergency, int id, Patient patient, Doctor doctor, Room room)
        {
            DateTime = dateTime;
            Descripton = descripton;
            Duration = duration;
            Emergency = emergency;
            Id = id;
            this.patient = patient;
            this.doctor = doctor;
            this.room = room;
        }

        public Appointment()
        {
        }
    }
}