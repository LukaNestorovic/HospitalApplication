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
      public Boolean Blocked { get; set; }

        public Patient(string insuranceCarrier, bool guest, Boolean blocked, int brojac)
        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
            Blocked = blocked;
        }
        public Patient(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier, Boolean guest, Boolean blocked, int id, String password):base(name, surname, jmbg, telephone, email, birthDate, adress, id, password)

        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
            Blocked = blocked;
        }
        public Patient()
        {
        }
    }
}
