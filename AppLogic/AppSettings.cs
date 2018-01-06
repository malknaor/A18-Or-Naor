using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System;
using AppLogic;
using System.Reflection;

namespace A18_Ex02_Or_200337251_Naor_301032157
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

        private void LoadFromFile()
        {
            AppSettings appSettingsObj = new AppSettings();
            Type typeOfMe = this.GetType();

            using (Stream stream = new FileStream(k_RelativePath, FileMode.Open))
            {
                XmlSerializer deSerializer = new XmlSerializer(this.GetType());
                appSettingsObj = deSerializer.Deserialize(stream) as AppSettings;

                this.LastAccessToken = appSettingsObj.LastAccessToken;
                this.LastWindowLocation = appSettingsObj.LastWindowLocation;
                this.LastWindowSize = appSettingsObj.LastWindowSize;

                //foreach (PropertyInfo propInfo in typeOfMe.GetProperties())
                //{

                // appSettingsObj typeOfMe.GetProperty( (propInfo.ToString()) = propInfo.GetValue();  
                //}
            }
        }

        public void LoadDefaultSettings()
        {
            if (File.Exists(k_RelativePath))
            {
                File.Delete(k_RelativePath);
            }

            initDefaultSettings();
        }

        private AppSettings()
        {
            initDefaultSettings();

            if (File.Exists(k_RelativePath))
            {
                LoadFromFile();
            }
        }

        private void initDefaultSettings()
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