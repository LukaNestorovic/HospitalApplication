/***********************************************************************
 * Module:  SavePatient.cs
 * Author:  lukaa
 * Purpose: Definition of the Class SavePatient
 ***********************************************************************/

using System;

namespace Service
{
   public class PatientService
   {
      public Boolean CreatePatient(String name, String surname, String jmbg, Model.Gender gender, String telephone, String email, DateTime birthDate, String adress, int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdatePatient(Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeletePatient(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Patient ReadPatient(int id)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.PatientRepository patientRepository;
   
   }
}