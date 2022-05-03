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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Window
    {
        public ObservableCollection<Operation> operations;
        public OperationController operationController = new OperationController();
        private int id;
        public Delete(ObservableCollection<Operation> operation, int id)
        {
            InitializeComponent();
            this.operations = operation;
            this.id = id;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            operationController.DeleteOperation(Int32.Parse(Id.Text));
            var s = new ShowSurgery(id);
            s.Show();
            Close();
        }
    }
}
