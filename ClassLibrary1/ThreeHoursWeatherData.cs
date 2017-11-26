using System;
using System.Xml;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class ThreeHoursWeatherData
    {
        public DateTime DateAndTime { get; private set; }

        public float Temperture { get; private set; }

        public string WeatherDescription { get; private set; }

        public ThreeHoursWeatherData(XmlNode i_XmlDoc)
        {
            XmlNode temp_node = i_XmlDoc;
            XmlAttribute temp_value = temp_node.Attributes["from"];
            string dateTime = temp_value.Value;

            dateTime = dateTime.Replace("T", " ");

            DateAndTime = DateTime.Parse(dateTime);
            temp_node = i_XmlDoc.SelectSingleNode("temperature");
            temp_value = temp_node.Attributes["value"];
            Temperture = float.Parse(temp_value.Value);
            temp_node = i_XmlDoc.SelectSingleNode("symbol");
            temp_value = temp_node.Attributes["name"];
            WeatherDescription = temp_value.Value;
        }

        public override string ToString()
        {
            return DateAndTime.ToString() + ", " + Temperture.ToString() + ", " + WeatherDescription + ".";
        }
    }
}
