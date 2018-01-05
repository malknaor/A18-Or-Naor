using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using A18_Ex01_Or_200337251_Naor_301032157;

namespace AppLogic
{
    public class Session
    {
        // Perhaps we should implement the facades as singletons?
        // Seems reasonable.
        public LoginResult LoginResult { get; set; }

        public User LoggedInUser { get; set; }

        public string AppID { get; set; }

        public AppSettings AppSettings { get; set; }

        // For debugging.
        public static int Count { get; private set; }


        private Session()
        {
            init();


            Count++;
        }

        private void init()
        {
            AppSettings = AppSettings.Instance;
            // This is guy's ID. need to pass as paramater.
            AppID = "495417090841854";
        }

        // Gets the single instance of SingleInstanceClass.
        public static Session Instance
        {
            get
            { //TODO Delete when done.
                if (Count > 1)
                {
                    throw new Exception("For Singleton debugging. More than one instance created");
                }
                return Singleton<Session>.Instance;
            }
        }
    }

}
