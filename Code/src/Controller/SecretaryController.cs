using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;

namespace Controller
{
    public class SecretaryController
    {
        public Secretary ReadSecretaryByEmail (String email)
        {
            return secretaryService.ReadSecretaryByEmail (email);
        }

        public SecretaryService secretaryService = new SecretaryService();
    }
}
