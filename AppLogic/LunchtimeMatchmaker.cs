﻿using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public class LunchTimeMatchmaker
    {
        public List<User> Colleagues { get; private set; }

        public List<Page> UserLikedRestaurants { get; private set; }

        public List<string> CommonLikedRestaurants { get; private set; }

        public LunchTimeMatchmaker()
        {
            Colleagues = new List<User>();
            fetchUserColleagues();
            buildUserLikedRestaurantList();
            buildCommonRestaurantsList();
        }

        private void fetchUserColleagues()
        {
            foreach (User friend in AppLogic.LoggedInUser.Friends)
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
                   (i_friend.WorkExperiences[0].Employer.Name == AppLogic.LoggedInUser.WorkExperiences[0].Employer.Name
                   || AppLogic.LoggedInUser.WorkExperiences[0].Employer.Name.Contains(i_friend.WorkExperiences[0].Employer.Name));
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

            foreach (Page page in AppLogic.LoggedInUser.LikedPages)
            {
                if (page.Category.Contains("Restaurant") || page.Category.Contains("restaurant"))
                {
                    UserLikedRestaurants.Add(page);
                }
            }
        }
    }
}