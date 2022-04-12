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
        public PatientService patientService = new PatientService();
        public RoomService roomService = new RoomService();
      public Boolean CreateOperation(DateTime dateTime, int duration, String type, int patientId, int doctorId, int roomId)
      {
            Patient patient = patientService.ReadPatient(patientId);
            Room room = roomService.ReadRoom(roomId);

         return operationService.CreateOperation(dateTime, duration, type, patient, doctor, room);
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