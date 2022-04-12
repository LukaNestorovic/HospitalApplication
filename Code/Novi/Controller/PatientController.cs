/***********************************************************************
 * Module:  PatientController.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Controller.PatientController
 ***********************************************************************/

using System;
using Service;
using Model;

namespace Controller
{
   public class PatientController
   {
      public Boolean CreatePatient(Patient patient)
      {
         // TODO: implement
         return patientService.CreatePatient(patient);
      }
      
      public Boolean UpdatePatient(Patient patient)
      {
         // TODO: implement
         return patientService.UpdatePatient(patient);
      }
      
      public Boolean DeletePatient(int id)
      {
         // TODO: implement
         return patientService.DeletePatient(id);
      }
      
      public Boolean ReadPatient()
      {
         // TODO: implement
         return false;
      }
   
      public PatientService patientService = new PatientService();
   
   }
}