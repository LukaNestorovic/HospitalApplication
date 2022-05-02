
using System;
using Service;
using Model;
using System.Collections;

namespace Controller
{
    public class PrescriptionController
    {
        public PatientService patientService = new PatientService();
        public PrescriptionService prescriptionService = new PrescriptionService();
        public DoctorService doctorService = new DoctorService();
        public Boolean CreatePrescription(String instructions, int doctorId, int patientId, ArrayList drug, DateTime datetime)
        {
            Patient patient = patientService.ReadPatient(patientId);
            Doctor doctor = doctorService.ReadDoctor(doctorId);

        
            return prescriptionService.CreatePrescription(instructions, doctor, patient, drug, datetime);
        }
    }
}
