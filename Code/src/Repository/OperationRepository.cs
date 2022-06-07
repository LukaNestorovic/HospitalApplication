/***********************************************************************
 * Module:	OperationRepository.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Repository.OperationRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Serialization;

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
		
		public Boolean Save(Operation operation)
		{
			List<Operation> all = serializer.fromJSON(FileName);
			all.Add(operation);
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
		
		public Boolean UpdateByID(Operation operation)
		{
			List<Operation> all = serializer.fromJSON(FileName);
			for(int i = 0; i < all.Count; i++){
				if(all[i].Id == operation.Id){
					all[i] = operation;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		public List<Operation> ReadAllByDoctorId(int id)
		{
			try
			{
				List<Operation> all = serializer.fromJSON(FileName);
				List<Operation> ret = new List<Operation>();
				foreach (Operation i in all)
				{
					if (i.doctor == null)
					{
						continue;
					}
					if (i.doctor.Id == id)
					{
						ret.Add(i);
					}
				}
				this.ret = ret;
				return ret;
			}
			catch
			{
				return null;
			}
		}

		private static String FileName = @"..\..\..\data\Operations.json";
		
		private static Serializer<Operation> serializer = new Serializer<Operation>();
		private List<Operation> ret = new List<Operation>();
	}
}
