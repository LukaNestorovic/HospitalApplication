﻿using Controller;
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
        public ObservableCollection<Room> rooms;
        
        public RoomController roomController = new RoomController();
        
        public AddRoomView(ObservableCollection<Room> room)
        {
            InitializeComponent();
            this.rooms = room;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            roomController.CreateRoom(TBType.Text, TBName.Text);

            var s = new ManagerView();
            s.Show();
            Close();
        }
    }
    }
