using System;
using System.Collections.Generic;
using Appointments.Model;
using Serialization;
using System.Windows;
using Interface;

namespace Appointments.Repository
{
    public class PrescriptionRepository : IPrescriptionRepository
    {

        public Boolean Save(Prescription newPrescription)
        {
            List<Prescription> all = serializer.fromJSON(FileName);
            all.Add(newPrescription);
            serializer.toJSON(FileName, all);
            return true;
        }

        public List<Prescription> FindAll()
        {
            return serializer.fromJSON(FileName);
        }

        private static String FileName = @"..\..\..\data\Prescriptions.json";

        private static Serializer<Prescription> serializer = new Serializer<Prescription>();
    }
}
