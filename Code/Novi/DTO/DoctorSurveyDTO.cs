﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Appointments.Model;

namespace DTO
{
    public class DoctorSurveyDTO
    {
        public int Question1 { get; set; }
        public int Question2 { get; set; }
        public int Question3 { get; set; }
        public Doctor doctor { get; set; }
        public Patient patient { get; set; }

        public DoctorSurveyDTO(int question1, int question2, int question3, Doctor doctor, Patient patient)
        {
            Question1 = question1;
            Question2 = question2;
            Question3 = question3;
            this.doctor = doctor;
            this.patient = patient;
        }

        public DoctorSurveyDTO()
        {
        }
    }
}
