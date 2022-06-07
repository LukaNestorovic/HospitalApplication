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
using System.Windows.Shapes;
using Controller;
using Model;
using ProjekatSIMS.View.PatientView;
using ProjekatSIMS.View.DoctorView;
using ProjekatSIMS.View.ManagerView;
using ProjekatSIMS.View.SecretaryView;
using System.Collections.ObjectModel;
using Appointments.Controller;
using Appointments.Model;

namespace ProjekatSIMS
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public PatientController patientController = new PatientController();
        public Patient patient = new Patient();
        public DoctorController doctorController = new DoctorController();
        public Appointments.Model.Doctor doctor = new Appointments.Model.Doctor();
        public DeanController deanController = new DeanController();
        public Dean dean = new Dean();
        public SecretaryController secretaryController = new SecretaryController();
        public Secretary secretary = new Secretary();
        public ObservableCollection<Room> rooms;
        public ReminderController reminderController = new ReminderController();
        public LogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            patient = patientController.ReadPatientByEmail(TBEmail.Text);
            secretary = secretaryController.ReadSecretaryByEmail(TBEmail.Text);
            if(patient != null)
            {
                if(patient.Password == TBPass.Password)
                {
                    if (patient.Blocked == true)
                    {
                        MessageBox.Show("Blokirani ste", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                        var t = new LogIn();
                        t.Show();
                        Close();
                    }
                    else
                    {
                        var s = new Home(patient.Id);
                        MainFrame.Navigate(s);
                        reminderController.Notification();
                    }
                }
                else
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else if(secretary != null)
            {
                if(secretary.Password == TBPass.Password)
                {
                    var s = new ShowPatient();
                    s.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }      
            else
            {
                MessageBox.Show("Pogresan mail ili sifra", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Appointment_Click(object sender, RoutedEventArgs e)
        {
            var s = new MakeAnAppointment();
            s.Show();
            Close();
        }

        private void Doctor_Click(object sender, RoutedEventArgs e)
        {
            var s = new View.PatientView.Doctor();
            s.Show();
            Close();
        }

        private void Room_Click(object sender, RoutedEventArgs e)
        {
            var s = new AddRoomView(rooms);
            s.Show();
            Close();
        }

        private void Drug_Click(object sender, RoutedEventArgs e)
        {
            var s = new View.DoctorView.Drug();
            s.Show();
            Close();
        }

        private void Prescription_Click(object sender, RoutedEventArgs e)
        {
            var s = new View.DoctorView.Prescription();
            s.Show();
            Close();
        }
    }
}
