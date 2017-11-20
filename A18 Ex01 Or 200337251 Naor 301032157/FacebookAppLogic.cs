﻿using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    // $TODO - auto properties.
    class FacebookAppLogic
    {
        private const string k_AppID = "495417090841854";

         private static FacebookWrapper.ObjectModel.User m_LoggedInUser; // TODO - this should be removed, and is here for testing. all relevant info should be in FacebookAppUser.
         private static FacebookAppUser m_AppUser;
        public static LoginResult LoginResult { get; set; }
        private static string s_AccessToken;
        public int MyProperty { get; set; }

        public static FacebookWrapper.ObjectModel.User LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public static FacebookAppUser AppUser
        {
                get
            {
                return m_AppUser;
            }
        }

        static FacebookAppLogic()
        {
        //    m_LoggedInUser = new FacebookWrapper.ObjectModel.User();
        }

        public static void LoginAndInit()
        {
            /// Owner: design.patterns

            /// Use the FacebookService.Login method to display the login form to any user who wish to use this application.
            /// You can then save the result.AccessToken for future auto-connect to this user:
            if(string.IsNullOrEmpty(s_AccessToken))
            {
                LoginResult = FacebookService.Login(k_AppID, /// (desig patter's "Design Patterns Course App 2.4" app)
                "public_profile",
             "user_education_history",
             "user_birthday",
             "user_actions.video",
             "user_actions.news",
             "user_actions.music",
             "user_actions.fitness",
             "user_actions.books",
             "user_about_me",
             "user_friends",
             "publish_actions",
             "user_events",
             "user_games_activity",
             //"user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
             "user_hometown",
             "user_likes",
             "user_location",
             "user_managed_groups",
             "user_photos",
             "user_posts",
             "user_relationships",
             "user_relationship_details",
             "user_religion_politics",

             //"user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
             "user_tagged_places",
             "user_videos",
             "user_website",
             "user_work_history",
             "read_custom_friendlists",

             // "read_mailbox", (This permission is only available for apps using Graph API version v2.3 or older.)
             "read_page_mailboxes",
             // "read_stream", (This permission is only available for apps using Graph API version v2.3 or older.)
             // "manage_notifications", (This permission is only available for apps using Graph API version v2.3 or older.)
             "manage_pages",
             "publish_pages",
             "publish_actions",

             "rsvp_event"
             );
                // These are NOT the complete list of permissions. Other permissions for example:
                // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
                // The documentation regarding facebook login and permissions can be found here: 
                // https://developers.facebook.com/docs/facebook-login/permissions#reference

            }
            else
            {
                LoginResult = FacebookService.Connect(s_AccessToken);
            }


            if (!string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                m_LoggedInUser = LoginResult.LoggedInUser; // TODO - remove.
                m_AppUser = new FacebookAppUser(LoginResult.LoggedInUser);
             //   popolateFacebookData();
            }
            else
            {
                //$TODO - Maybe catch?
              //  MessageBox.Show(result.ErrorMessage);
            }
        }

    
    }
}