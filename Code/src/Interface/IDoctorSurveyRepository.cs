using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Interface
{
    public interface IDoctorSurveyRepository
    {
        List<DoctorSurvey> FindAll();
        DoctorSurvey FindByID(int id);
        Boolean Save(DoctorSurvey doctorSurvey);
        Boolean DeleteByID(int id);
        Boolean UpdateByID(DoctorSurvey doctorSurvey);
    }
}
