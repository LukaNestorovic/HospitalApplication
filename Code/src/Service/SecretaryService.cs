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
    public class SecretaryService
    {
        public Secretary ReadSecretaryByEmail (String email)
        {
            List<Secretary> all = serializer.fromJSON(FileName);
            Secretary a = null;
            foreach (Secretary i in all)
            {
                if (i.Email == email)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }

        public SecretaryRepository secretaryRepository = new SecretaryRepository();
        private static String FileName = @"..\..\..\data\Secretary.json";

        private static Serializer<Secretary> serializer = new Serializer<Secretary>();
    }
}
