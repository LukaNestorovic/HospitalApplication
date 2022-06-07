/***********************************************************************
 * Module:	RoomService.cs
 * Author:	lukaa
 * Purpose: Definition of the Class Service.RoomService
 ***********************************************************************/

using System;
using Model;
using Repository;
using System.IO;
using System.Collections.Generic;
using Appointments.Model;

namespace Service
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
			Operation newOperation = new Operation(dateTime, duration, type, newID, patient, doctor, room);

			File.WriteAllText(idFile, newID.ToString());

			return operationRepository.Save(newOperation);
		}

		public Boolean UpdateOperation(DateTime dateTime, int duration, String type, Patient patient, Doctor doctor, Room room, int id)
		{
			Operation operation = operationRepository.FindByID(id);
			operation.DateTime = dateTime;
			operation.Duration = duration;
			operation.Type = type;
			operation.patient = patient;
			operation.doctor = doctor;
			operation.room = room;
			return operationRepository.UpdateByID(operation);
		}

		public Boolean DeleteOperation(int id)
		{
			return operationRepository.DeleteByID(id);
		}

		public Operation ReadOperation(int id)
		{
			return operationRepository.FindByID(id);
		}

		public List<Operation> ReadAll()
		{
			return operationRepository.FindAll();
		}

		public static Repository.OperationRepository operationRepository = new OperationRepository();
		public String idFile = @"..\..\..\Data\operationID.txt";
	}
}
