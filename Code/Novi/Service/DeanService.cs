using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;
using Model;


namespace Service
{
    public class DeanService
    {
        public Dean ReadDeanByEmail(String email)
        {
            return deanRepository.FindByEmail(email);
        }

        public Dean ReadDeanByPassword(String password)
        {
            return deanRepository.FindByPassword(password);
        }

        public DeanRepository deanRepository = new DeanRepository();
    }
}
