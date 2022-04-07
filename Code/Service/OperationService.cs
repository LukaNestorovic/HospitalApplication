/***********************************************************************
 * Module:  OperationService.cs
 * Author:  lukaa
 * Purpose: Definition of the Class Service.OperationService
 ***********************************************************************/

using System;

namespace Service
{
   public class OperationService
   {
      public Boolean CreateOperation(Doctor doctor, DateTIme dateTime, int duratin, String type, int id)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean UpdateOperation(Operation operation)
      {
         // TODO: implement
         return null;
      }
      
      public Boolean DeleteOperation(int id)
      {
         // TODO: implement
         return null;
      }
      
      public Operation ReadOperation(int id)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.OperationRepository operationRepository;
   
   }
}