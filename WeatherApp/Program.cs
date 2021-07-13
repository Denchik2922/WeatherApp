using System;
using System.Collections.Generic;

namespace WeatherApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Weather> temperatureCities = WeatherController.Get();
			
			foreach (var temp in temperatureCities)
			{
				Console.WriteLine(temp.ToString());
			}

		}
	}
}
