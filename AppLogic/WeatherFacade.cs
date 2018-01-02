﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class WeatherFacade
    {
        public WeeklyForecast WeeklyForecast { get; private set; }

        public WeatherFacade()
        {

        }

        public WeeklyForecast GetWeeklyForecast(string i_City)
        {
            return doGetWeeklyForecast(i_City);
        }

        private WeeklyForecast doGetWeeklyForecast(string i_City)
        {
            WeeklyForecast = WeatherAPI.GetCityForecast(i_City);

            return WeeklyForecast;
        }
    }
}
