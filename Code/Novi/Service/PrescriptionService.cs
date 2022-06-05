using System;
using Model;
using System.IO;
using System.Collections.Generic;
using Repository;
using System.Collections;
using Serialization;
using System.Windows;
using DTO;


namespace Service
{
    public class PrescriptionService
    {
		public int createId()
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			File.Create(idFile).Close();
			File.WriteAllText(idFile, newID.ToString());
			id = newID;
			return newID;
		}
		public Boolean CreatePrescription(PrescriptionDTO prescriptionDTO)
		{
			int newID = createId();
			Prescription newPrescription = new Prescription(prescriptionDTO.Instructions, newID, prescriptionDTO.doctor, prescriptionDTO.patient, prescriptionDTO.drug, prescriptionDTO.datetime);
			File.WriteAllText(idFile, newID.ToString());
			return prescriptionRepository.Save(newPrescription);
		}

        public List<Prescription> FindAllByPatientId(List<Prescription> all, int id)
        {
            List<Prescription> ret = new List<Prescription>();
            foreach (Prescription prescription in all)
            {
                if(prescription.patient == null)
                {
                    continue;
                }
                if(prescription.patient.Id == id)
                {
                    ret.Add(prescription);
                }
            }
            return ret;
        }

		public List<Prescription> PrescriptionListOfPatient(int id)
		{
            List<Prescription> all = prescriptionRepository.FindAll();
            List<Prescription> ret = FindAllByPatientId(all, id);
            foreach (Prescription i in ret)
            {
                DateTime now = DateTime.Now;
                TimeSpan value = i.datetime.Subtract(now);
                if (value.TotalMinutes < 15 && value.TotalMinutes > 0)
                {
                    MessageBox.Show("Za manje od 15 minuta treba da popijete lek " + i.drug.Name, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            return ret;
        }


		public String idFile = @"..\..\..\Data\prescriptionID.txt";
		public PrescriptionRepository prescriptionRepository = new PrescriptionRepository();
        public int id = 0;
    }
}
