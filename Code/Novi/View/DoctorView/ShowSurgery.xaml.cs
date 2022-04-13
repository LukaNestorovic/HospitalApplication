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
using Controller;
using Model;
using Service;

namespace ProjekatSIMS.View.DoctorView
{
    /// <summary>
    /// Interaction logic for ShowSurgery.xaml
    /// </summary>
    public partial class ShowSurgery : Window
    {
        public ObservableCollection<Operation> operations;
        public OperationController operationController = new OperationController();

        public ShowSurgery()
        {
            InitializeComponent();
            operations = new ObservableCollection<Operation>(operationController.ReadAll());
            dgSurgery.ItemsSource = operations;
        }

        private void ScheduleSurgery_Click(object sender, RoutedEventArgs e)
        {
            var s = new ScheduleSurgery(operations);
            s.Show();
            Close();
        }

        private void EditSugery_Click(object sender, RoutedEventArgs e)
        {
            var s = new EditSurgeryData(operations);
            s.Show();
            Close();
        }

        private void CancelSurgery_Click(object sender, RoutedEventArgs e)
        {
            var s = new Delete(operations);
            s.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var s = new DoctorView();
            s.Show();
            Close();
        }
    }
}
