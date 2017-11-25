using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class DailyWeatherInfo
    {
        public string Location { get; private set; }

        public DailyWeatherInfo(XmlNode i_XmlNode)
        {
            XmlNode temp_node = i_XmlNode.SelectSingleNode("location");
            XmlAttribute temp_value = temp_node.Attributes["name"];


            Location = temp_node.SelectSingleNode("name").Value;


            Forecast = new List<ThreeHoursWeatherInfo>();

            temp_node = i_XmlNode.SelectSingleNode("forecast");
            temp_value = temp_node.Attributes["name"];
            string DesiredTime = "17";

            foreach (XmlNode item in temp_node)
            {
                temp_value = item.Attributes["from"];

                if ((temp_value.ToString().Contains(DesiredTime)))
                {
                    Forecast.Add(new ThreeHoursWeatherInfo(item));
                }
            }
        }

        [XmlElement("forecast")]
        public List<ThreeHoursWeatherInfo> Forecast { get; private set; }
    }
}