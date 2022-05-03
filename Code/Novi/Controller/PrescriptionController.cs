
using System;
using Service;
using Model;
using System.Collections.Generic;

namespace Controller
{
    public class PrescriptionController
    {
        public PatientService patientService = new PatientService();
        public PrescriptionService prescriptionService = new PrescriptionService();
        public DoctorService doctorService = new DoctorService();
        public DrugService drugService = new DrugService();
        public Boolean CreatePrescription(String instructions, int doctorId, int patientId, int drugId, DateTime datetime)
        {
            Patient patient = patientService.ReadPatient(patientId);
            Doctor doctor = doctorService.ReadDoctor(doctorId);
            Drug drug = drugService.ReadDrug(drugId);
            
        
            return prescriptionService.CreatePrescription(instructions, doctor, patient, drug, datetime);
        }

        public List<Prescription> ReadAllByPatientId(int id)
        {
            List<Prescription> prescriptions = prescriptionService.ReadAllByPatientId(id);
            return prescriptions;
        }
    }
}
