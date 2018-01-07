using System.Reflection;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;
using System;
using AppLogic;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class AppSettings
    {
        public static AppSettings Instance
        {
            get { return Singleton<AppSettings>.Instance; }
        }

        private const string k_RelativePath = @".\appSettings.xml";

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public string LastAccessToken { get; set; }

        public bool RememberUser { get; set; }

        public void LoadFromFile()
        {
            AppSettings appSettingsObj = null;

            if (File.Exists(k_RelativePath))
            {
                using (Stream stream = new FileStream(k_RelativePath, FileMode.Open))
                {
                    XmlSerializer deSerializer = new XmlSerializer(typeof(AppSettings));
                    appSettingsObj = deSerializer.Deserialize(stream) as AppSettings;
                }
            }

            loadSettingsToInstace(appSettingsObj, this);
        }

        private void loadSettingsToInstace(AppSettings i_CopyFromObject, AppSettings i_CopyToObject)
        {
            foreach (PropertyInfo sourcePropertyInfo in i_CopyFromObject.GetType().GetProperties())
            {
                if (sourcePropertyInfo.Name == "Instance")
                {
                    break;
                }

                PropertyInfo destPropertyInfo = i_CopyToObject.GetType().GetProperty(sourcePropertyInfo.Name);

                destPropertyInfo.SetValue(
                    i_CopyToObject,
                    sourcePropertyInfo.GetValue(i_CopyFromObject, null),
                    null);
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