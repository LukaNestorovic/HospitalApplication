using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;

namespace Service
{
    public class SecretaryService
    {
        public Secretary ReadSecretaryByEmail (String email)
        {
            return secretaryRepository.FindByEmail (email);
        }

        public Secretary ReadSecretaryByPassword (String password)
        {
            return secretaryRepository.FindByPassword (password);
        }

        public SecretaryRepository secretaryRepository = new SecretaryRepository();
    }
}
