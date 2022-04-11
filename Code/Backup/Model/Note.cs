/***********************************************************************
 * Module:  Note.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Note
 ***********************************************************************/

using System;

namespace Model
{
   public class Note
   {
      public String Descritpion;
      public DateTime BeginAbsence;
      public DateTime EndAbsence;
      public int Id;
      
      public Patient patient;
      public Doctor doctor;
   
   }
}