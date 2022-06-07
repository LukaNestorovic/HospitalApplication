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

        public ObservableCollection<Operation> operations;
        public OperationController operationController = new OperationController();
        private int id;
        public ScheduleSurgery(ObservableCollection<Operation> operation, int id)
        {
            InitializeComponent();
            this.operations = operation;
            this.id = id;
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowSurgery(id);
            s.Show();
            Close();
        }


        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            operationController.CreateOperation(DPTime.SelectedDate.GetValueOrDefault(), Int32.Parse(TBDuration.Text), TBType.Text, Int32.Parse(TBPatient.Text), Int32.Parse(TBDoctor.Text), Int32.Parse(TBRoom.Text));

            var s = new ShowSurgery(id);
            s.Show();
            Close();
        }



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
