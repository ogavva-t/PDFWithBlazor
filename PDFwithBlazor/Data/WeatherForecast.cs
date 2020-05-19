using System;
using System.Collections.Generic;

namespace PDFwithBlazor.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
    public class WeatherForecastList
    {
        public List<WeatherForecast> Forecasts { get; set; }
    }
}
