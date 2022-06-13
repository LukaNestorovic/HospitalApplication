using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Appointments.Controller;
using Controller;
using Appointments.Model;
using DTO;

namespace ProjekatSIMS.View.PatientView.ViewModel
{
    public class RateDoctorVM: ViewModelBase
    {
        public RelayCommand NavigateFinishedExamination { get; set; }
        public RelayCommand NavigateLogOff { get; set; }
        public NavigationService navigationService { get; set; }
        private int id;
        public DoctorSurveyController doctorSurveyController = new DoctorSurveyController();
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public Appointment appointment = new Appointment();
        public Appointments.Model.Doctor doctor = new Appointments.Model.Doctor();
        public DoctorSurveyDTO doctorSurveyDTO = new DoctorSurveyDTO();
        public RateAppointment rateAppointment = new RateAppointment();

        public RateDoctorVM(NavigationService navigationService, int id, Appointment appointment): base()
        {
            this.navigationService = navigationService;
            this.NavigateFinishedExamination = new RelayCommand(ExecuteFinishedExamination);
            this.NavigateLogOff = new RelayCommand(ExecuteLogOff);
            this.id = id;
            this.appointment = appointment;
            doctorSurveyDTO.Question1 = rateAppointment.Combo1.SelectedIndex + 1;
            doctorSurveyDTO.Question2 = rateAppointment.Combo2.SelectedIndex + 1;
            doctorSurveyDTO.Question3 = rateAppointment.Combo3.SelectedIndex + 1;
            doctorSurveyDTO.patient = appointment.Patient;
            doctorSurveyDTO.doctor = appointment.Doctor;
            doctorSurveyController.CreateDoctorSurvey(doctorSurveyDTO);
        }

        private void ExecuteFinishedExamination(object? obj)
        {
            this.navigationService.Navigate(new FinishedExaminations(id));
        }

        private void ExecuteLogOff(object? obj)
        {
            this.navigationService.Navigate(new LogIn());
        }
    }
}
