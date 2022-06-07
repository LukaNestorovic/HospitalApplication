using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Appointments.Model;

namespace DTO
{
    public class ReminderDTO
    {
        public DateTime DateTime { get; set; }
        public String Event { get; set; }
        public Patient Patient { get; set; }

        public ReminderDTO(DateTime dateTime, string dogadjaj, Patient patient)
        {
            this.DateTime = dateTime;
            this.Event = dogadjaj;
            this.Patient = patient;
        }

        public ReminderDTO()
        {
        }
    }
}
