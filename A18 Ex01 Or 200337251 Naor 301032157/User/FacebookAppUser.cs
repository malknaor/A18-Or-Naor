using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    class FacebookAppUser
    {
        public string Name { get; set; }
        public string PictureURL { get; set; }

        public List<Page> LikedRestaurants { get; set; }

        public FacebookAppUser(FacebookWrapper.ObjectModel.User i_LoggedInUser)
        {
            Name = i_LoggedInUser.Name;
            PictureURL = i_LoggedInUser.PictureNormalURL;
        }
    }
}

