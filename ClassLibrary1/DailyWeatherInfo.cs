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

        [XmlElement("forecast")]
        public List<ThreeHoursWeatherInfo> Forecast { get; private set; }

        public DailyWeatherInfo(XmlNode i_XmlNode)
        {
            string DesiredTime = "18:00:00";
            XmlNode temp_node = i_XmlNode.SelectSingleNode("location");
            XmlAttribute temp_value;

            Location = temp_node.SelectSingleNode("name").InnerText;
            Forecast = new List<ThreeHoursWeatherInfo>();
            temp_node = i_XmlNode.SelectSingleNode("forecast");

            foreach (XmlNode item in temp_node)
            {
                temp_value = item.Attributes["from"];

                if (temp_value.Value.Contains(DesiredTime))
                {
                    Forecast.Add(new ThreeHoursWeatherInfo(item));
                }
            }
        }
    }
}