/***********************************************************************
 * Module:  Survey.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Survey
 ***********************************************************************/

using System;

namespace Model
{
   public class DoctorSurvey
   {
      public int Id;
      public int Grade;
      
      public Patient patient;
      public Doctor doctor;
   
   }
}