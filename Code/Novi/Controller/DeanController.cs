using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;

namespace Controller
{
    public class DeanController
    {
        public Dean ReadDeanByEmail(String email)
        {
            return deanService.ReadDeanByEmail(email);
        }
        public Dean ReadDeanByPassword(String password)
        {
            return deanService.ReadDeanByPassword(password);
        }
        public DeanService deanService = new DeanService();
    }
}
