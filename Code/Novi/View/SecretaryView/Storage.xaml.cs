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
    /// Interaction logic for Storage.xaml
    /// </summary>
    public partial class Storage : Window
    {
        public ObservableCollection<DynamicEquipment> dynamicEquipments;
        public DynamicEquipmentController dynamicEquipmentController = new DynamicEquipmentController();
        public Storage()
        {
            InitializeComponent();
            dynamicEquipments = new ObservableCollection<DynamicEquipment>(dynamicEquipmentController.ReadAllInStorage());
            dgDataBinding.ItemsSource = dynamicEquipments;
        }
    }
}
