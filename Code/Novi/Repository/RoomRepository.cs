/***********************************************************************
 * Module:	RoomRepository.cs
 * Author:	lukaa
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
			return serializer.fromJSON(FileName);
		}
		
		public Room FindByID(int id)
		{
			List<Room> all = serializer.fromJSON(FileName);
			Room a = null;
			foreach(Room i in all){
				if(i.Id == id){
					a = i;
					break;
				}
			}
			return a;
		}
		
		public Boolean Save(Room room)
		{
			List<Room> all = serializer.fromJSON(FileName);
			all.Add(room);
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean DeleteByID(int id)
		{
			List<Room> all = serializer.fromJSON(FileName);
			foreach(Room i in all){
				if(i.Id == id){
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean UpdateByID(Room room)
		{
			List<Room> all = serializer.fromJSON(FileName);
			for(int i = 0; i < all.Count; i++){
				if(all[i].Id == room.Id){
					all[i] = room;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}
	
		private static String FileName = "Rooms.json";
		
		private static Serializer<Room> serializer = new Serializer<Room>();
	}
}
