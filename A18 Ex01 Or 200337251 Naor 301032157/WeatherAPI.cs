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
        const string k_APIKey = "a97bacc661931455788ecb12098804f5";

        private static string CurrentUrl { get; set; }

        private static XmlDocument XMLDocument { get; set; }

        static WeatherAPI()
        {
        }

        public static float GetTemp(string i_City)
        {
                CurrentUrl = setCurrentURL(i_City);
                XMLDocument = getXmlDocument(CurrentUrl);

                XmlNode temp_node = XMLDocument.SelectSingleNode("//temperature");
                XmlAttribute temp_value = temp_node.Attributes["value"];
                string temp_string = temp_value.Value;

                return float.Parse(temp_string);
        }

        private static string setCurrentURL(string i_City)
        {
            string urlLink = "http://api.openweathermap.org/data/2.5/weather?q=" + i_City + "&mode=xml&units=metric&APPID=" + k_APIKey;

            return urlLink;
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
