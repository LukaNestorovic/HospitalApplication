using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DTO
{
    public class PrescriptionDTO
    {
		public String Instructions { get; set; }
		public Doctor doctor { get; set; }
		public Patient patient { get; set; }
		public Drug drug { get; set; }
		public DateTime datetime { get; set; }

        public PrescriptionDTO(string instructions, Doctor doctor, Patient patient, Drug drug, DateTime datetime)
        {
            Instructions = instructions;
            this.doctor = doctor;
            this.patient = patient;
            this.drug = drug;
            this.datetime = datetime;
        }

        public PrescriptionDTO()
        {
        }
    }
}
