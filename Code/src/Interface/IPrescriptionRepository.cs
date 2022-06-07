using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Model;

namespace Interface
{
    public interface IPrescriptionRepository
    {
        List<Prescription> FindAll();
        
        Boolean Save(Prescription prescription);
      
    }
}
