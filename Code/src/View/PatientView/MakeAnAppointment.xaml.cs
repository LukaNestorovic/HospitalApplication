﻿using Controller;
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
using DTO;
using Appointments.Model;
using Appointments.Controller;
using Appointments.DTO;

namespace ProjekatSIMS.View.PatientView
{
    /// <summary>
    /// Interaction logic for MakeAnAppointment.xaml
    /// </summary>
    public partial class MakeAnAppointment : Window
    {
        public AppointmentController appointmentController = new AppointmentController();
        public ObservableCollection<Appointment> appointments;
        private int id;
        public AppointmentDTO appointmentDTO = new AppointmentDTO();
        public PatientController patientController = new PatientController();
        public DoctorController doctorController = new DoctorController();
        public RoomController roomController = new RoomController();
        public MakeAnAppointment()
        {
            InitializeComponent();
        }
      
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            appointmentDTO.DateTime = DatePicker.SelectedDate.GetValueOrDefault();
            appointmentDTO.Descripton = TBDescription.Text;
            appointmentDTO.Duration = Int32.Parse(TBDuration.Text);
            appointmentDTO.Emergency = (Boolean)CBEmergency.IsChecked;
            appointmentDTO.Patient = patientController.FindPatientById(Int32.Parse(TBPatient.Text));
            appointmentDTO.Doctor = doctorController.ReadDoctor(Int32.Parse(TBDoctor.Text));
            appointmentDTO.Room = roomController.ReadRoom(Int32.Parse(TBRoom.Text));
            appointmentDTO.Finished = false;

            appointmentController.CreateAppointment(appointmentDTO);

        }
    }
}
