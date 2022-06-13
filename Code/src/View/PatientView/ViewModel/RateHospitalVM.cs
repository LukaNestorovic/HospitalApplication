using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Appointments.Controller;
using DTO;
using Appointments.Model;
using Controller;

namespace ProjekatSIMS.View.PatientView.ViewModel
{
    public class RateHospitalVM: ViewModelBase
    {
        public RelayCommand NavigateHome { get; set; }
        public RelayCommand NavigateLogOff { get; set; }
        public NavigationService navigationService { get; set; }
        private int id;
        public HospitalSurveyController hospitalSurveyController = new HospitalSurveyController();
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();
        public HospitalSurveyDTO hospitalSurveyDTO = new HospitalSurveyDTO();
        public RateHospital rateHospital = new RateHospital();

        public RateHospitalVM(NavigationService navigationService, int id): base()
        {
            this.navigationService = navigationService;
            this.NavigateHome = new RelayCommand(ExecuteHome);
            this.NavigateLogOff = new RelayCommand(ExecuteLogOff);
            this.id = id;
            hospitalSurveyDTO.Question1 = rateHospital.Combo1.SelectedIndex + 1;
            hospitalSurveyDTO.Question2 = rateHospital.Combo2.SelectedIndex + 1;
            hospitalSurveyDTO.Question3 = rateHospital.Combo3.SelectedIndex + 1;
            hospitalSurveyDTO.patient = patientController.FindPatientById(id);
            hospitalSurveyController.CreateHospitalSurvey(hospitalSurveyDTO);
        }

        private void ExecuteHome(object? obj)
        {
            this.navigationService.Navigate(new Home(id));
        }

        private void ExecuteLogOff(object? obj)
        {
            this.navigationService.Navigate(new LogIn());
        }
    }
}
