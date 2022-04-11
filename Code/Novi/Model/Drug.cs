/***********************************************************************
 * Module:  Drug.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Drug
 ***********************************************************************/

using System;

namespace Model
{
   public class Drug
   {
      public String Name { get; set; }
      public String Ingredients { get; set; }
      public Boolean Approved { get; set; }
      public int Id { get; set; }

        public Drug(string name, string ingredients, bool approved, int id)
        {
            Name = name;
            Ingredients = ingredients;
            Approved = approved;
            Id = id;
        }

        public Drug()
        {
        }
    }
}