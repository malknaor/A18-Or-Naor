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
            AppSettings = AppSettings.LoadFromFile();
            AppID = "495417090841854";
        }

        // Gets the single instance of SingleInstanceClass.
        public static Session Instance
        {
            get
            {
                if(Count > 1)
                {
                    throw new Exception("For Singleton debugging. More than one instance created");
                }
                return Singleton<Session>.Instance;
            }
        }    


    }

//    public class Singleton<T> where T : class, new()
//    {
//        Singleton() { }

//        class SingletonCreator
//        {
//            static SingletonCreator() { }
//            // Private object instantiated with private constructor
//            internal static readonly T instance = new T();
//        }

//        public static T Instance
//        {
//            get { return SingletonCreator.instance; }
//        }

//        // Calling the Singleton
//        // something = Singleton<Test1>.UniqueInstance;
//    }
}
