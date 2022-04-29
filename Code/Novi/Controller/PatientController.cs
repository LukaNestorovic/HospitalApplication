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
//            String[] patientDTO = new String[10];
//            patientDTO[0] = patient.Name;
//            patientDTO[1] = patient.Surname;
//            patientDTO[2] = patient.Jmbg;
//            patientDTO[3] = patient.Telephone;
//            patientDTO[4] = patient.Email;
//            patientDTO[5] = patient.BirthDate.ToString();
//            patientDTO[6] = patient.Adress;
//            patientDTO[7] = patient.InsuranceCarrier;
//            patientDTO[8] = patient.Guest.ToString();
//            patientDTO[9] = patient.Id.ToString();
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
//            List<String[]> patientDTOs = new List<String[]>();
//            foreach (Patient patient in patients)
//            {
//                String[] patientDTO = new String[10];
//                patientDTO[0] = patient.Name;
//                patientDTO[1] = patient.Surname;
//                patientDTO[2] = patient.Jmbg;
//                patientDTO[3] = patient.Telephone;
//                patientDTO[4] = patient.Email;
//                patientDTO[5] = patient.BirthDate.ToString();
//                patientDTO[6] = patient.Adress;
//                patientDTO[7] = patient.InsuranceCarrier;
//                patientDTO[8] = patient.Guest.ToString();
//                patientDTO[9] = patient.Id.ToString();
//            }
            return patients;
        }

        public PatientService patientService = new PatientService();
   
   }
}
