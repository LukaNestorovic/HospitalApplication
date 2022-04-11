/***********************************************************************
 * Module:  Doctor.cs
 * Author:  lukaa
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

        public Doctor(string specialty, float grade, int salary)
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