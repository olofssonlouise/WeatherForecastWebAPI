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

    }
}
