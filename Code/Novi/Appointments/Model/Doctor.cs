/***********************************************************************
 * Module:	Doctor.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using System;
using Model;

namespace Appointments.Model
{
	public class Doctor : User
	{
		public String Specialty { get; set; }
		public float Grade { get; set; }
		public int Salary { get; set; }

		public Doctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, string specialty, float grade, int salary, int id, string password):base(name, surname, jmbg, telephone, email, birthDate, adress, id, password)

		{
		  	Specialty = specialty;
		  	Grade = grade;
		  	Salary = salary;
		}

		public Doctor()
		{
		}
	 }
}
