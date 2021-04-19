using System.Collections.Generic;

namespace WeatherForecastWebAPI
{
    public interface IReadCsvFile
    {
        List<WeatherForecast> GetData();
    }
}