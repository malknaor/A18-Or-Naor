using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;
using AppLogic;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public class LunchTimeMatchmaker
    {
        public List<User> Colleagues { get; private set; }

        public List<Page> UserLikedRestaurants { get; private set; }

        public List<string> CommonLikedRestaurants { get; private set; }

        // Trying to enhance the feature:

        public List<Page> UserInterests { get; private set; } // Liked collections.

        public List<string> CommonInterests { get; private set; } // Common Liked collections.



        public List<User> Friends { get; set; }

        public LunchTimeMatchmaker()
        {
            Colleagues = new List<User>();
            fetchUserColleagues();
            buildUserLikedRestaurantList();
            buildCommonRestaurantsList();
        }

        #region Trying to enhance the feature

        private void BuildUserList()
        {
            Friends = new List<User>();
            buildSelectedFriendList();
            buildUserLikedRestaurantList();
            buildCommonRestaurantsList();
        }

        private void buildSelectedFriendList()
        {
            // TODO - 2 way Data Binding with the "Friends" Listbox.
            foreach (User friend in Session.Instance.LoggedInUser.Friends)
            {
                if (wasSelectedByUser(friend)) // TODO
                {
                    Friends.Add(friend);
                }
            }
        }

        //TODO
        private bool wasSelectedByUser(User friend)
        {
            return true;
        }

        //private void buildUserInterests()
        //{
        //    CommonInterests = new List<string>();

            
  

        //    foreach (FacebookObject in FacebookObjectCollection
        //    {
        //        if (page.Category.Contains("Restaurant") || page.Category.Contains("restaurant"))
        //        {
        //            UserLikedRestaurants.Add(page);
        //        }
        //    }
        //}

        //TODO
        private object selectInterest()
        {
            object obj = new FacebookObjectCollection<Page>();

            if (obj is FacebookObjectCollection<Page>)
            {
                obj = Session.Instance.LoggedInUser.LikedPages;
            }
            else if (obj is FacebookObjectCollection<Event>)
            {
                obj = Session.Instance.LoggedInUser.Events;
            }
            else if (obj is FacebookObjectCollection<Checkin>)
            {
                obj = Session.Instance.LoggedInUser.Checkins;
            }
            else
            {
                throw new System.Exception("Error in selectIntrest method. Wrong Type. Expceted : Likes, Events, Checkin");
            }

            return obj;
        }






        #endregion

        private void fetchUserColleagues()
        {
            foreach (User friend in Session.Instance.LoggedInUser.Friends)
            {
                if (isColleague(friend))
                {
                    Colleagues.Add(friend);
                }
            }
        }

        private bool isColleague(User i_friend)
        {
            return i_friend.WorkExperiences != null &&
                   (i_friend.WorkExperiences[0].Employer.Name == Session.Instance.LoggedInUser.WorkExperiences[0].Employer.Name
                   || Session.Instance.LoggedInUser.WorkExperiences[0].Employer.Name.Contains(i_friend.WorkExperiences[0].Employer.Name));
        }

        private void buildCommonRestaurantsList()
        {
            CommonLikedRestaurants = UserLikedRestaurants.Select(s1 => s1.Name).ToList();

            foreach (User colleague in Colleagues)
            {
                if (UserLikedRestaurants.Count() == 0)
                {
                    break;
                }

                CommonLikedRestaurants = CommonLikedRestaurants.Intersect(colleague.LikedPages.Select(s2 => s2.Name).ToList()).ToList();
            }
        }

        private void buildUserLikedRestaurantList()
        {
            UserLikedRestaurants = new List<Page>();

            foreach (Page page in Session.Instance.LoggedInUser.LikedPages)
            {
                if (page.Category.Contains("Restaurant") || page.Category.Contains("restaurant"))
                {
                    UserLikedRestaurants.Add(page);
                }
            }
        }
    }
}
