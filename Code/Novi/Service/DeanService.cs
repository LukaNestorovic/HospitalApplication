using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;
using Serialization;


namespace Service
{
    public class DeanService
    {
        public Dean ReadDeanByEmail(String email)
        {
            List<Dean> all = serializer.fromJSON(FileName);
            Dean a = null;
            foreach (Dean i in all)
            {
                if (i.Email == email)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }


        public DeanRepository deanRepository = new DeanRepository();
        private static String FileName = @"..\..\..\data\Dean.json";

        private static Serializer<Dean> serializer = new Serializer<Dean>();
    }
}
