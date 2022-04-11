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
         return null;
      }
      
      public Boolean LogOut()
      {
         // TODO: implement
         return null;
      }
      
      public int ViewProfile()
      {
         // TODO: implement
         return 0;
      }
   
      public String Name;
      public String Surname;
      public String Jmbg;
      public String Telephone;
      public String Email;
      public DateTime BirthDate;
      public String Adress;
      public int Id;
   
   }
}