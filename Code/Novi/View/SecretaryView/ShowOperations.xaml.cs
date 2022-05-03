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
using System.Collections.ObjectModel;
using Controller;
using Model;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for ShowOperations.xaml
    /// </summary>
    public partial class ShowOperations : Window
    {
        public OperationController operationController = new OperationController();
        public ObservableCollection<Operation> operations;
        public ShowOperations()
        {
            InitializeComponent();
            operations = new ObservableCollection<Operation>(operationController.ReadAll());
            OperationsGrid.ItemsSource = operations;
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Operation operation = OperationsGrid.SelectedItem as Operation;
            int operationId = operation.Id;
            String type = operation.Type;
            int duration = operation.Duration;
            DateTime dateTime = operation.DateTime;
            int doctorId = operation.doctor.Id;
            int patientId = operation.patient.Id;
            int roomId = operation.room.Id;
            operationController.UpdateOperation(dateTime, duration, type, patientId, doctorId, roomId, operationId);
            var s = new ShowOperations();
            s.Show();
            Close();
        }

        private void CreateOperation_Click(object sender, RoutedEventArgs e)
        {
            var s = new CreateOperation(operations);
            s.Show();
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Operation operation = OperationsGrid.SelectedItem as Operation;
            int operationId = operation.Id;
            operationController.DeleteOperation(operationId);
            var s = new ShowOperations();
            s.Show();
            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            var s = new ShowPatient();
            s.Show();
            Close();
        }
    }
}
