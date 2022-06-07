using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using Appointments.Model;
using Appointments.Controller;


namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Page
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public ObservableCollection<Appointments.Model.Prescription> prescriptions;
        private int id;
        public Prescription(int id)
        {
            InitializeComponent();
            prescriptions = new ObservableCollection<Appointments.Model.Prescription>(prescriptionController.PrescriptionListOfPatient(id));
            PatientAppointments.ItemsSource = prescriptions;
            this.id = id;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
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
            var s = new Help(id);
            NavigationService.Navigate(s);
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = DatePicker1.SelectedDate.GetValueOrDefault();
            prescriptionController.GeneratePDF(id, dateTime);
        }
    }

}
