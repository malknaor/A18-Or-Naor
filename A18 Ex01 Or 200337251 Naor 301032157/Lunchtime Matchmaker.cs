using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class LunchTimeMatchmaker
    {

        public List<User> Colleagues { get; set; }
        public List<Page> UserLikedRestaurants { get; set; }
        public List<Page> commonLikedRestaurants { get; set; }
        public LunchTimeMatchmaker()
        {
            Colleagues = new List<User>();
            fetchUserColleagues();
            buildUserLikedRestaurantList();
            buildCommonRestaurantsList();
        }

        private void fetchUserColleagues()
        {
            foreach (User friend in LogicManager.LoggedInUser.Friends)
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
                   i_friend.WorkExperiences[0].Employer.Name == LogicManager.LoggedInUser.WorkExperiences[0].Employer.Name;
        }

        public void buildCommonRestaurantsList()
        {
            commonLikedRestaurants = UserLikedRestaurants;
            foreach (User colleague in Colleagues)
            {
                commonLikedRestaurants = commonLikedRestaurants.Intersect(colleague.LikedPages).ToList();
            }
            //     return commonLikedRestaurants.ToList();
        }
        private void buildUserLikedRestaurantList()
        {
            UserLikedRestaurants = new List<Page>();
            foreach (Page page in LogicManager.LoggedInUser.LikedPages)
            {
                if (page.Category.Contains("Restaurant") || page.Category.Contains("restaurant")) // $TODO - method.
                {
                    UserLikedRestaurants.Add(page);
                }
            }
        }
    }
}

    

