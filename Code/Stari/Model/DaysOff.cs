/***********************************************************************
 * Module:  DaysOff.cs
 * Author:  Ryzen
 * Purpose: Definition of the Class DaysOff
 ***********************************************************************/

using System;

namespace Model
{
   public class DaysOff
   {
      public DateTime Begin { get; set; }
      public DateTime End { get; set; }
      public Boolean Approved { get; set; }
      public int Id { get; set; }
      
      public Doctor doctor { get; set; }

        public DaysOff(DateTime begin, DateTime end, bool approved, int id, Doctor doctor)
        {
            Begin = begin;
            End = end;
            Approved = approved;
            Id = id;
            this.doctor = doctor;
        }

        public DaysOff()
        {
        }
    }
}