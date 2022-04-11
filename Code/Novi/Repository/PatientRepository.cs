/***********************************************************************
 * Module:  PatientRepository.cs
 * Author:  lukaa
 * Purpose: Definition of the Class PatientRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
   public class PatientRepository
   {
      public List<Patient> FindAll()
      {
         // TODO: implement
         return null;
      }
      
      public Patient FindByID(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean Save(Patient patient)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteByID(int id)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean UpdateByID(Patient jmbg)
      {
         // TODO: implement
         return false;
      }
   
      private String FileName;
   
   }
}