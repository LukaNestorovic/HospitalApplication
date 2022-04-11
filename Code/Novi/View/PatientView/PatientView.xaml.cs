using Controller;
using Model;
using Repository;
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
/*        public ObservableCollection<ExaminationAppointment> pregledi;
        public ExaminationAppointmentRepository examinationrepo = new ExaminationAppointmentRepository();

       public ExaminationAppointmentController examinationcontroller = new ExaminationAppointmentController();


        public PatientView()
        {
            InitializeComponent();
            
            pregledi = new ObservableCollection<ExaminationAppointment>(examinationrepo.ListAppointments());
            PatientAppointments.ItemsSource = pregledi;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((ExaminationAppointment)PatientAppointments.SelectedItem == null)
            {
                MessageBox.Show("There is no selected appointment");

            }

            else
            {
                ExaminationAppointment objekat = ((ExaminationAppointment)PatientAppointments.SelectedItem);
                examinationcontroller.DeleteAppointment(objekat.Id);
                pregledi.Remove(objekat);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var d = new MakeAnAppointment(pregledi);
            d.Show();
        }*/
    }
}
