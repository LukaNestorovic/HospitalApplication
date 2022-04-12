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
		
		public Boolean ReadRoom(int id)
		{
			return roomService.ReadRoom(id);
		}
		
		public Boolean UpdateRoom(String RoomType, String RoomName, int id)
		{
			return roomService.UpdateRoom(RoomType, RoomName, id);
		}
	
		public RoomService roomService = new RoomService();
	
	}
}
