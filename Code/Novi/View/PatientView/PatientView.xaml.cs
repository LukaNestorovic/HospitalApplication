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
        public PatientController patientController = new PatientController();
        public Appointment appointment = new Appointment();
        public ObservableCollection<Appointment> appointments;
        public Patient patient = new Patient();
        private int brojac;
        private int id;

        public PatientView(int id, int brojac)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadAllByPatientId(id));
            PatientAppointments.ItemsSource = appointments;
            this.brojac = brojac;
            this.id = id;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            brojac++;
            if (brojac == 5)
            {
                patient = patientController.ReadPatient(id);
                patientController.UpdatePatient(patient.Name, patient.Surname, patient.Jmbg, patient.Telephone, patient.Email, patient.BirthDate, patient.Adress, patient.InsuranceCarrier, patient.Guest, true, patient.Id, patient.Password);
                var b = new LogIn();
                b.Show();
                Close();
                MessageBox.Show("Blokirani ste", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                appointment = (Appointment)PatientAppointments.SelectedItem;
                if (appointment == null)
                {
                    MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    appointmentController.DeleteAppointment(appointment.Id);
                    var s = new PatientView(id, brojac);
                    s.Show();
                    Close();
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new MakeAnAppointment();
            s.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            brojac++;
            if (brojac == 5)
            {
                patient = patientController.ReadPatient(id);
                patientController.UpdatePatient(patient.Name, patient.Surname, patient.Jmbg, patient.Telephone, patient.Email, patient.BirthDate, patient.Adress, patient.InsuranceCarrier, patient.Guest, true, patient.Id, patient.Password);
                var b = new LogIn();
                b.Show();
                Close();
                MessageBox.Show("Blokirani ste", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Appointment appointment1 = new Appointment();
                appointment = (Appointment)PatientAppointments.SelectedItem;
                if (appointment == null)
                {
                    MessageBox.Show("Choose appointment", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    appointment1 = appointmentController.ReadAppointment(appointment.Id);
                    var s = new Edit(appointment1, id, brojac);
                    s.Show();
                    Close();
                }
            }
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

        private void Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
