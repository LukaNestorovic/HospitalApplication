/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Repository.AppointmentRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
   public class AppointmentRepository
   {
      public List<Appointment> FindAll()
      {
         // TODO: implement
         return null;
      }
      
      public Appointment FindByID(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean Save(Appointment appointment)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteByID(int id)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean UpdateByID(Appointment appointment)
      {
         // TODO: implement
         return false;
      }
   
      private String FileName;

   
   }
}