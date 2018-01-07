using AppLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class AppLogic
    {
        private Session m_Session;

        public LunchTimeMatchmaker LunchTimeMatchmaker { get; private set; }

        public SportsActivityPlannerFacade SportsActivityPlanner { get; private set; }

        public AppLogic()
        {
        }

        public void InitLunchTime()
        {
            LunchTimeMatchmaker = new LunchTimeMatchmaker();
        }

        public void InitSportsActivityPlanner()
        {
            SportsActivityPlanner = new SportsActivityPlannerFacade();
        }

        public void LoginToFacebook()
        {
            m_Session = Session.Instance;

            if (string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                m_Session.LoginResult = FacebookService.Login(
                    m_Session.AppID,
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
                m_Session.LoginResult = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
            }

            m_Session.LoggedInUser = m_Session.LoginResult.LoggedInUser;
        }

        public void LoadFBCollectionsCache()
        {
            FacebookObjectCollection<User> FriendsCache = m_Session.LoggedInUser.Friends;
            FacebookObjectCollection<Event> EventsCache = m_Session.LoggedInUser.Events;
            FacebookObjectCollection<Post> PostsCache = m_Session.LoggedInUser.Posts;
            FacebookObjectCollection<Checkin> CheckinsCache = m_Session.LoggedInUser.Checkins;
        }

        public void ClearUserSettings()
        {
            AppSettings.Instance.LoadDefaultSettings();
        }
    }
}
