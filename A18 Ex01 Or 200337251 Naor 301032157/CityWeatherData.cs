using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public static class CityWeatherData
    {
        static CityWeatherData()
        {
        }

        public static string CheckWeatherData(string i_City)
        {
            return WeatherAPI.GetTemp(i_City).ToString();
        }
    }
}
