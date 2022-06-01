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

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Page
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public ObservableCollection<Model.Prescription> prescriptions;
        private int id;
        public Prescription(int id)
        {
            InitializeComponent();
            prescriptions = new ObservableCollection<Model.Prescription>(prescriptionController.ReadAllByPatientId(id));
            PatientAppointments.ItemsSource = prescriptions;
            this.id = id;
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
        }
    }

}
