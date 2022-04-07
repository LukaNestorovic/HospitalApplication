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
   
      private String Name;
      private String Surname;
      private String Jmbg;
      private Gender Gender;
      private String Telephone;
      private String Email;
      private DateTime BirthDate;
      private String Adress;
   
   }
}