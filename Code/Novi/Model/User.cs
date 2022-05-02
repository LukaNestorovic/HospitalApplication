/***********************************************************************
 * Module:	User.cs
 * Author:	lukaa
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

namespace Model
{
	public abstract class User
	{
		public String Name { get; set; }
		public String Surname { get; set; }
		public String Jmbg { get; set; }
		public String Telephone { get; set; }
		public String Email { get; set; }
		public DateTime BirthDate { get; set; }
		public String Adress { get; set; }
		public int Id { get; set; }
		public String Password { get; set; }

<<<<<<< HEAD
		protected User(String name, String surname, String jmbg, String telephone, String email, DateTime birthDate, String adress, int id, String password)
=======
		protected User(string name, string surname, string jmbg, string telephone, string email, DateTime birthDate, string adress, int id, string password)
>>>>>>> development
		{
		  	Name = name;
		  	Surname = surname;
		  	Jmbg = jmbg;
		  	Telephone = telephone;
		  	Email = email;
		  	BirthDate = birthDate;
		  	Adress = adress;
		  	Id = id;
			Password = password;
		}

		protected User()
		{
		}
	 }
}
