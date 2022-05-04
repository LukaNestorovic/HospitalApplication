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
      public String InsuranceCarrier { get; set; }
      public Boolean Guest { get; set; }

        public Patient(string insuranceCarrier, bool guest)
        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
        }
        public Patient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, int id, String password):base(name, surname, jmbg, telephone, email, birthDate, adress, id, password)

        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
        }
        public Patient()
        {
        }
    }
}
