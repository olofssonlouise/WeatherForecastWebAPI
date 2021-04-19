using System;
using System.Globalization;

namespace WeatherForecastWebAPI
{
    public class WeatherForecast
    {
        public int ID { get; init; }
        public decimal Temperature { get; init; }
        public DateTime Timestamp { get; init; }

        public static WeatherForecast FromCsv(string csvLine)
        {
            var values = csvLine.Split(';');
            var weatherForecast = new WeatherForecast
            {
                ID = Convert.ToInt32(values[0]),
                Temperature = Convert.ToDecimal(values[1], new CultureInfo("en-US")),
                Timestamp = Convert.ToDateTime(values[2])
            };
            return weatherForecast;
        }
    }
}
