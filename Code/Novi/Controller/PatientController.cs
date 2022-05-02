/***********************************************************************
 * Module:  PatientController.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Controller.PatientController
 ***********************************************************************/

using System;
using Service;
using Model;
using System.Collections.Generic;

namespace Controller
{
   public class PatientController
   {
      public Boolean CreatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, String password)
      {
         return patientService.CreatePatient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest, password);
      }
      
      public Boolean UpdatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, int id, String password)
      {
         return patientService.UpdatePatient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest, id, password);
      }
      
      public Boolean DeletePatient(int id)
      {
         return patientService.DeletePatient(id);
      }
      
      public Patient ReadPatient(int id)
      {
            Patient patient = patientService.ReadPatient(id);
            return patient;
      }

        public Patient ReadPatientByEmail(String email)
        {
            Patient patient = patientService.ReadPatientByEmail(email);
            return patient;
        }

        public List<Patient> ReadAll()
        {
<<<<<<< HEAD
            List<Patient> patients = patientService.ReadAll();          
=======
            List<Patient> patients = patientService.ReadAll();
>>>>>>> a637d67fecab95d816341cdc97b890490b7f2c24
            return patients;
        }

        public PatientService patientService = new PatientService();
   
   }
}
