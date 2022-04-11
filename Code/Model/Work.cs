/***********************************************************************
 * Module:  Work.cs
 * Author:  Ryzen
 * Purpose: Definition of the Class Work
 ***********************************************************************/

using System;

namespace Model
{
   public class Work
   {
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }

        public Room[] room;

        public Work(DateTime startDate, DateTime endDate, Room[] room)
        {
            StartDate = startDate;
            EndDate = endDate;
            this.room = room;
        }

        public Work()
        {
        }
    }
}