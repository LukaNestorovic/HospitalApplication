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
        public DoctorService doctorService = new DoctorService();
      public Boolean CreateOperation(DateTime dateTime, int duration, String type, int patientId, int doctorId, int roomId)
      {
            Patient patient = patientService.ReadPatient(patientId);
            Room room = roomService.ReadRoom(roomId);
            Doctor doctor = doctorService.ReadDoctor(doctorId);

         return operationService.CreateOperation(dateTime, duration, type, patient, doctor, room);
      }
      
      public Boolean DeleteOperation(int id)
      {
         return operationService.DeleteOperation(id);
      }
      
      public Boolean UpdateOperation(DateTime dateTime, int duration, String type, int patientId, int doctorId, int roomId, int operationID)
      {
            Patient patient = patientService.ReadPatient(patientId);
            Doctor doctor = doctorService.ReadDoctor(doctorId);
            Room room = roomService.ReadRoom(roomId);
            return operationService.UpdateOperation(dateTime, duration, type, patient, doctor, room, operationID);
      }
      
      public String[] ReadOperation(int id)
      {
            Operation operation = operationService.ReadOperation(id);
            String[] operationDTO = new String[8];
            operationDTO[0] = operation.DateTime.ToString();
            operationDTO[1] = operation.Duration.ToString();
            operationDTO[2] = operation.Type.ToString();
            operationDTO[3] = operation.patient.Id.ToString();
            operationDTO[4] = operation.doctor.Id.ToString();
            operationDTO[5] = operation.room.Id.ToString();
            operationDTO[6] = operation.Id.ToString();
            return operationDTO;
        }
   
      public OperationService operationService = new OperationService();
   
   }
}
