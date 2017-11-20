using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class AppSettings
    {
        public Point LastWindowLocation{ get; set; }
        public Size LastWindowSize { get; set; }
        public string LastAccessToken { get; set; }
        public bool RememberUser { get; set; }

        public AppSettings()
        {
            LastAccessToken = null;
            LastWindowLocation = new Point(20, 50);
            LastWindowSize = new Size(1100, 600);
            RememberUser = false;       
        }

        public void SaveToFile()
        {

        }

        public void LoadFromFile()
        {

        }
    }
}
