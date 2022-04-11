/***********************************************************************
 * Module:  Meeting.cs
 * Author:  Ryzen
 * Purpose: Definition of the Class Meeting
 ***********************************************************************/

using System;
using System.Collections;

namespace Model
{
   public class Meeting
   {
      public DateTime DateTime { get; set; }
      public int Duration { get; set; }
      public String Description { get; set; }
      public int Id { get; set; }
      
      public System.Collections.ArrayList doctor;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetDoctor()
      {
         if (doctor == null)
            doctor = new System.Collections.ArrayList();
         return doctor;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctor(System.Collections.ArrayList newDoctor)
      {
         RemoveAllDoctor();
         foreach (Doctor oDoctor in newDoctor)
            AddDoctor(oDoctor);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctor(Doctor newDoctor)
      {
         if (newDoctor == null)
            return;
         if (this.doctor == null)
            this.doctor = new System.Collections.ArrayList();
         if (!this.doctor.Contains(newDoctor))
            this.doctor.Add(newDoctor);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctor(Doctor oldDoctor)
      {
         if (oldDoctor == null)
            return;
         if (this.doctor != null)
            if (this.doctor.Contains(oldDoctor))
               this.doctor.Remove(oldDoctor);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctor()
      {
         if (doctor != null)
            doctor.Clear();
      }
      public Secretary secretary { get; set; }
      public Room room { get; set; }

        public Meeting(DateTime dateTime, int duration, string description, int id, ArrayList doctor, Secretary secretary, Room room)
        {
            DateTime = dateTime;
            Duration = duration;
            Description = description;
            Id = id;
            this.doctor = doctor;
            this.secretary = secretary;
            this.room = room;
        }

        public Meeting()
        {
        }
    }
}