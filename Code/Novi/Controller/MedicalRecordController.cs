using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;
using Appointments.Service;
using Appointments.Model;

namespace Controller
{
    public class MedicalRecordController
    {
        public MedicalRecordService medicalRecordService = new MedicalRecordService();
        public PatientService patientService = new PatientService();

        public Boolean updateAllergies (int patientId, String allergies)
        {
           
            return medicalRecordService.UpdateAllergies (patientId, allergies);
        }

        public Boolean updateAnamnesis(int patientId, String anamnesis)
        {

            return medicalRecordService.UpdateAnamnesis(patientId, anamnesis);
        }

        public Boolean createAnamnesis(String allergies, int patientId, String anamnesis)
        {
            Patient patient = patientService.ReadPatient(patientId);
            return medicalRecordService.CreateAnamnesis(patient, anamnesis, allergies);
        }

        public List<MedicalRecord> readAll()
        {
            return medicalRecordService.ReadAll();
        }
    }
}
