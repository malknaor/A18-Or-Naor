using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public static class WeatherAPI //this class should be a static
    {
        const string k_APIKey = "4a3c854a9b4225b169858c753b6374a3";

        private static string CurrentUrl { get; set; }

        private static XmlDocument XMLDocument { get; set; }

        static WeatherAPI()
        {
        }

        public static DailyWeatherInfo GetCityForecast(string i_City) //GetForecast
        {
            CurrentUrl = setCurrentURL(i_City);
            XMLDocument = getXmlDocument(CurrentUrl);

            XmlNode xmlNode = XMLDocument.SelectSingleNode("weatherdata"); 
            DailyWeatherInfo forecast = new DailyWeatherInfo(xmlNode); //Change this
            
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
