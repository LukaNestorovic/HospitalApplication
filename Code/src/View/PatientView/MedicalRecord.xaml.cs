using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Model;
using Controller;
using Appointments.Model;
using Appointments.Controller;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for MedicalRecord.xaml
    /// </summary>
    public partial class MedicalRecord : Page
    {
/*        public int id;
        public Patient patient = new Patient();
        public PatientController patientController = new PatientController();*/
        public MedicalRecord(int id)
        {
            InitializeComponent();
            var sw = Application.Current.Windows
            .Cast<Window>()
            .FirstOrDefault(window => window is LogIn) as LogIn;

            this.DataContext = new ViewModel.MedicalRecordVM(sw.MainFrame.NavigationService, id);
/*            this.id = id;
            patient = patientController.FindPatientById(id);
            TBAdress.Text = patient.Adress;
            TBBirth.Text = patient.BirthDate.ToString();
            TBEmail.Text = patient.Email;
            TBName.Text = patient.Name;
            TBSurname.Text = patient.Surname;
            TBTelephone.Text = patient.Telephone;
            TBJmbg.Text = patient.Jmbg;*/
        }
        public MedicalRecord()
        {
            InitializeComponent();
        }

/*        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new Home(id);
            NavigationService.Navigate(s);
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            String naslov = (String)LNaslov.Content;
            var s = new ProjekatSIMS.Help(naslov);
            s.Show();
        }

        private void Finished_Click(object sender, RoutedEventArgs e)
        {
            var s = new FinishedExaminations(id);
            NavigationService.Navigate(s);
        }*/
    }
}
