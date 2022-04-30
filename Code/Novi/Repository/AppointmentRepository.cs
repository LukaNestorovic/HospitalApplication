/***********************************************************************
 * Module:	AppointmentRepository.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Repository.AppointmentRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Serialization;

namespace Repository
{
	public class AppointmentRepository
	{
		public List<Appointment> FindAll()
		{
			return serializer.fromJSON(FileName);
		}

		public List<Appointment> FindAllByPatientId(int id)
        {
			try
			{
				List<Appointment> all = serializer.fromJSON(FileName);
				List<Appointment> ret = new List<Appointment>();
				foreach (Appointment i in all)
				{
					if (i.Patient.Id == id)
					{
						ret.Add(i);
					}
				}
				return ret;
			}
            catch
            {
				return null;
            }
        }
		
		public Appointment FindByID(int id)
		{
			List<Appointment> all = serializer.fromJSON(FileName);
			Appointment a = null;
			foreach(Appointment i in all){
				if(i.Id == id){
					a = i;
					break;
				}
			}
			return a;
		}
		
		public Boolean Save(Appointment appointment)
		{
			List<Appointment> all = serializer.fromJSON(FileName);
			all.Add(appointment);
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean DeleteByID(int id)
		{
			List<Appointment> all = serializer.fromJSON(FileName);
			foreach(Appointment i in all){
				if(i.Id == id){
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean UpdateByID(Appointment appointment)
		{
			List<Appointment> all = serializer.fromJSON(FileName);
			for(int i = 0; i < all.Count; i++){
				if(all[i].Id == appointment.Id){
					all[i] = appointment;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}
	
		private static String FileName = @"..\..\..\data\Appointments.json";
		
		private static Serializer<Appointment> serializer = new Serializer<Appointment>();
	
	}
}
