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
			
			if(File.Exists(idFile)){
				int newID = ++(int.Parse(File.ReadAllText(idFile)));
			}else
				int newID = 0;
			Room newRoom = new Room(roomType, roomName, newID);
			
			File.WriteAllText(idFile, newID.ToStrint());
			
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
	
		public static Repository.RoomRepository roomRepository = new RoomRepository();
		public static String idFile = "roomID.txt";
	}
}
