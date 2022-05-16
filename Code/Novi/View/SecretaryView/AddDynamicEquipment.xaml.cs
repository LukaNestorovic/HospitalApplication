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
using DTO;
using Controller;
using System.Collections.ObjectModel;
using Model;

namespace ProjekatSIMS.View.SecretaryView
{
    /// <summary>
    /// Interaction logic for AddDynamicEquipment.xaml
    /// </summary>
    public partial class AddDynamicEquipment : Window
    {
        public DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        public ObservableCollection<DynamicEquipment> dynamicEquipment;
        public AddDynamicEquipment(ObservableCollection<DynamicEquipment> dynamicEquipment)
        {
            InitializeComponent();
            this.dynamicEquipment = dynamicEquipment;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateOfOrder = DateTime.Now;
            DynamicEquipmentDTO dynamicEquipmentDTO = new DynamicEquipmentDTO(TBName.Text, Int32.Parse(TBQuantity.Text), dateOfOrder);
            dynamicEquipmentController.createDynamicEquipment(dynamicEquipmentDTO);
            var s = new Storage();
            s.Show();
            Close();
        }
    }
}
