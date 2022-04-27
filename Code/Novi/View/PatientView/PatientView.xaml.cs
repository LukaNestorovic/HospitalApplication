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
        public ObservableCollection<Appointment> appointments;

        public PatientView(int id)
        {
            InitializeComponent();
            appointments = new ObservableCollection<Appointment>(appointmentController.ReadAll());
            PatientAppointments.ItemsSource = appointments;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new Delete();
            s.Show();
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var s = new MakeAnAppointment(appointments);
            s.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var s = new Edit(appointments);
            s.Show();
            Close();
        }
    }
}
