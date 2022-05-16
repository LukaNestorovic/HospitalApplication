using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service;

namespace Controller
{
    public class DoctorController
    {
        public DoctorService doctorService = new DoctorService();

        public Boolean CreateDoctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String speciality, float grade, int salary, String password)
        {
            return doctorService.CreateDoctor(name, surname, jmbg, telephone, email, birthDate, adress, speciality, grade, salary, password);
        }

        public Boolean UpdateDoctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, String speciality, float grade, int salary, int id,String password)
        {
            return doctorService.UpdateDoctor(name, surname, jmbg, telephone, email, birthDate, adress, speciality, grade, salary, id, password);
        }

        public Boolean DeleteDoctor(int id)
        {
            return doctorService.DeleteDoctor(id);
        }

        public Doctor ReadDoctor(int id)
        {
            Doctor doctor = doctorService.ReadDoctor(id);
            return doctor;
        }

        public Doctor ReadDoctorByEmail(String email)
        {
            Doctor doctor = doctorService.ReadDoctorByEmail(email);
            return doctor;
        }

        public List<Doctor> ReadAll()
        {
            List<Doctor> doctors = doctorService.ReadAll();
            return doctors;
        }

        public List<Doctor> ReadDoctorsBySpeciality(String speciality)
        {
            return doctorService.ReadDoctorsBySpeciality(speciality);
        }
    }
}
