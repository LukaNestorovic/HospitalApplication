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

namespace ProjekatSIMS.View.ManagerView
{
    /// <summary>
    /// Interaction logic for ManagerView.xaml
    /// </summary>
    public partial class ManagerView : Window
    {
        public RoomRepository roomRepository = new RoomRepository();
        public RoomController roomController = new RoomController();
        public ObservableCollection<Room> rooms;
        public ManagerView()
        {
            InitializeComponent();
            rooms = new ObservableCollection<Room>(roomRepository.FindAll());
            dataGridRooms.ItemsSource = rooms;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = new AddRoomView(rooms);
            s.Show();
            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
