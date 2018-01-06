using System.Xml;
using System.Net;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public static class WeatherAPI
    {

        // Remove This before submiting!!!
        // DAily is an aggregation of 3hour forcast - they both are forcast.
        private const string k_APIKey = "4a3c854a9b4225b169858c753b6374a3";

        private static string m_CurrentURL;

        private static XmlDocument m_XMLDocument;

        public static WeeklyForecast GetCityForecast(string i_City)
        {
            WeeklyForecast forecast;

            m_CurrentURL = setCurrentURL(i_City);
            m_XMLDocument = getXmlDocument(m_CurrentURL);

            XmlNode xmlNode = m_XMLDocument.SelectSingleNode("weatherdata");
            forecast = new WeeklyForecast(xmlNode);

            return forecast;
        }

        private static string setCurrentURL(string i_City)
        {
            return "http://api.openweathermap.org/data/2.5/forecast?q=" + i_City + "&mode=xml&units=metric&APPID=" + k_APIKey;
        }

        private static XmlDocument getXmlDocument(string i_CurrentURL)
        {
            XmlDocument xmlDocument;

            using (WebClient webClient = new WebClient())
            {
                string xmlContent = webClient.DownloadString(i_CurrentURL);
                xmlDocument = new XmlDocument();

                xmlDocument.LoadXml(xmlContent);
            }

            return xmlDocument;
        }
    }
}
