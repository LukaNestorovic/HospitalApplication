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
    /// Interaction logic for EditSurgeryData.xaml
    /// </summary>
    public partial class EditSurgeryData : Window
    {
        public OperationController operationController = new OperationController();
        public ObservableCollection<Operation> operations;
        public EditSurgeryData(ObservableCollection<Operation> operation)
        {
            InitializeComponent();
            this.operations = operation;
        }

        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            
            var s = new ShowSurgery();
            s.Show();
            Close();
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            operationController.UpdateOperation(DPTime.SelectedDate.GetValueOrDefault(), Int32.Parse(Duration.Text), Type.Text, Int32.Parse(Patient.Text), Int32.Parse(Doctor.Text), Int32.Parse(Room.Text), Int32.Parse(Id.Text));
            var s = new ShowSurgery();
            s.Show();
            Close();
        }

        private void Type_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Room_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Doctor_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Patient_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
