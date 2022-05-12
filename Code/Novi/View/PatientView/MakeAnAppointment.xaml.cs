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
    /// Interaction logic for MakeAnAppointment.xaml
    /// </summary>
    public partial class MakeAnAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public ObservableCollection<Appointment> appointments;
        private int id;
        public MakeAnAppointment()
        {
            InitializeComponent();
        }
      
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView(id);
            s.Show();
            Close();


        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            appointmentController.CreateApp(DatePicker.SelectedDate.GetValueOrDefault(), TBDescription.Text, Int32.Parse(TBDuration.Text), (Boolean)CBEmergency.IsChecked, Int32.Parse(TBPatient.Text), Int32.Parse(TBDoctor.Text), Int32.Parse(TBRoom.Text));
            var s = new PatientView(id);
            s.Show();
            Close();
        }
    }
}
