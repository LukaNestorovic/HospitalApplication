/***********************************************************************
 * Module:	Doctor.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Doctor
 ***********************************************************************/

using System;

namespace Model
{
	public class Doctor : User
	{
		public String Specialty { get; set; }
		public float Grade { get; set; }
		public int Salary { get; set; }

<<<<<<< HEAD
		public Doctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, string specialty, float grade, int salary, int id, string password):base(name, surname, jmbg, telephone, email, birthDate, adress, id, password)
=======
		public Doctor(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, string specialty, float grade, int salary,String password, int id):base(name, surname, jmbg, telephone, email, birthDate, adress, id, password)
>>>>>>> a637d67fecab95d816341cdc97b890490b7f2c24
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
