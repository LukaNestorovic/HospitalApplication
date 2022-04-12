using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serialization
{
	class Serializer<T>
	{
		private static char DELIMITER = ',';
		private static char[] TRAILING = {'[', ']'};
		
		public void toJSON(String fileName, List<T> objects){
			
			String[] jsonList = new String[objects.Count];
			for(int i = 0; i < objects.Count; i++){
				jsonList[i] = JsonSerializer.Serialize(objects[i]);
			}
			
			String jsonString = Char.ToString(TRAILING[0]);
			jsonString += String.Join(DELIMITER, jsonList);
			jsonString += TRAILING[1];
			
			File.WriteAllText(fileName, jsonString);
		}
		
		public List<T> fromJSON(String fileName){
			List<T> objects = new List<T>();

			try
			{
				String jsonString = File.ReadAllText(fileName);
				jsonString.Trim(TRAILING);

				String[] objectStrings = jsonString.Split(DELIMITER);

				foreach (String objStr in objectStrings)
				{
					Console.WriteLine(jsonString);
					T obj = JsonSerializer.Deserialize<T>(jsonString);
					objects.Add(obj);
				}
			}
			catch (Exception e)
			{
			}
			return objects;
		}
	}
}
