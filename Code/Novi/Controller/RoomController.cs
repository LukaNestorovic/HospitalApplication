/***********************************************************************
 * Module:	RoomController.cs
 * Author:	SN CAR CODING
 * Purpose: Definition of the Class Controller.RoomController
 ***********************************************************************/

using System;
using Service;
using Model;

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
		
		public String[] ReadRoom(int id)
		{
			Room room = roomService.ReadRoom(id);
			String[] roomDTO = new String[3];
			roomDTO[0] = room.RoomType;
			roomDTO[1] = room.Name;
			roomDTO[2] = room.Id.ToString();
			return roomDTO;
		}
		
		public Boolean UpdateRoom(String RoomType, String RoomName, int id)
		{
			return roomService.UpdateRoom(RoomType, RoomName, id);
		}
	
		public RoomService roomService = new RoomService();
	
	}
}
