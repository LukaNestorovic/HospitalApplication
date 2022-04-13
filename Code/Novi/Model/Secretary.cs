/***********************************************************************
 * Module:	Secretary.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Secretary
 ***********************************************************************/

using System;

namespace Model
{
	public class Secretary : User
	{
		public int Salary { get; set; }

		public Secretary(int salary)
		{
			Salary = salary;
		}

		public Secretary()
		{
		}
	 }
}
