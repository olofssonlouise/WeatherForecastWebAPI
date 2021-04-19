using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherForecastWebAPI
{
    public class ReadCsvFile : IReadCsvFile
    {
        public List<WeatherForecast> GetData()
        {
            List<WeatherForecast> forecast = File.ReadAllLines("C:/Users/louise.olofsson/source/repos/WeatherForecastWebAPI/WeatherForecastWebAPI/temperatures.csv")
                .Skip(1)
                .Select(v => WeatherForecast.FromCsv(v))
                .ToList();

            return forecast;

        }

        public string GetJsonData()
        {
            List<WeatherForecast> forecast = GetData();

            string jsonResult = JsonConvert.SerializeObject(forecast, Formatting.Indented);                                     //Skapar en json fil av csv-filen
            //string jsonPath = @"C:/Users/louise.olofsson/source/repos/WeatherForecastWebAPI/WeatherForecastWebAPI/weather.json"; //path vart json fil ska skapas
            //using (var tw = new StreamWriter(jsonPath, true))                                                //skriver ut json fil och sparar i fil "weather.json".
            //{
            //    tw.WriteLine(jsonResult.ToString());
            //    tw.Close();
            //}
            return jsonResult;
        }
    }
}
