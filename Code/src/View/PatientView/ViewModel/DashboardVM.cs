using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ProjekatSIMS.View.PatientView.ViewModel
{
    public class DashboardVM : ViewModelBase
    {
        NavigationService navigationService { get; set; }
        public RelayCommand NavigateHome { get; set; }
        public RelayCommand NavigateLogOff { get; set; }
        public RelayCommand NavigateFinishedExamination { get; set; }
        public DashboardVM(NavigationService navigationService) : base()
        {
            this.NavigateHome = new RelayCommand(ExecuteHome);
            this.NavigateLogOff = new RelayCommand(ExecuteLogOff);
            this.NavigateFinishedExamination = new RelayCommand(ExecuteNavigateFinishedExamination);
            this.navigationService = navigationService;
        }

        private void ExecuteHome(object? obj)
        {
            navigationService.Navigate(new Home(1));
        }

        private void ExecuteLogOff(object? obj)
        {
            navigationService.Navigate(new LogIn());
        }

        private void ExecuteNavigateFinishedExamination(object? obj)
        {
            navigationService.Navigate(new FinishedExaminations(1));
        }
    }
}


