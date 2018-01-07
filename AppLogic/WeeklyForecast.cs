using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class WeeklyForecast : WeatherForecast
    {
        [XmlElement("forecast")]
        public List<WeatherForecast> Forecast { get; private set; }

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

                dateToCheck = dateToCheck.Substring(0, dateToCheck.IndexOf("T"));

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
                        ThreeHoursForecast nodeToAdd = new ThreeHoursForecast(item, Location);
                        daily.AddForecast(nodeToAdd);
                    }
                }

                i++;
            }
        }

        public void AddDailyForecast(WeatherForecast i_Weather)
        {
            Forecast.Add(i_Weather);
        }

        public void Reset()
        {
            foreach(WeatherForecast daily in Forecast)
            {
                (daily as DailyForecast).Reset();
            }
        }

        public override void ForecastToList(ref List<string> io_List)
        {
            foreach (WeatherForecast item in Forecast)
            {
                item.ForecastToList(ref io_List);                
            }
        }
    }
}