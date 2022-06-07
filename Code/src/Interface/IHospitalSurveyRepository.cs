using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Interface
{
    public interface IHospitalSurveyRepository
    {
        List<HospitalSurvey> FindAll();
        HospitalSurvey FindByID(int id);
        Boolean Save(HospitalSurvey hospitalSurvey);
        Boolean DeleteByID(int id);
        Boolean UpdateByID(HospitalSurvey hospitalSurvey);
    }
}
