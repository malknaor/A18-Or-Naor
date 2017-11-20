using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $TODO - Need to disable the logout method.
namespace A18_Ex01_Or_200337251_Naor_301032157
{


    //$TODO - Naming conventions for forms??
    public partial class FacebookAppDashboard : Form
    {
        private AppSettings m_AppSettings;
        private const string k_AppID = "495417090841854";

        public FacebookAppDashboard()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;

            m_AppSettings = AppSettings.LoadFromFile();
            loadUISettingsFromXML();
        }
        //TODO - AppUIUtils
        private void loadUISettingsFromXML()
        {
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            FacebookAppLogic.LoginAndInit();
            populateUIFromFacebookData();
            // m_AppSettings.LoadFromFile();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            saveUserSettings();
            m_AppSettings.SaveToFile();
        }

        private void saveUserSettings()
        {

            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
            if (m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = FacebookAppLogic.LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }
        }

        //$ should be moved to a UI class/Project.
        private void populateUIFromFacebookData()
        {
            this.Text = "You are now connected as" + FacebookAppLogic.AppUser.Name;
            displayUserInfo();
            fetchCheckins();
            fetchFriends();
            fetchEvents();
            fetchLikedPages();
            fetchPosts();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {

            FacebookAppLogic.LoginAndInit();
            if (FacebookAppLogic.AppUser != null)
            {
                buttonLogout.Enabled = true;
                buttonUserLogin.Enabled = false;
            }

            
            populateUIFromFacebookData();
        }



        private void pictureBoxProfilePhoto_Click(object sender, EventArgs e)
        {
            //if (LoggedInUser.Albums.Count > 0)
            //{
            //    //Auto generate picture to the user picture box from his albums, else do nothing
            //}
        }

        //Friends List//
        private void buttonFetchFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void displayUserInfo()
        {
            pictureBoxProfile.LoadAsync(FacebookAppLogic.AppUser.PictureURL);
            labelUserName.Text = FacebookAppLogic.AppUser.Name;
        }

        private void fetchFriends()
        {
            listBoxFriendsList.Items.Clear();
            listBoxFriendsList.DisplayMember = "Name";

            foreach (FacebookWrapper.ObjectModel.User friend in FacebookAppLogic.LoggedInUser.Friends)
            {
                listBoxFriendsList.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (FacebookAppLogic.LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends on the list, forever alone...");
            }
        }

        private void listBoxFriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedFriendsPicture();
        }

        private void showSelectedFriendsPicture()
        {
            if (listBoxFriendsList.SelectedItems.Count == 1)
            {
                FacebookWrapper.ObjectModel.User selectedFriend = listBoxFriendsList.SelectedItem as FacebookWrapper.ObjectModel.User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriends.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriends.Image = pictureBoxFriends.ErrorImage;
                }
            }
        }

        //Liked Pages List//
        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            foreach (Page page in FacebookAppLogic.LoggedInUser.LikedPages)
            {
                listBoxLikedPages.Items.Add(page);
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedPage();
        }

        private void showSelectedPage()
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                pictureBoxPages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        //$TODO - This should not be invoked by a control, only for testing...
        // Part of the Feature's Logic.,
        private void filterPagesByRestaurant()
        {
            List<Page> likedRestaurants = new List<Page>();

            //$DEBUG
            //List<string> allPagesCategoriesNames = new List<string>();

            foreach (Page page in FacebookAppLogic.LoggedInUser.LikedPages)
            {
                // $DEBUG
                //     allPagesCategoriesNames.Add(page.Category);

                if (page.Category.Contains("Restaurant") || page.Category.Contains("restaurant")) // $TODO - method.
                {
                    likedRestaurants.Add(page);
                }
            }

            return;

        }

        //Checkins List//
        private void buttonFetchCheckins_Click(object sender, EventArgs e)
        {
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in FacebookAppLogic.LoggedInUser.Checkins)
            {
                listBoxCheckins.Items.Add(checkin.Place.Name);
            }

            if (FacebookAppLogic.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
        }

        //Status update//
        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status status = FacebookAppLogic.LoggedInUser.PostStatus(textBoxPostStatus.Text);
            MessageBox.Show("Status posted! ID : " + status.Id);
            textBoxPostStatus.Text = string.Empty;
        }

        //User Posts List//
        private void buttonFetchPosts_Click(object sender, EventArgs e)
        {
            fetchPosts();
        }

        private void fetchPosts()
        {
            foreach (Post post in FacebookAppLogic.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (FacebookAppLogic.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        //Events List//
        private void buttonFetchEvents_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            foreach (Event fbEvent in FacebookAppLogic.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (FacebookAppLogic.LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No event is available!");
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSelectedEventPhoto();
        }

        private void showSelectedEventPhoto()
        {
            if (listBoxEvents.SelectedItems.Count == 1)
            {
                Event selectedEvent = listBoxEvents.SelectedItem as Event;
                pictureBoxEvents.LoadAsync(selectedEvent.PictureNormalURL);
            }
        }

        //Logout//
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (FacebookAppLogic.LoggedInUser != null)
            {
                FacebookService.Logout(null);
                buttonUserLogin.Enabled = true;
                resetFormControls();
            }
        }

        private void resetFormControls()
        {
            labelUserName.Text = string.Empty;
            listBoxFriendsList.Items.Clear();
            listBoxCheckins.Items.Clear();
            listBoxLikedPages.Items.Clear();
            listBoxEvents.Items.Clear();
            listBoxPosts.Items.Clear();
            pictureBoxProfile.Image = null;
        }

        private void buttonListRestaurantPages_Click(object sender, EventArgs e)
        {
            filterPagesByRestaurant();

        }
    }
}
