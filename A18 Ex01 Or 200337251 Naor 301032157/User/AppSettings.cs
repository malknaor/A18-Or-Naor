using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class AppSettings
    {
        public Point LastWindowLocation{ get; set; }
        public Size LastWindowSize { get; set; }
        public string LastAccessToken { get; set; }
        public bool RememberUser { get; set; }

        private AppSettings()
        {
            LastAccessToken = null;
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1100, 600);
            RememberUser = false;       
        }

        public void SaveToFile()
        {
            // Something can always happen here, so try catch... the exeption will be thrown to whoever can catch it.
            //Try finally dispose.                      
            using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
        public static AppSettings LoadFromFile()
        {
            // $TODO - app settings clip 1:17:02 - default values.
            AppSettings appSettingsObj = new AppSettings();
            if (File.Exists(@"D:\appSettings.xml"))
            {
                using (Stream stream = new FileStream(@"D:\appSettings.xml", FileMode.Open))
                {
                    XmlSerializer deSerializer = new XmlSerializer(typeof(AppSettings));
                    appSettingsObj = deSerializer.Deserialize(stream) as AppSettings;
                }
            }
            return appSettingsObj;
        }
    }
}
