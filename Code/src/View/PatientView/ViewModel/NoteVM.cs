using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Appointments.Model;

namespace ProjekatSIMS.View.PatientView.ViewModel
{
    public class NoteVM: ViewModelBase
    {
        public RelayCommand NavigateLogOff { get; set; }
        public RelayCommand NavigateFinishedExamination { get; set; }
        public NavigationService navigationService { get; set; }
        public int id;
        
        public Appointment appointment { get; set; }

        public NoteVM(NavigationService navigationService, int id, Appointment app)
        {
            this.navigationService = navigationService;
            this.NavigateLogOff = new RelayCommand(ExecuteLogOff);
            this.NavigateFinishedExamination = new RelayCommand(ExecuteFinishedExamination);
            this.id = id;
            appointment = new Appointment();
            appointment = app;
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
