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

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for ScheduleSurgery.xaml
    /// </summary>
    public partial class ScheduleSurgery : Window
    {

//        public ObservableCollection<SurgeryAppointment> surgeryAppointments;
//        public SurgeryRepository surgeryRepository = new SurgeryRepository();
//        public SurgeryController surgeryController = new SurgeryController();
//        public SurgeryService surgeryService = new SurgeryService();
/*       public ScheduleSurgery(ObservableCollection<SurgeryAppointment> surgeryAppointment)
        {
            InitializeComponent();
            this.surgeryAppointments = surgeryAppointment;
            InitializaCombo();
        }

        private void InitializaCombo()
        {
            CBDoctor.ItemsSource = surgeryRepository.GetAllSurgeries();
            
        }
*/
        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowSurgery();
            s.Show();
            Close();
        }

 /*       private SurgeryAppointment GetFromDG()
        {
            SurgeryAppointment surgeryAppointment = new SurgeryAppointment(TBId.Text, TBType.Text, DPTime.SelectedDate.GetValueOrDefault(), TBPatient.Text, (String)CBDoctor.SelectedItem, (String)CBRoom.SelectedItem);
            return surgeryAppointment;
        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            SurgeryAppointment surgeryAppointment = GetFromDG();

            surgeryService.ScheduleSurgery(surgeryAppointment);
            this.surgeryAppointments.Add(surgeryAppointment);

            var s = new ShowSurgery();
            s.Show();
            Close();
        }
 */


        private void Doctor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Patient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Room_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Type_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Id_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Time_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
