using System.Collections.Generic;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class SportsActivityPlanner
    {
        public DailyForecast CurrentForecast { get; private set; }

        public List<string> ActivityCategory { get; private set; }

        public SportsActivityPlanner()
        {
            ActivityCategory = new List<string>();

            ActivityCategory.Add("BasketBall");
            ActivityCategory.Add("FootBall");
            ActivityCategory.Add("Tennis");
            ActivityCategory.Add("Running");
            ActivityCategory.Add("Walking");
            ActivityCategory.Add("Cycling");
            ActivityCategory.Add("Surfing");
            ActivityCategory.Add("Swimming");
            ActivityCategory.Add("Climbing");
        }

        public DailyForecast GetForecast(string i_City)
        {
            CurrentForecast = WeatherAPI.GetCityForecast(i_City);
        
            return CurrentForecast;
        }
    }
}