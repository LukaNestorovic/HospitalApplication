using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientDTO
    {
        public String InsuranceCarrier { get; set; }
        public Boolean Guest { get; set; }
        public Boolean Blocked { get; set; }
        public int Brojac { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Jmbg { get; set; }
        public String Telephone { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }
        public String Adress { get; set; }
        public String Password { get; set; }

        public PatientDTO(string insuranceCarrier, bool guest, bool blocked, int brojac, string name, string surname, string jmbg, string telephone, string email, DateTime birthDate, string adress, string password)
        {
            InsuranceCarrier = insuranceCarrier;
            Guest = guest;
            Blocked = blocked;
            Brojac = brojac;
            Name = name;
            Surname = surname;
            Jmbg = jmbg;
            Telephone = telephone;
            Email = email;
            BirthDate = birthDate;
            Adress = adress;
            Password = password;
        }

        public PatientDTO()
        {
        }
    }
}
