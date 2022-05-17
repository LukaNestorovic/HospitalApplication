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
    /// Interaction logic for Finished.xaml
    /// </summary>
    public partial class Finished : Window
    {
        private int id;
        public ObservableCollection<Appointment> appointments;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public Finished(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadIfFinished());
            PatientAppointments.ItemsSource = appointments;
            this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            appointment = (Appointment)PatientAppointments.SelectedItem;
            if (appointment == null)
            {
                MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var s = new DoctorSurvey(id, appointment);
                s.Show();
                Close();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
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

        private void Note_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Prescription_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
