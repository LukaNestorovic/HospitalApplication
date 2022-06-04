using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reminder
    {
        public DateTime DateTime { get; set; }
        public String Event { get; set; }
        public int Id { get; set; }
        public Patient Patient { get; set; }

        public Reminder(DateTime dateTime, string dogadjaj, int id, Patient patient)
        {
            this.DateTime = dateTime;
            this.Event = dogadjaj;
            this.Id = id;
            this.Patient = patient;
        }

        public Reminder()
        {
        }
    }
}
