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
using System.Collections.ObjectModel;
using Model;
using Controller;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for CreateAppointment.xaml
    /// </summary>
    public partial class CreateAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public ObservableCollection<Appointment> appointments;
        public CreateAppointment(ObservableCollection<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowAppointments();
            s.Show();
            Close();


        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            appointmentController.CreateAppointment(DatePicker.SelectedDate.GetValueOrDefault(), TBDescription.Text, Int32.Parse(TBDuration.Text), (Boolean)CBEmergency.IsChecked, Int32.Parse(TBPatient.Text), Int32.Parse(TBDoctor.Text), Int32.Parse(TBRoom.Text), false);
            var s = new ShowAppointments();
            s.Show();
            Close();
        }
    }
}
