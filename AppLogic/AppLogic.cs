using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class AppLogic
    {
        public static LoginResult LoginResult { get; set; }

        public static User LoggedInUser { get; set; }

        public string AppID { get; set; }

        public AppSettings AppSettings { get; set; }

        public LunchTimeMatchmaker LunchTimeMatchmaker { get; private set; }

        public SportsActivityPlanner SportsActivityPlanner { get; private set; }

        public AppLogic()
        {
            AppSettings = AppSettings.LoadFromFile();
            AppID = "495417090841854";
        }

        public void InitLunchTime()
        {
            LunchTimeMatchmaker = new LunchTimeMatchmaker();
        }

        public void InitSportsActivityPlanner()
        {
            SportsActivityPlanner = new SportsActivityPlanner();
        }

        public void LoginToFacebook()
        {
            if (string.IsNullOrEmpty(AppSettings.LastAccessToken))
            {
                LoginResult = FacebookService.Login(
                    AppID,
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
             "user_hometown",
             "user_likes",
             "user_location",
             "user_managed_groups",
             "user_photos",
             "user_posts",
             "user_relationships",
             "user_relationship_details",
             "user_religion_politics",
             "user_tagged_places",
             "user_videos",
             "user_website",
             "user_work_history",
             "read_custom_friendlists",
             "read_page_mailboxes",
             "manage_pages",
             "publish_pages",
             "publish_actions",
             "rsvp_event");
            }
            else
            {
                LoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
            }

            LoggedInUser = LoginResult.LoggedInUser;
        }

        public void LoadFBCollectionsCache()
        {
            FacebookObjectCollection<User> FriendsCache = LoggedInUser.Friends;
            FacebookObjectCollection<Event> EventsCache = LoggedInUser.Events;
            FacebookObjectCollection<Post> PostsCache = LoggedInUser.Posts;
            FacebookObjectCollection<Checkin> CheckinsCache = LoggedInUser.Checkins;
        }

        public void ClearUserSettings()
        {
            AppSettings = AppSettings.ClearSettings();
        }
    }
}
