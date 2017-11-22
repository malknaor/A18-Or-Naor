using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

// $TODO - Need to disable the logout method.
namespace A18_Ex01_Or_200337251_Naor_301032157
{
    //$TODO - Naming conventions for forms??
    public partial class MainForm : Form
    {
        private LogicManager m_AppLogic;
        private AppSettings m_AppSettings;
        private const string k_AppID = "495417090841854";

        public MainForm()
        {
            InitializeComponent();
            m_AppLogic = new LogicManager();
            this.StartPosition = FormStartPosition.Manual;
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
          
            m_AppSettings = AppSettings.LoadFromFile();
            loadUIAppSettings();
        }
        //$TODO - AppUIUtils
        private void loadUIAppSettings()
        {
            this.Size = m_AppSettings.LastWindowSize;
            this.Location = m_AppSettings.LastWindowLocation;
            this.checkBoxRememberUser.Checked = m_AppSettings.RememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            LogicManager.LoginOrConnect();
            fetchFriends();

            // populateUIFromFacebookData();
            // m_AppSettings.LoadFromFile();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            saveUserSettings();
            m_AppSettings.SaveToFile();
            //Should be wrapped by the logic class.
            FacebookService.Logout(null);
        }
        private void saveUserSettings()
        {
            //Save UI Settings
            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            m_AppSettings.RememberUser = this.checkBoxRememberUser.Checked;

            // Save Logic Settings
            if (m_AppSettings.RememberUser)
            {
                m_AppSettings.LastAccessToken = LogicManager.LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }
        }

        //$ should be moved to a UI class/Project.
        private void populateUIFromFacebookData()
        {

            displayUserInfo();
            fetchFriends();
        ;
        }
        private void buttonUserLogin_Click(object sender, EventArgs e)
        {

            LogicManager.LoginOrConnect();
            if (LogicManager.LoggedInUser != null)
            {
                buttonLogout.Enabled = true;
                buttonUserLogin.Enabled = false;
            }
            new Thread(LogicManager.LoadFriendsCache).Start();
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
            
        }

        private void displayUserInfo()
        {
            this.Text = "Connected as: " + LogicManager.LoggedInUser.Name;
            pictureBoxProfile.LoadAsync(LogicManager.LoggedInUser.PictureLargeURL);
            labelUserName.Text = LogicManager.LoggedInUser.Name;
        }

        private void fetchFriends()
        {
            listBoxFriendsList.Items.Clear();
            listBoxFriendsList.DisplayMember = "Name";
            listBoxFriendsSelect.Items.Clear();
            listBoxFriendsSelect.DisplayMember = "Name";

            foreach (User friend in LogicManager.LoggedInUser.Friends)
            {
                listBoxFriendsList.Items.Add(friend);
                listBoxFriendsSelect.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (LogicManager.LoggedInUser.Friends.Count == 0)
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

            foreach (Page page in LogicManager.LoggedInUser.LikedPages)
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
        private void getCommonResuaurants()
        {
            List<Page> commonResaurants = LogicManager.GetCommonRestaurants();
            foreach (Page restaurant in commonResaurants)
            {
                listboxCommonRestaurants.Items.Add(restaurant.Name);
            }
            if(commonResaurants.Count() == 0)
            {
                MessageBox.Show("No common restaurants to retrieve :(");
            }
        }

        //Checkins List//
        private void buttonFetchCheckins_Click(object sender, EventArgs e)
        {
            fetchCheckins();
        }

        private void fetchCheckins()
        {
            foreach (Checkin checkin in LogicManager.LoggedInUser.Checkins)
            {
                listBoxCheckins.Items.Add(checkin.Place.Name);
            }

            if (LogicManager.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
        }

        //private void fetchCollection(FacebookObjectCollection<T> i_Collection)
        //{
        //    foreach (FacebookObject facebookObj in i_Collection)
        //    {
        //        listBoxCheckins.Items.Add(checkin.Place.Name);
        //    }

        //    if (LogicManager.LoggedInUser.Checkins.Count == 0)
        //    {
        //        MessageBox.Show("No Checkins to retrieve :(");
        //    }
        //}




        //Status update//
        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status status = LogicManager.LoggedInUser.PostStatus(textBoxPostStatus.Text);
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
            foreach (Post post in LogicManager.LoggedInUser.Posts)
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

            if (LogicManager.LoggedInUser.Posts.Count == 0)
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

            foreach (Event fbEvent in LogicManager.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (LogicManager.LoggedInUser.Events.Count == 0)
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
            if (LogicManager.LoggedInUser != null)
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
            getCommonResuaurants();

        }

        private void buttonGetcolleagues_Click(object sender, EventArgs e)
        {
            fetchColleagues();
        }
        // $TODO - Move to Logic.
        private void fetchColleagues()
        {
            foreach (FacebookWrapper.ObjectModel.User friend in LogicManager.LoggedInUser.Friends)
            {   //$TODO - Should be appuser, not facebook user. also checking sould be done in logic.

                if (friend.WorkExperiences != null)
                {
                    if(friend.WorkExperiences[0].Employer.Name == LogicManager.LoggedInUser.WorkExperiences[0].Employer.Name)
                    {
                        listBoxColleagues.Items.Add(friend.Name);
                        //Add to Colleagues collection. array of iColleuge

                    }
                }
            }

            if (LogicManager.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }

        }

       
    }
}
