/***********************************************************************
 * Module:  RoomController.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Controller.RoomController
 ***********************************************************************/

using System;
using Service;
using Model;

namespace Controller
{
   public class RoomController
   {
      public Boolean CreateRoom(Room room)
      {
         // TODO: implement
         return roomService.CreateRoom(room);
      }
      
      public Boolean DeleteRoom(int id)
      {
         // TODO: implement
         return roomService.DeleteRoom(id);
      }
      
      public Boolean ReadRoom()
      {
         // TODO: implement
         return false;
      }
      
      public Boolean UpdateRoom(Room room)
      {
         // TODO: implement
         return roomService.UpdateRoom(room);
      }
   
      public RoomService roomService = new RoomService();
   
   }
}