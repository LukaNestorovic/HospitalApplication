/***********************************************************************
 * Module:  Patient.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using System;

namespace Model
{
   public class Patient : User
   {
      public int RateDoctor()
      {
         // TODO: implement
         return 0;
      }
      
      public int RateHospital()
      {
         // TODO: implement
         return 0;
      }
   
      public String InsuranceCarrier;
      public Boolean Guest;
   
   }
}