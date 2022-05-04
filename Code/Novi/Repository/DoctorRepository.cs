/***********************************************************************
 * Module:	DoctorRepository.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Repository.DoctorRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Serialization;

namespace Repository
{
	public class DoctorRepository
	{
		public List<Doctor> FindAll()
		{
			return serializer.fromJSON(FileName);
		}

		public Doctor FindByID(int id)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			Doctor a = null;
			foreach (Doctor i in all)
			{
				if (i.Id == id)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Doctor FindByEmail(String email)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			Doctor a = null;
			foreach (Doctor i in all)
			{
				if (i.Email == email)
				{
					a = i;
					break;
				}
			}
			return a;
		}

		public Boolean Save(Doctor doctor)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			all.Add(doctor);
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean DeleteByID(int id)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			foreach (Doctor i in all)
			{
				if (i.Id == id)
				{
					all.Remove(i);
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return true;
		}

		public Boolean UpdateByID(Doctor doctor)
		{
			List<Doctor> all = serializer.fromJSON(FileName);
			for (int i = 0; i < all.Count; i++)
			{
				if (all[i].Id == doctor.Id)
				{
					all[i] = doctor;
					break;
				}
			}
			serializer.toJSON(FileName, all);
			return false;
		}

		private static String FileName = @"..\..\..\data\Doctors.json";

		private static Serializer<Doctor> serializer = new Serializer<Doctor>();

	}
}
