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
        public ObservableCollection<Appointment> appointments;
        private int id;
        public Appointment appointment = new Appointment();
        public Edit(Appointment appointment, int id)
        {
            InitializeComponent();
            this.appointment = appointment;
            this.id = id;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime today2 = today.AddDays(2);
           
            if (today2 <= appointment.DateTime)
            {
                appointmentController.UpdateApp(DatePicker.SelectedDate.GetValueOrDefault(), TBDescription.Text, appointment.Duration, appointment.Emergency, appointment.Patient.Id, Int32.Parse(TBDoctor.Text), appointment.Room.Id, appointment.Id);
                var s = new PatientView(id);
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
            var s = new PatientView(id);
            s.Show();
            Close();


        }

        private void LogOff_Click(object sender, RoutedEventArgs e)
        {
            var s = new LogInPatient();
            s.Show();
            Close();
        }
    }
}
