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
        public Edit(ObservableCollection<Appointment> appointments)
        {
            InitializeComponent();
            this.appointments = appointments;
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            appointmentController.UpdateApp(DatePicker.SelectedDate.GetValueOrDefault(), TBDescription.Text, Int32.Parse(TBDuration.Text), (Boolean)CBEmergency.IsChecked, Int32.Parse(TBPatient.Text), Int32.Parse(TBDoctor.Text), Int32.Parse(TBRoom.Text), Int32.Parse(TBId.Text));
            var s = new PatientView();
            s.Show();
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            var s = new PatientView();
            s.Show();
            Close();


        }
    }
}
