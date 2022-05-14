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
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientHome(id);
            s.Show();
            Close();
        }
    }
}
