using System;
using System.Collections.Generic;
using Model;
using Serialization;

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

        

        private static String FileName = @"..\..\..\data\Prescriptions.json";

        private static Serializer<Prescription> serializer = new Serializer<Prescription>();
    }
}
