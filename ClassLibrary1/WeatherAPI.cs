using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public static class WeatherAPI
    {
        private const string k_APIKey = "4a3c854a9b4225b169858c753b6374a3";

        private static string CurrentURL { get; set; }

        private static XmlDocument XMLDocument { get; set; }

        public static DailyWeatherData GetCityForecast(string i_City) 
        {
            CurrentURL = setCurrentURL(i_City);
            XMLDocument = getXmlDocument(CurrentURL);

            XmlNode xmlNode = XMLDocument.SelectSingleNode("weatherdata"); 
            DailyWeatherData forecast = new DailyWeatherData(xmlNode);
            
            return forecast;
        }

        private static string setCurrentURL(string i_City)
        {
            return "http://api.openweathermap.org/data/2.5/forecast?q=" + i_City + "&mode=xml&units=metric&APPID=" + k_APIKey;
        }

        private static XmlDocument getXmlDocument(string i_CurrentURL)
        {
            using (var webClient = new WebClient())
            {
                var xmlContent = webClient.DownloadString(i_CurrentURL);
                var xmlDocument = new XmlDocument();

                xmlDocument.LoadXml(xmlContent);

                return xmlDocument;
            }
        }
    }
}
