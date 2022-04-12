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
      public Boolean CreatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest)
      {
         return patientService.CreatePatient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest);
      }
      
      public Boolean UpdatePatient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, int id)
      {
         return patientService.UpdatePatient(name, surname, jmbg, telephone, email, birthDate, adress, insuranceCarrier, guest, id);
      }
      
      public Boolean DeletePatient(int id)
      {
         return patientService.DeletePatient(id);
      }
      
      public String[] ReadPatient(int id)
      {
            Patient patient = patientService.ReadPatient(id);
            String[] patientDTO = new String[10];
            patientDTO[0] = patient.Name;
            patientDTO[1] = patient.Surname;
            patientDTO[2] = patient.Jmbg;
            patientDTO[3] = patient.Telephone;
            patientDTO[4] = patient.Email;
            patientDTO[5] = patient.BirthDate.ToString();
            patientDTO[6] = patient.Adress;
            patientDTO[7] = patient.InsuranceCarrier;
            patientDTO[8] = patient.Guest.ToString();
            patientDTO[9] = patient.Id.ToString();
            return patientDTO;
      }
   
      public PatientService patientService = new PatientService();
   
   }
}