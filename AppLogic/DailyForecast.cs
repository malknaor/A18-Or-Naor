using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class DailyForecast : WeatherForecast
    {
        public List<WeatherForecast> Forecast { get; private set; }

        public DailyForecast(string i_DateAndTime, string i_Location)
        {
            i_DateAndTime.Replace("T", " ");
            DateAndTime = DateTime.Parse(i_DateAndTime);
            Location = i_Location;
            Forecast = new List<WeatherForecast>();
        }

        public void AddForecast(XmlNode i_XmlNode)
        {
            Forecast.Add(new ThreeHoursForecast(i_XmlNode, Location));
        }

        public void Reset()
        {
            Forecast.Clear();
        }

        public override void forecastTolList(ref List<string> io_List)
        {
            foreach (WeatherForecast item in Forecast)
            {
                item.forecastTolList(ref io_List);
            }
        }
    }
}
