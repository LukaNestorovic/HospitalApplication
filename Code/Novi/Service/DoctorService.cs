/***********************************************************************
 * Module:	SaveDoctor.cs
 * Author:	lukaa
 * Purpose: Definition of the Class SaveDoctor
 ***********************************************************************/

using System;
using Model;

namespace Service
{
	public class DoctorService
	{
		public Boolean CreateDoctor(Doctor patient)
		{
			// TODO: implement
			return false;
		}
		
		public Boolean UpdateDoctor(Doctor patient)
		{
			// TODO: implement
			return false;
		}
		
		public Boolean DeleteDoctor(int id)
		{
			// TODO: implement
			return false;
		}
		
		public Doctor ReadDoctor(int id)
		{
			// TODO: implement
			return null;
		}
	
		public Repository.DoctorRepository patientRepository;
		public String idFile = @"..\..\..\Data\doctorID.txt";

	}
}
