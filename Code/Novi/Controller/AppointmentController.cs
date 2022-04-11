/***********************************************************************
 * Module:  AppointmentController.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Controller.AppointmentController
 ***********************************************************************/

using System;
using Service;
using Model;

namespace Controller
{
   public class AppointmentController
   {
      public Boolean CreateApp(Appointment appointment)
      {
         // TODO: implement
         return appointmentService.CreateApp(appointment);
      }
      
      public Boolean DeleteApp(int id)
      {
         // TODO: implement
         return appointmentService.DeleteApp(id);
      }
      
      public Boolean UpdateApp(Appointment appointment)
      {
         // TODO: implement
         return appointmentService.UpdateApp(appointment);
      }
      
      public Boolean ReadApp()
      {
         // TODO: implement
         return false;
      }
   
      public AppointmentService appointmentService = new AppointmentService();
   
   }
}