using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System;
using AppLogic;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class AppSettings
    {
        private const string k_RelativePath = @".\appSettings.xml";

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public string LastAccessToken { get; set; }

        public bool RememberUser { get; set; }

        public static AppSettings Instance
        {
            get { return Singleton<AppSettings>.Instance; }
        }

        public AppSettings LoadFromFile()
        {
            AppSettings appSettingsObj = new AppSettings();

            if (File.Exists(k_RelativePath))
            {
                using (Stream stream = new FileStream(k_RelativePath, FileMode.Open))
                {
                    XmlSerializer deSerializer = new XmlSerializer(typeof(AppSettings));
                    appSettingsObj = deSerializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettingsObj;
        }

        public AppSettings ClearSettings()
        {
            if (File.Exists(k_RelativePath))
            {
                File.Delete(k_RelativePath);
            }

            return LoadFromFile();
        }

        private AppSettings()
        {
            LastAccessToken = null;
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1100, 600);
            RememberUser = false;
        }

        public void SaveToFile()
        {
            if (!File.Exists(k_RelativePath))
            {
                File.Create(k_RelativePath).Dispose();
            }

            using (Stream stream = new FileStream(k_RelativePath, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}