using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Model;

namespace Interface
{
    public interface IDoctorRepository
    {
        List<Doctor> FindAll();
        Doctor FindByID(int id);
        Boolean Save(Doctor doctor);
        Boolean DeleteByID(int id);
        Boolean UpdateByID(Doctor doctor);
    }
}
