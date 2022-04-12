/***********************************************************************
 * Module:	RoomService.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;
using Model;

namespace Service
{
	public class RoomService
	{
		public Boolean CreateRoom(String roomType, String roomName)
		{
			Room newRoom = new Room(roomType, roomName);
			
			return roomRepository.Save(newRoom);
		}
		
		public Boolean UpdateRoom(String roomType, String roomName, int id)
		{
			Room room = roomRepository.FindByID(id);
			room.RoomType = roomType;
			room.Name = roomName;
			return roomRepository.UpdateByID(room);
		}
		
		public Boolean DeleteRoom(int id)
		{
			return roomRepository.DeleteByID(id);
		}
		
		public Room ReadRoom(int id)
		{
			return roomRepository.FindByID(id);
		}
	
		public Repository.RoomRepository roomRepository;
	
	}
}
