using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appointments.Controller;
using Appointments.Model;
using System.Windows.Navigation;
using System.Windows;

namespace ProjekatSIMS.View.PatientView.ViewModel
{
    public class MedicalRecordVM: ViewModelBase
    {
        public RelayCommand NavigateHome { get; set; }
        public RelayCommand NavigateLogOff { get; set; }
        public RelayCommand NavigateFinishedExamination { get; set; }
        public NavigationService navigationService { get; set; }
        public int id;
        public Patient patient { get; set; }
        public PatientController patientController = new PatientController();
        public MedicalRecord medicalRecord = new MedicalRecord();

        public MedicalRecordVM(NavigationService navigationService, int id) : base()
        {
            this.navigationService = navigationService;
            this.NavigateHome = new RelayCommand(ExecuteHome);
            this.NavigateLogOff = new RelayCommand(ExecuteLogOff);
            this.NavigateFinishedExamination = new RelayCommand(ExecuteFinishedExamination);
            this.id = id;
            patient = new Patient();
            patient = patientController.FindPatientById(id);
            /*            medicalRecord.TBAdress.Text = patient.Adress;
                        medicalRecord.TBBirth.Text = patient.BirthDate.ToString();
                        medicalRecord.TBEmail.Text = patient.Email;
                        medicalRecord.TBName.Text = patient.Name;
                        medicalRecord.TBSurname.Text = patient.Surname;
                        medicalRecord.TBTelephone.Text = patient.Telephone;
                        medicalRecord.TBJmbg.Text = patient.Jmbg;*/
        }

        private void ExecuteHome(object? obj)
        {
            this.navigationService.Navigate(new Home(id));
        }

        private void ExecuteLogOff(object? obj)
        {
            this.navigationService.Navigate(new LogIn());
        }

        private void ExecuteFinishedExamination(object? obj)
        {
            this.navigationService.Navigate(new FinishedExaminations(id));
        }

    }
}
