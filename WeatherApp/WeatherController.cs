using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace WeatherApp
{
	static public class WeatherController
	{
		private const string BASE_URL = "https://goweather.herokuapp.com/weather/";

		private static List<string> cities = new List<string>() { "Kyiv", "Odesa" };

		public static List<Weather> Get()
		{
			var tempCities = new List<Weather>();

			foreach (var city in cities)
			{
				WebRequest reqGET = WebRequest.Create(BASE_URL + city);
				WebResponse resp = reqGET.GetResponse();
				Stream stream = resp.GetResponseStream();
				StreamReader sr = new StreamReader(stream);
				string json = sr.ReadToEnd();
				Weather weather = JsonConvert.DeserializeObject<Weather>(json);

				weather.NameCity = city;
				tempCities.Add(weather);
			}
			return tempCities;
		}

	}
}
