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
    /// Interaction logic for AddRoomView.xaml
    /// </summary>
    public partial class AddRoomView : Window
    {
/*        private ObservableCollection<RoomType> roomTypes = new ObservableCollection<RoomType> { RoomType.ExamingRoom, RoomType.SurgeryRoom, RoomType.RestingRoom, RoomType.MeetingRoom, RoomType.Icu, RoomType.Warehouse };
        private Room newRoom = new Room();
        private RoomRepository roomRep = new RoomRepository();
        private RoomController roomController = new RoomController();
        private ObservableCollection<Room> Rooms = new ObservableCollection<Room>();*/
/*        public AddRoomView()
        {
            InitializeComponent();
            cbType.DataContext = Enum.GetValues(typeof(RoomType));
            cbType.ItemsSource = roomTypes;
            this.Rooms = Rooms;
        }
*/
/*        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxId.Text == "" && TextBoxRoomName.Text == "" && TextBoxFloor.Text == "" && cbType.SelectedIndex == -1)
            {
                MessageBox.Show("All text boxes have to be filled in!");
            }
            else
            {
                newRoom.Id = TextBoxId.Text;
                newRoom.RoomName = TextBoxRoomName.Text;
                newRoom.Floor = int.Parse(TextBoxFloor.Text);
                newRoom.Type = (RoomType)cbType.SelectedIndex;
                if(roomController.CreateRoom(newRoom))
                {
                    this.Rooms.Add(newRoom);
                }
                Close();
            }
        }*/
    }
    }
