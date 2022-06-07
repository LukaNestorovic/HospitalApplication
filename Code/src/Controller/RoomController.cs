/***********************************************************************
 * Module:	RoomController.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Controller.RoomController
 ***********************************************************************/

using System;
using Service;
using Model;
using System.Collections.Generic;

namespace Controller
{
	public class RoomController
	{
		public Boolean CreateRoom(String RoomType, String RoomName)
		{
			return roomService.CreateRoom(RoomType, RoomName);
		}
		
		public Boolean DeleteRoom(int id)
		{
			return roomService.DeleteRoom(id);
		}
		
		public Room ReadRoom(int id)
		{
			Room room = roomService.ReadRoom(id);
			return room;
		}
		
		public List<Room> ReadAll(){
			List<Room> rooms = roomService.ReadAll();
			return rooms;
		}
		public Boolean UpdateRoom(String RoomType, String RoomName, int id)
		{
			return roomService.UpdateRoom(RoomType, RoomName, id);
		}
	
		public RoomService roomService = new RoomService();
	
	}
}
