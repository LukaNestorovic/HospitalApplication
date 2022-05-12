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
    /// Interaction logic for PatientView.xaml
    /// </summary>
    public partial class PatientView : Window
    {
        
        public AppointmentController appointmentController = new AppointmentController();
        public Appointment appointment = new Appointment();
        public ObservableCollection<Appointment> appointments;
        private int id;

        public PatientView(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadAllByPatientId(id));
            PatientAppointments.ItemsSource = appointments;
            this.id = id;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            appointment = (Appointment)PatientAppointments.SelectedItem;
            appointmentController.DeleteApp(appointment.Id);
            var s = new PatientView(id);
            s.Show();
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new MakeAnAppointment();
            s.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Appointment appointment1 = new Appointment();
            appointment = (Appointment)PatientAppointments.SelectedItem;
            appointment1 = appointmentController.ReadApp(appointment.Id);
            var s = new Edit(appointment1, id);
            s.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            Close();
        }

        private void Free_Click(object sender, RoutedEventArgs e)
        {
            var s = new FreeAppointments(id);
            s.Show();
            Close();
        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogIn();
            s.Show();
            Close();
        }
    }
}
