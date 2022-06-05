
using System;
using Service;
using Model;
using System.Collections.Generic;
using DTO;

namespace Controller
{
    public class PrescriptionController
    {
        public PatientService patientService = new PatientService();
        public PrescriptionService prescriptionService = new PrescriptionService();
        public DoctorService doctorService = new DoctorService();
        public DrugService drugService = new DrugService();
        public Boolean CreatePrescription(PrescriptionDTO prescriptionDTO)
        {
            return prescriptionService.CreatePrescription(prescriptionDTO);
        }

        public List<Prescription> PrescriptionListOfPatient(int id)
        {
            List<Prescription> prescriptions = prescriptionService.PrescriptionListOfPatient(id);
            return prescriptions;
        }
    }
}
