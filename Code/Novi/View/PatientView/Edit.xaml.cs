using Controller;
using Model;
using Repository;
using Service;
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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public DoctorController doctorController = new DoctorController();
        public ObservableCollection<Appointment> appointments;
        private int id;
        public Appointment appointment = new Appointment();
        public List<Model.Doctor> doctors = new List<Model.Doctor>();
        public Model.Doctor doctor = new Model.Doctor();
        private int brojac;
        public Edit(Appointment appointment, int id, int brojac)
        {
            InitializeComponent();
            DP.SelectedDate = appointment.DateTime;
            TBDescription.Text = appointment.Descripton;
            Combo.SelectedItem = appointment.Doctor;
            doctors = doctorController.ReadAll();
            Combo.ItemsSource = doctors;
            this.appointment = appointment;
            this.id = id;
            this.brojac = brojac;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime today2 = today.AddDays(2);
           
            if (today2 <= appointment.DateTime)
            {
                doctor = (Model.Doctor)Combo.SelectedItem;
                if(doctor == null)
                {
                    MessageBox.Show("Izaberite doktora", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                appointmentController.UpdateApp(DP.SelectedDate.GetValueOrDefault(), TBDescription.Text, appointment.Duration, appointment.Emergency, appointment.Patient.Id, doctor.Id, appointment.Room.Id, appointment.Id, false);
                var s = new PatientView(id, brojac);
                s.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Manje od dva dana do termina", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id, brojac);
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
