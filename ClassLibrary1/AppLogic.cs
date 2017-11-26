using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class AppLogic
    {
        private const string k_AppID1 = "495417090841854";

        private const string k_AppID2 = "1450160541956417";

        public static LoginResult LoginResult { get; set; }

        public AppSettings AppSettings { get; set; }

        public static User LoggedInUser { get; set; }

        public LunchTimeMatchmaker LunchTimeMatchmaker { get; private set; }

        public SportsPlanner SportsPlanner { get; private set; }

        public AppLogic()
        {
            AppSettings = AppSettings.LoadFromFile();
        }

        public void InitLunchTime()
        {
            LunchTimeMatchmaker = new LunchTimeMatchmaker();
        }

        public void InitSportsPlanner()
        {
            SportsPlanner = new SportsPlanner();
        }

        public void LoginToFacebook()
        {
            if(string.IsNullOrEmpty(AppSettings.LastAccessToken))
            {
                LoginResult = FacebookService.Login(k_AppID1 /*k_AppID2 - guy's app id*/,
                #region Permissions
             
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
             // "user_groups" (This permission is only available for apps using Graph API version v2.3 or older.)
             "user_hometown",
             "user_likes",
             "user_location",
             "user_managed_groups",
             "user_photos",
             "user_posts",
             "user_relationships",
             "user_relationship_details",
             "user_religion_politics",

             // "user_status" (This permission is only available for apps using Graph API version v2.3 or older.)
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

             "rsvp_event");
                #endregion
            }
            else
            {
                LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
            }

            if (LoginResult.FacebookOAuthResult.IsSuccess)
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }
            else
            {
                ///$TODO - Maybe catch?
                ///MessageBox.Show(result.ErrorMessage);
            }
        }

        public void LoadFBCollectionsCache()
        {
            FacebookObjectCollection<User> FriendsCache = LoggedInUser.Friends;
            FacebookObjectCollection<Event> EventsCache = LoggedInUser.Events;
            FacebookObjectCollection<Post> PostsCache = LoggedInUser.Posts;
            FacebookObjectCollection<Checkin> CheckinsCache = LoggedInUser.Checkins;
        }
    }
}
