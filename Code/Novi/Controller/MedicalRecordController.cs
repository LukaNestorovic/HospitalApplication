using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;

namespace Controller
{
    public class MedicalRecordController
    {
        public MedicalRecordService medicalRecordService = new MedicalRecordService();
        public PatientService patientService = new PatientService();

        public Boolean updateAllergies (int patientId, String allergies)
        {
           // Patient patient = patientService.ReadPatient (patientId);
            return medicalRecordService.UpdateAllergies (patientId, allergies);
        }
         public Boolean createMR (String allergies, int patientId)
        {
            Patient patient = patientService.ReadPatient(patientId);
            return medicalRecordService.CreateMR (allergies, patient);
        }
    }
}
