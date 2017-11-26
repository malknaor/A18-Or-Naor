using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class DailyWeatherData
    {
        public string Location { get; private set; }

        [XmlElement("forecast")]
        public List<ThreeHoursWeatherData> Forecast { get; private set; }
        
        private readonly string r_DesiredWeatherTime = "18:00:00";

        public DailyWeatherData(XmlNode i_XmlNode)
        {
            XmlNode temp_node = i_XmlNode.SelectSingleNode("location");
            XmlAttribute temp_value;

            Location = temp_node.SelectSingleNode("name").InnerText;
            Forecast = new List<ThreeHoursWeatherData>();
            temp_node = i_XmlNode.SelectSingleNode("forecast");

            foreach (XmlNode item in temp_node)
            {
                temp_value = item.Attributes["from"];

                if (temp_value.Value.Contains(r_DesiredWeatherTime))
                {
                    Forecast.Add(new ThreeHoursWeatherData(item));
                }
            }
        }
    }
}