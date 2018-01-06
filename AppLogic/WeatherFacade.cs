using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class WeatherFacade
    {
        public WeatherForecast WeeklyForecast { get; private set; }

        public WeatherFacade()
        {

        }

        public WeatherForecast GetWeeklyForecast(string i_City)
        {
            return doGetWeeklyForecast(i_City);
        }

        private WeatherForecast doGetWeeklyForecast(string i_City)
        {
            WeeklyForecast = WeatherAPI.GetCityForecast(i_City);

            return WeeklyForecast;
        }
    }
}
