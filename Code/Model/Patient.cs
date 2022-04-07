/***********************************************************************
 * Module:  Patient.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

using System;

namespace Model
{
   public class Patient : User, User
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
   
      private String InsuranceCarrier;
   
   }
}