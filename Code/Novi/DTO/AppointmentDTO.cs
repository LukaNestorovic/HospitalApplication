using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DTO
{
    public class AppointmentDTO
    {
		public DateTime DateTime { get; set; }
		public String Descripton { get; set; }
		public int Duration { get; set; }
		public Boolean Emergency { get; set; }
		public Boolean Finished { get; set; }
		public Patient Patient { get; set; }
		public Doctor Doctor { get; set; }
		public Room Room { get; set; }

        public AppointmentDTO(DateTime dateTime, string descripton, int duration, bool emergency, bool finished, Patient patient, Doctor doctor, Room room)
        {
            DateTime = dateTime;
            Descripton = descripton;
            Duration = duration;
            Emergency = emergency;
            Finished = finished;
            Patient = patient;
            Doctor = doctor;
            Room = room;
        }

        public AppointmentDTO()
        {
        }
    }
}
