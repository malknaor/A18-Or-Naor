using System.Collections.Generic;

namespace A18_Ex01_Or_200337251_Naor_301032157
{

    //FACADE
    public class SportsActivityPlanner
    {
        public List<string> ActivityCategory { get; private set; }

        public List<string> Forecast { get; private set; }

        private WeatherFacade WeatherFacade { get; set; }

        public SportsActivityPlanner()
        {
            WeatherFacade = new WeatherFacade();
            initCategories();
        }

        private void initCategories()
        {
            ActivityCategory = new List<string>();

            ActivityCategory.Add("BasketBall");
            ActivityCategory.Add("Climbing");
            ActivityCategory.Add("Cycling");
            ActivityCategory.Add("FootBall");
            ActivityCategory.Add("Hiking");
            ActivityCategory.Add("Running");
            ActivityCategory.Add("Surfing");
            ActivityCategory.Add("Swimming");
            ActivityCategory.Add("Tennis");
            ActivityCategory.Add("Walking");
        }

        public List<string> GetWeeklyForecastByCity(string i_City)
        {
            buildWeeklyForecastList(i_City);

            return Forecast;
        }

        private void buildWeeklyForecastList(string i_City)
        {
            Forecast = new List<string>();
            WeatherFacade.GetWeeklyForecast(i_City);

            foreach (WeatherForecast forecast in (WeatherFacade.WeeklyForecast as WeeklyForecast).Forecast)
            {
                Forecast.Add(forecast.ToString());
            }
        }
    }
}