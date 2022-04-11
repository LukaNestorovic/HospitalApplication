using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp.serialization
{
	class Serializer<T> where T: Serializable, new()
	{
		private static char DELIMITER = ',';
		private static char[] TRAILING = {'[', ']'};
		
		public void toJSON(String fileName, List<T> objects){
			
			String[] jsonList = new String[objects.Count];
			foreach(int i = 0; i < objects.COUNT; i++){
				jsonList[i] = JsonSerializer.Serialize(objects[i]);
			}
			
			String jsonString = TRAILING[0];
			jsonString += String.Join(DELIMITER, jsonList);
			jsonString += TRAILING[1];
			
			File.WriteAllText(fileName, jsonString);
		}
		
		public List<T> fromJSON(String fileName){
			List<T> objects = new List<T>();
			
			String jsonString = File.ReadAllText(fileName);
			jsonString.Trim(TRAILING);
			
			String[] objectStrings = jsonString.Split(DELIMITER);
			
			foreach(String objStr in objectStrings){
				T obj? = JsonSerializer.Deserialize<T>(jsonString);
				objects.Add(obj);
			}
			return objects;
		}
	}
}
