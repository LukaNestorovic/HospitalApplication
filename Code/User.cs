/***********************************************************************
 * Module:  User.cs
 * Author:  lukaa
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;

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

    public User(String name, String surname, String jmbg, Gender gender, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier) {
        this.Name = name;
        this.Surname = surname;
        this.Jmbg = jmbg;
        this.Gender = gender;
        this.Telephone = telephone;
        this.Email = email;
        this.BirthDate = birthDate;
        this.Adress = adress;
        this.InsurenceCarrier = insuranceCarrier;
    }

}