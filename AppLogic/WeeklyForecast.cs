using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class WeeklyForecast : WeatherForecast
    {
        //For next assignment - Itterator with projection of the 3 hour forecast.
        [XmlElement("forecast")]
        public List<WeatherForecast> Forecast { get; private set; }

        private readonly string r_DesiredWeatherTime = "18:00:00";

        public WeeklyForecast(XmlNode i_XmlNode)
        {
            XmlNode temp_node = i_XmlNode.SelectSingleNode("location");
            XmlAttribute temp_value;

            Location = temp_node.SelectSingleNode("name").InnerText;
            Forecast = new List<WeatherForecast>();
            temp_node = i_XmlNode.SelectSingleNode("forecast");

            foreach (XmlNode item in temp_node)
            {
                temp_value = item.Attributes["from"];

                if (temp_value.Value.Contains(r_DesiredWeatherTime))
                {
                    Forecast.Add(new ThreeHoursForecast(item, Location));
                }
            }
        }
    }
}