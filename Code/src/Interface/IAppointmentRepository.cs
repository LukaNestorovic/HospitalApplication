using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Model;

namespace Interface
{
    public interface IAppointmentRepository
    {
        List<Appointment> FindAll();
        Appointment FindByID(int id);
        Boolean Save(Appointment appointment);
        Boolean DeleteByID(int id);
        Boolean UpdateByID(Appointment appointment);
    }
}
