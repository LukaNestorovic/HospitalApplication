/***********************************************************************
 * Module:  Operation.cs
 * Author:  Ryzen
 * Purpose: Definition of the Class Operation
 ***********************************************************************/

using System;

namespace Model
{
   public class Operation
   {
      public DateTime DateTime;
      public int Duration;
      public String Type;
      public int Id;
      
      public Patient patient;
      public System.Collections.ArrayList doctor;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDoctor()
      {
         if (doctor == null)
            doctor = new System.Collections.ArrayList();
         return doctor;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctor(System.Collections.ArrayList newDoctor)
      {
         RemoveAllDoctor();
         foreach (Doctor oDoctor in newDoctor)
            AddDoctor(oDoctor);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctor(Doctor newDoctor)
      {
         if (newDoctor == null)
            return;
         if (this.doctor == null)
            this.doctor = new System.Collections.ArrayList();
         if (!this.doctor.Contains(newDoctor))
            this.doctor.Add(newDoctor);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctor(Doctor oldDoctor)
      {
         if (oldDoctor == null)
            return;
         if (this.doctor != null)
            if (this.doctor.Contains(oldDoctor))
               this.doctor.Remove(oldDoctor);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctor()
      {
         if (doctor != null)
            doctor.Clear();
      }
      public Room room;
   
   }
}