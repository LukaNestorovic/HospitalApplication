using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Model;

namespace Interface
{
    public interface IPatientRepository
    {
        List<Patient> FindAll();
        Patient FindByID(int id);
        Boolean Save(Patient patient);
        Boolean DeleteByID(int id);
        Boolean UpdateByID(Patient patient);
    }
}
