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
      public DateTime Begin;
      public DateTime End;
      public Boolean Approved;
      public int Id;
      
      public Doctor doctor;
   
   }
}