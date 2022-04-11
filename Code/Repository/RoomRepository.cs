/***********************************************************************
 * Module:  RoomRepository.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Repository.RoomRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
   public class RoomRepository
   {
      public List<Room> FindAll()
      {
         // TODO: implement
         return null;
      }
      
      public Room FindByID(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean Save(Room room)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteByID(int id)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean UpdateByID(Room room)
      {
         // TODO: implement
         return false;
      }
   
      private String FileName;
   
   }
}