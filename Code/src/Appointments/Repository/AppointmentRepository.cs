/***********************************************************************
 * Module:	AppointmentRepository.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Repository.AppointmentRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Appointments.Model;
using Serialization;
using Interface;

namespace Appointments.Repository
{
	public class AppointmentRepository : IAppointmentRepository
	{
		public List<Appointment> FindAll()
		{
			return serializer.fromJSON(FileName);
		}
		
		public Appointment FindByID(int id)
		{
			List<Appointment> all = FindAll();
			Appointment a = null;
			foreach (Appointment i in all){
				if(i.Id == id){
					a = i;
					break;
				}
			}
			return a;
		}
		
		public Boolean Save(Appointment appointment)
		{
			List<Appointment> all = FindAll();
			all.Add(appointment);
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean DeleteByID(int id)
		{
			List<Model.Appointment> all = FindAll();
			foreach (Model.Appointment i in all){
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
			List<Appointment> all = FindAll();
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
		
		private static Serializer<Model.Appointment> serializer = new Serializer<Model.Appointment>();
	
	}
}
