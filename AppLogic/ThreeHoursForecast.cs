using System;
using System.Collections.Generic;
using System.Xml;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class ThreeHoursForecast : WeatherForecast
    {
        protected float Temperture { get; set; }

        protected string Description { get; set; }

        public ThreeHoursForecast(XmlNode i_XmlNode, string i_Location)
        {
            XmlNode temp_node = i_XmlNode;
            XmlAttribute temp_value = temp_node.Attributes["from"];
            string dateTime = temp_value.Value;

            dateTime = dateTime.Replace("T", " ");

            DateAndTime = DateTime.Parse(dateTime);
            temp_node = i_XmlNode.SelectSingleNode("temperature");
            temp_value = temp_node.Attributes["value"];
            Temperture = float.Parse(temp_value.Value);
            temp_node = i_XmlNode.SelectSingleNode("symbol");
            temp_value = temp_node.Attributes["name"];
            Description = temp_value.Value;
            Location = i_Location;
        }

        public override void forecastTolList(ref List<string> io_List)
        {
            io_List.Add(ToString());
        }

        public override string ToString()
        {
            return Location + ": " + DateAndTime.ToString() + ", Temp: " + Temperture.ToString() + ", " + Description + "."; ;
        }
    }
}
