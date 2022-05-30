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
    /// Interaction logic for Medicine.xaml
    /// </summary>
    public partial class Medicine : Window
    {
        public PrescriptionController prescriptionController = new PrescriptionController();
        public ObservableCollection<Prescription> prescriptions;
        private int id;
        public Medicine(int id)
        {
            InitializeComponent();
            prescriptions = new ObservableCollection<Prescription>(prescriptionController.ReadAllByPatientId(id));
            PatientAppointments.ItemsSource = prescriptions;
            this.id = id;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            Close();
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
