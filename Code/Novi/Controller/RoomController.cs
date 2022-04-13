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
		
		public String[] ReadRoom(int id)
		{
			Room room = roomService.ReadRoom(id);
//			String[] roomDTO = new String[3];
//			roomDTO[0] = room.RoomType;
//			roomDTO[1] = room.Name;
//			roomDTO[2] = room.Id.ToString();
			return room;
		}
		
		public List<String[]> ReadAll(){
			List<Room> rooms = roomService.ReadAll();
//			List<String[]> roomDTOs = new List<String[]>();
//			foreach(Room r in rooms){
//				String[] dto = new String[3];
//				dto[0] = r.RoomType;
//				dto[1] = r.Name;
//				dto[2] = r.Id.ToString();
//				roomDTOs.Add(dto);
//			}
			return rooms;
		}
		public Boolean UpdateRoom(String RoomType, String RoomName, int id)
		{
			return roomService.UpdateRoom(RoomType, RoomName, id);
		}
	
		public RoomService roomService = new RoomService();
	
	}
}
