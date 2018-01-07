using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public class Session
    {
        public static int Count { get; private set; }

        public static Session Instance
        {
            get
            {
                if (Count > 1)
                {
                    throw new Exception("For Singleton debugging. More than one instance created");
                }

                return Singleton<Session>.Instance;
            }
        }
      
        public LoginResult LoginResult { get; set; }

        public User LoggedInUser { get; set; }

        public string AppID { get; set; }

        private Session()
        {
            init();

            Count++;
        }

        private void init()
        {
            AppID = "495417090841854";
        }
    }
}
