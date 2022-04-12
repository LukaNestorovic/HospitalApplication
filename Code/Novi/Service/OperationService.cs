/***********************************************************************
 * Module:	RoomService.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.IO;

namespace Operation
{
	public class OperationService
	{
		public Boolean CreateOperation(DateTime dateTime, int duration, String type, Patient patient, Doctor doctor, Room room)
		{
			int newID;
			if (File.Exists(idFile))
			{
				newID = int.Parse(File.ReadAllText(idFile));
				newID++;
			}
			else
				newID = 0;
			Operation newOperation = new Operation(dateTime, duration, type, patient, doctor, room, newID);

			File.WriteAllText(idFile, newID.ToString());

			return operationRepository.Save(newOperation);
		}

		public Boolean UpdateOperation(DateTime dateTime, int duration, String type, Patient patient, Doctor doctor, Room room, int id)
		{
			Operation operation = operationRepository.FindByID(id);
			operation.OperationDateTime = dateTime;
			operation.Duration = duration;
			operation.Type = type;
			operation.Patient = patient;
			operation.Doctor = doctor;
			operation.Room = room;
			return operationRepository.UpdateByID(operation);
		}

		public Boolean DeleteOperation(int id)
		{
			return operationRepository.DeleteByID(id);
		}

		public Room ReadOperation(int id)
		{
			return operationRepository.FindByID(id);
		}

		public static Repository.OperationRepository operationRepository = new OperationRepository();
		public static String idFile = "operationID.txt";
	}
}
