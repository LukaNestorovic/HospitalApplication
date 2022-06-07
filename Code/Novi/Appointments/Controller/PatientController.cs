/***********************************************************************
 * Module:  PatientController.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Controller.PatientController
 ***********************************************************************/

using System;
using Appointments.Service;
using Appointments.Model;
using System.Collections.Generic;
using Appointments.DTO;

namespace Appointments.Controller
{
   public class PatientController
   {
      public Boolean CreatePatient(PatientDTO patientDTO)
      {
         return patientService.CreatePatient(patientDTO);
      }
      
      public Boolean UpdatePatient(PatientDTO patientDTO, int id)
      {
         return patientService.UpdatePatient(patientDTO, id);
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
            List<Patient> patients = patientService.ReadAll();          
            return patients;
        }

        public PatientService patientService = new PatientService();
   }
}
