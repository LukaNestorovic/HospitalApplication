/***********************************************************************
 * Module:  AppointmentService.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Service.AppointmentService
 ***********************************************************************/

using System;

namespace Service
{
   public class AppointmentService
   {
      public Boolean CreateApp(DateTime dateTime, String description, int duration, Boolean emergency)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdateApp(DateTime dateTime, String description, int duration, Boolean emergency)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteApp(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Appointment ReadApp(int id)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.AppointmentRepository appointmentRepository;
   
   }
}