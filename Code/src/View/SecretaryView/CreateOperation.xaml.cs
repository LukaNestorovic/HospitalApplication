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
using Controller;
using Model;
using System.Collections.ObjectModel;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for CreateOperation.xaml
    /// </summary>
    public partial class CreateOperation : Window
    {
    
        public ObservableCollection<Operation> operations;
        public OperationController operationController = new OperationController();
      //  private int id;
        public CreateOperation(ObservableCollection<Operation> operation)
        {
            InitializeComponent();
            this.operations = operation;
        }

        private void Odustani_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowOperations();
            s.Show();
            Close();
        }


        private void Potvrdi_Click(object sender, RoutedEventArgs e)
        {
            operationController.CreateOperation(DPTime.SelectedDate.GetValueOrDefault(), Int32.Parse(TBDuration.Text), TBType.Text, Int32.Parse(TBPatient.Text), Int32.Parse(TBDoctor.Text), Int32.Parse(TBRoom.Text));

            var s = new ShowOperations();
            s.Show();
            Close();
        }
    }
}
