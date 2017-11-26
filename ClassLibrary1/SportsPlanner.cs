using System.Collections.Generic;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class SportsPlanner
    {
        public DailyWeatherData CurrentWeatherData { get; private set; }

        public List<string> ActivityCategory { get; private set; }

        public SportsPlanner()
        {
            ActivityCategory = new List<string>();

            #region Activity
            ActivityCategory.Add("BasketBall");
            ActivityCategory.Add("FootBall");
            ActivityCategory.Add("Tennis");
            ActivityCategory.Add("Running");
            ActivityCategory.Add("Walking");
            ActivityCategory.Add("Cycling");
            ActivityCategory.Add("Surfing");
            ActivityCategory.Add("Swimming");
            ActivityCategory.Add("Climbing");
            #endregion
        }

        public DailyWeatherData GetWeatherData(string i_City)
        {
            CurrentWeatherData = WeatherAPI.GetCityForecast(i_City);
        
            return CurrentWeatherData;
        }
    }
}