using System.Collections.Generic;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class SportsActivityPlannerFacade
    {
        public List<string> ActivityCategory { get; private set; }

        public List<string> HoursCategory { get; private set; }

        private WeatherFacade WeatherFacade { get; set; }

        public SportsActivityPlannerFacade()
        {
            WeatherFacade = new WeatherFacade();
            initCategories();
            initHours();
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

        private void initHours()
        {
            HoursCategory = new List<string>();

            HoursCategory.Add("00:00:00");
            HoursCategory.Add("03:00:00");
            HoursCategory.Add("06:00:00");
            HoursCategory.Add("09:00:00");
            HoursCategory.Add("12:00:00");
            HoursCategory.Add("15:00:00");
            HoursCategory.Add("18:00:00");
            HoursCategory.Add("21:00:00");
        }

        private void buildWeeklyForecastList(string i_City)
        {
            WeatherFacade.GetWeeklyForecast(i_City);
        }

        public List<string> GetWGetWeeklyForecastByCityAndHour(string i_City, string i_Time)
        {
            List<string> forecastList = new List<string>();
            List<string> filterByTime = new List<string>();
            buildWeeklyForecastList(i_City);

            WeatherFacade.WeeklyForecast.forecastTolList(ref forecastList);

            foreach (string item in forecastList)
            {
                if (item.Contains(i_Time))
                {
                    filterByTime.Add(item);
                }
            }

            return filterByTime;
        }
    }
}