using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class WeeklyForecast : WeatherForecast
    {
        //For next assignment - Itterator with projection of the 3 hour forecast.
        [XmlElement("forecast")]
        public List<WeatherForecast> Forecast { get; private set; }

        //private readonly string r_DesiredWeatherTime = "18:00:00";

        public WeeklyForecast(XmlNode i_XmlNode)
        {
            List<string> date = new List<string>();
            XmlNode temp_node = i_XmlNode.SelectSingleNode("location");
            XmlAttribute temp_value;

            Location = temp_node.SelectSingleNode("name").InnerText;
            Forecast = new List<WeatherForecast>();
            temp_node = i_XmlNode.SelectSingleNode("forecast");
            string dateToCheck;

            foreach (XmlNode item in temp_node)
            {
                temp_value = item.Attributes["from"];
                dateToCheck = temp_value.Value.ToString();

                dateToCheck = dateToCheck.Substring(0, dateToCheck.IndexOf("T")); /*Replace("T", " ");*/

                if (!date.Contains(dateToCheck))
                {
                    date.Add(dateToCheck);
                    Forecast.Add(new DailyForecast(temp_value.Value, Location));
                }
            }

            int i = 0;
            foreach (DailyForecast daily in Forecast)
            {
                dateToCheck = date[i];
                
                foreach (XmlNode item in temp_node)
                {
                    temp_value = item.Attributes["from"];
                    
                    if (temp_value.Value.Contains(dateToCheck))
                    {
                        daily.AddForecast(item);
                    }
                }

                i++;
            }
        }

        public void AddDailyForecast()
        {
            
        }

        public void Reset()
        {
            foreach(WeatherForecast daily in Forecast)
            {
                (daily as DailyForecast).Reset();
            }
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