using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class WeeklyForecast : IForecast
    {
        //For next assignment - Itterator with projection of the 3 hour forecast.
        public string Location { get; private set; }

        public DateTime DateAndTime { get; private set; }

        public float Temperture { get; private set; }

        public string Description { get; private set; }

        [XmlElement("forecast")]
        public List<ThreeHoursForecast> Forecast { get; private set; }

        private readonly string r_DesiredWeatherTime = "18:00:00";

        public WeeklyForecast(XmlNode i_XmlNode)
        {
            XmlNode temp_node = i_XmlNode.SelectSingleNode("location");
            XmlAttribute temp_value;

            Location = temp_node.SelectSingleNode("name").InnerText;
            Forecast = new List<ThreeHoursForecast>();
            temp_node = i_XmlNode.SelectSingleNode("forecast");

            foreach (XmlNode item in temp_node)
            {
                temp_value = item.Attributes["from"];

                if (temp_value.Value.Contains(r_DesiredWeatherTime))
                {
                    Forecast.Add(new ThreeHoursForecast(item));
                }
            }
        }

        public override string ToString()
        {
            string weather = string.Empty;

            foreach (ThreeHoursForecast forecast in Forecast)
            {
                weather += Location + ": " + forecast.ToString() + "." + Environment.NewLine;
            }

            return weather;
        }
    }
}