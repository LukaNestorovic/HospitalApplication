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
    /// Interaction logic for FreeAppointments.xaml
    /// </summary>
    public partial class FreeAppointments : Window
    {
        private int id;
        public ObservableCollection<Appointment> appointments;
        public Appointment appointment = new Appointment();
        public AppointmentController appointmentController = new AppointmentController();
        public FreeAppointments(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadAllWithoutPatient());
            PatientAppointments.ItemsSource = appointments;
            this.id = id;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id, 0);
            s.Show();
            Close();
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
                if (appointment.Doctor != null && appointment.Room != null)
                {
                    appointmentController.UpdateAppointment(appointment.DateTime, appointment.Descripton, appointment.Duration, appointment.Emergency, id, appointment.Doctor.Id, appointment.Room.Id, appointment.Id, false);
                }
                else
                {
                    appointmentController.UpdateAppointment(appointment.DateTime, appointment.Descripton, appointment.Duration, appointment.Emergency, id, 1, 1, appointment.Id, false);
                }
                var s = new PatientView(id, 0);
                s.Show();
                Close();
            }
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }
        private void Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
