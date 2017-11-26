using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class SportsPlanner
    {
        public DailyWeatherInfo CurrentWeatherData { get; private set; }

        public SportsPlanner()
        {
        }

        public DailyWeatherInfo GetWeatherInfo(string i_City)
        {
            CurrentWeatherData = WeatherAPI.GetCityForecast(i_City);
        
            return CurrentWeatherData;
        }
    }
}
