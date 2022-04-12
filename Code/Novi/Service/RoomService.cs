/***********************************************************************
 * Module:	RoomService.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;

namespace Service
{
	public class RoomService
	{
		public Boolean CreateRoom(String roomType, String roomName)
		{
			int newID;
			if(File.Exists(idFile)){
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}else
				newID = 0;
			Room newRoom = new Room(roomType, roomName, newID);
			
			File.WriteAllText(idFile, newID.ToString());
			
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
		
		public List<Room> ReadAll(){
			return roomRepository.FindAll();
		}
		
		public Repository.RoomRepository roomRepository = new RoomRepository();
		public String idFile = @"..\..\..\Data\roomID.txt";
	}
}
