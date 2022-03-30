/***********************************************************************
 * Module:  SavePatient.cs
 * Author:  lukaa
 * Purpose: Definition of the Class SavePatient
 ***********************************************************************/

using System;
using Patient;
using PatientRepository;

public class PatientService
{
    public PatientRepository patientRepository;


    public Patient CreatePatient(String name, String surname, String jmbg, Gender gender, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier)
    {
        Patient newPatient(name, surname, jmbg, gender, telephone, email, birthDate, adress, insuranceCarrier);
        if (patientRepository.Save(newPatient))
            return newPatient;
        return null;
    }

    public Patient UpdatePatient(String name, String surname, String jmbg, Gender gender, String telephone, String email, DateTime birthDate, String adress, String insuranceCarrier)
    {
        Patient newPatient(name, surname, jmbg, gender, telephone, email, birthDate, adress, insuranceCarrier);
        if(patientRepository.Update(newPatient))
            return newPatient;
        return null;
    }

    public Boolean DeletePatient(String jmbg)
    {
        // TODO: implement
        return null;
    }

    public Patient ReadPatient(String jmbg)
    {
        // TODO: implement
        return null;
    }


}