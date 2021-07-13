namespace WeatherApp
{
	public class Weather
	{
        public string NameCity { get; set; }
        public string Temperature { get; set; }
        
		public override string ToString()
		{
			return $"{NameCity}: {Temperature}";
		}

	}
}
