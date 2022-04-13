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
			
			String jsonString = JsonSerializer.Serialize(objects);
			
			File.WriteAllText(fileName, jsonString);
		}
		
		public List<T> fromJSON(String fileName){
			List<T> objects = new List<T>();

			try
			{
				String jsonString = File.ReadAllText(fileName);
				
				objects = JsonSerializer.Deserialize<List<T>>(jsonString);

				

			}
			catch (Exception e)
			{
			}
			return objects;
		}
	}
}
