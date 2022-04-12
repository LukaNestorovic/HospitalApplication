/***********************************************************************
 * Module:	OperationRepository.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Repository.OperationRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
	public class OperationRepository
	{
		public List<Operation> FindAll()
		{
			return serializer.fromJSON(FileName);
		}
		
		public Operation FindByID(int id)
		{
			List<Operation> all = serializer.fromJSON(FileName);
			Operation a = null;
			foreach(Operation i in all){
				if(i.Id == id){
					a = i;
					break;
				}
			}
			return a;
		}
		
		public Boolean Save(Operation appointment)
		{
			List<Operation> all = serializer.fromJSON(FileName);
			all.Add(appointment);
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean DeleteByID(int id)
		{
			List<Operation> all = serializer.fromJSON(FileName);
			foreach(Operation i in all){
				if(i.Id == id){
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean UpdateByID(Operation appointment)
		{
			List<Operation> all = serializer.fromJSON(FileName);
			for(int i = 0; i < all.Count; i++){
				if(all[i].Id == appointment.Id){
					all[i] = appointment;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}
	
		private static String FileName = "Operations.json";
		
		private static Serializer<Operation> serializer = new Serializer<Operation>();
	}
}
