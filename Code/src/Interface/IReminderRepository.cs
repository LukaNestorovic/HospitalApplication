using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Interface
{
    public interface IReminderRepository
    {
        List<Reminder> FindAll();
        Reminder FindByID(int id);
        Boolean Save(Reminder reminder);
        Boolean DeleteByID(int id);
        Boolean UpdateByID(Reminder reminder);
    }
}
