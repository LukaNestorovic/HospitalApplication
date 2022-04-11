/***********************************************************************
 * Module:  User.cs
 * Author:  lukaa
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

namespace Model
{
   public abstract class User
   {
      public Boolean LogIn()
      {
         // TODO: implement
         return false;
      }
      
      public Boolean LogOut()
      {
         // TODO: implement
         return false;
      }
      
      public int ViewProfile()
      {
         // TODO: implement
         return 0;
      }
   
      public String Name { get; set; }
      public String Surname { get; set; }
      public String Jmbg { get; set; }
      public String Telephone { get; set; }
      public String Email { get; set; }
      public DateTime BirthDate { get; set; }
      public String Adress { get; set; }
      public int Id { get; set; }

        protected User(string name, string surname, string jmbg, string telephone, string email, DateTime birthDate, string adress, int id)
        {
            Name = name;
            Surname = surname;
            Jmbg = jmbg;
            Telephone = telephone;
            Email = email;
            BirthDate = birthDate;
            Adress = adress;
            Id = id;
        }

        protected User()
        {
        }
    }
}