using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public class Session
    {
        public static Session Instance
        {
            get
            {
                return Singleton<Session>.Instance;
            }
        }
      
        public LoginResult LoginResult { get; set; }

        public User LoggedInUser { get; set; }

        public string AppID { get; set; }

        private Session()
        {
            init();
        }

        private void init()
        {
            AppID = "495417090841854";
        }
    }
}
