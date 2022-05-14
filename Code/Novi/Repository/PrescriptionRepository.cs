using System;
using System.Collections.Generic;
using Model;
using Serialization;
using System.Windows;

namespace Repository
{
    public class PrescriptionRepository
    {

        public Boolean Save(Prescription newPrescription)
        {
            List<Prescription> all = serializer.fromJSON(FileName);
            all.Add(newPrescription);
            serializer.toJSON(FileName, all);
            return true;
        }

 /*       public List<Prescription> FindAllByPatientId(int id)
        {
            List<Prescription> all = serializer.fromJSON(FileName);
            List<Prescription> ret = new List<Prescription>();
            foreach (Prescription i in all)
            {
                if (i.patient == null)
                {
                    continue;
                }
                if (i.patient.Id == id)
                {
                    ret.Add(i);
                }
            }
            foreach(Prescription i in ret)
            {
                DateTime now = DateTime.Now;
                TimeSpan value = i.datetime.Subtract(now);
                if(value.TotalMinutes < 15 && value.TotalMinutes > 0)
                {
                    MessageBox.Show("Za manje od 15 minuta treba da popijete lek " + i.drug.Name, "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            return ret;
        }*/

        

        private static String FileName = @"..\..\..\data\Prescriptions.json";

        private static Serializer<Prescription> serializer = new Serializer<Prescription>();
    }
}
