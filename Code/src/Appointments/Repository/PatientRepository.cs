/***********************************************************************
 * Module:	PatientRepository.cs
 * Author:	lukaa
 * Purpose: Definition of the Class PatientRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Appointments.Model;
using Serialization;
using Interface;

namespace Appointments.Repository
{
	public class PatientRepository : IPatientRepository
	{

        public List<Patient> FindAll()
		{
			return serializer.fromJSON(FileName);
		}
		
		public Patient FindByID(int id)
		{
			List<Patient> all = serializer.fromJSON(FileName);
			Patient a = null;
			foreach(Patient i in all){
				if(i.Id == id){
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(Patient patient)
		{
			List<Patient> all = serializer.fromJSON(FileName);
			all.Add(patient);
			serializer.toJSON(FileName, all);
			return true;
		}
		
		public Boolean DeleteByID(int id)
		{
			List<Patient> all = serializer.fromJSON(FileName);
			foreach(Patient i in all){
				if(i.Id == id){
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean UpdateByID(Patient patient)
		{
			List<Patient> all = serializer.fromJSON(FileName);
			for(int i = 0; i < all.Count; i++){
				if(all[i].Id == patient.Id){
					all[i] = patient;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}
	
		private static String FileName = @"..\..\..\data\Patients.json";
		
		private static Serializer<Patient> serializer = new Serializer<Patient>();
	}
}
