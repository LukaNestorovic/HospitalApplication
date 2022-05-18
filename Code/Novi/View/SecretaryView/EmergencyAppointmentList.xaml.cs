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
using Model;
using Controller;
using System.Collections.ObjectModel;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for EmergencyAppointmentList.xaml
    /// </summary>
    public partial class EmergencyAppointmentList : Window
    {
        private int patientId;
        public ObservableCollection<Doctor> freeDoctors;
        public EmergencyAppointmentList(int patientId, ObservableCollection<Doctor> freeDoctors)
        {
            InitializeComponent();
            this.patientId = patientId;
            this.freeDoctors = freeDoctors;
            EmergencyAppointmentsGrid.ItemsSource = freeDoctors;
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
