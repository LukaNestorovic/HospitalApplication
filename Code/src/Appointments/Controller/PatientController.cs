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
      
      public Patient FindPatientById(int id)
      {
            Patient patient = patientService.FindPatientById(id);
            return patient;
      }

        public Patient FindPatientByEmail(String email)
        {
            Patient patient = patientService.FindPatientByEmail(email);
            return patient;
        }

        public List<Patient> FindAll()
        {
            List<Patient> patients = patientService.FindAll();          
            return patients;
        }

        public PatientService patientService = new PatientService();
   }
}
