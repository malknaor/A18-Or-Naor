using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI_namespace
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
