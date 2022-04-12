/***********************************************************************
 * Module:  OperationController.cs
 * Author:  SN CAR CODING
 * Purpose: Definition of the Class Controller.OperationController
 ***********************************************************************/

using System;
using Service;
using Model;

namespace Controller
{
   public class OperationController
   {
      public Boolean CreateOperation(Operation operation)
      {
         // TODO: implement
         return operationService.CreateOperation(operation);
      }
      
      public Boolean DeleteOperation(int id)
      {
         // TODO: implement
         return operationService.DeleteOperation(id);
      }
      
      public Boolean UpdateOperation(Operation operation)
      {
         // TODO: implement
         return operationService.UpdateOperation(operation);
      }
      
      public Boolean ReadOperation()
      {
         // TODO: implement
         return false;
      }
   
      public OperationService operationService = new OperationService();
   
   }
}