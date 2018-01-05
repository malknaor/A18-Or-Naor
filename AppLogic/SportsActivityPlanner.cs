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
            ActivityCategory.Add("FootBall");
            ActivityCategory.Add("Tennis");
            ActivityCategory.Add("Running");
            ActivityCategory.Add("Walking");
            ActivityCategory.Add("Cycling");
            ActivityCategory.Add("Surfing");
            ActivityCategory.Add("Swimming");
            ActivityCategory.Add("Climbing");
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

            foreach (ThreeHoursForecast forecast in WeatherFacade.WeeklyForecast.Forecast)
            {
                Forecast.Add(WeatherFacade.WeeklyForecast.Location + ": " + forecast.ToString());
            }
        }
    }
}