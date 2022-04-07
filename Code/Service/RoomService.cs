/***********************************************************************
 * Module:  RoomService.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;

namespace Service
{
   public class RoomService
   {
      public Boolean CreateRoom(String roomType, String name, Inventory inventory, int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdateRoom(Room room)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteRoom(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Room ReadRoom(int id)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.RoomRepository roomRepository;
   
   }
}