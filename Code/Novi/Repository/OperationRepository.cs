/***********************************************************************
 * Module:  OperationRepository.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Repository.OperationRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;

namespace Repository
{
   public class OperationRepository
   {
   
      public List<Operation> FindAll()
      {
         // TODO: implement
         return null;
      }
      
      public Operation FindByID(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean Save(Operation operation)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean DeleteByID(int id)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean UpdateByID(Operation operation)
      {
         // TODO: implement
         return false;
      }
   
      private String FileName;
   }
}
