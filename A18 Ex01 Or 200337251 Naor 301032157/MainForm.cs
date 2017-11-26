﻿using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A18_Ex01_Or_200337251_Naor_301032157
{
    public partial class MainForm : Form
    {
        private AppLogic m_AppLogic;

        private const string k_SportInfo = @"How To Use:
1.Select Activity.
2.Add Friends (by double click).
3.Type in the City.
4.Get Forecast (5 Days Forecast).
5.Select the desired day (by double click)
6.Post Activity.";

        public MainForm()
        {
            InitializeComponent();
            m_AppLogic = new AppLogic();
            init();
        }

        private void init()
        {
            StartPosition = FormStartPosition.Manual;
            FacebookService.s_CollectionLimit = 100;
            FacebookService.s_FbApiVersion = 2.8f;

            if (m_AppLogic.AppSettings.RememberUser)
            {
                loadUIAppSettings();
            }
        }

        private void loadUIAppSettings()
        {
            Size = m_AppLogic.AppSettings.LastWindowSize;
            Location = m_AppLogic.AppSettings.LastWindowLocation;
            checkBoxRememberUser.Checked = m_AppLogic.AppSettings.RememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (m_AppLogic.AppSettings.RememberUser && !string.IsNullOrEmpty(m_AppLogic.AppSettings.LastAccessToken))
            {
                m_AppLogic.LoginToFacebook();
                doAfterLogin();
            }
        }

        private void doAfterLogin()
        {
            if (AppLogic.LoggedInUser != null)
            {
                buttonLogout.Enabled = true;
                buttonUserLogin.Enabled = false;
                tabControlFeatures.Enabled = true;
            }

            new Thread(m_AppLogic.LoadFBCollectionsCache).Start();
            fetchFriends();
            populateUIBasicFacebookData();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (checkBoxRememberUser.Checked)
            {
                saveUserSettings();
            }
        }

        private void saveUserSettings()
        {
            m_AppLogic.AppSettings.LastWindowLocation = this.Location;
            m_AppLogic.AppSettings.LastWindowSize = this.Size;
            m_AppLogic.AppSettings.RememberUser = this.checkBoxRememberUser.Checked;
            m_AppLogic.AppSettings.LastAccessToken = AppLogic.LoginResult.AccessToken;

            m_AppLogic.AppSettings.SaveToFile();
        }

        private void populateUIBasicFacebookData()
        {
            displayUserInfo();
            fetchFriends();
            fetchEvents();
            fetchLikedPages();
            fetchCheckins();
            fetchPosts();
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            m_AppLogic.LoginToFacebook();
            doAfterLogin();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (AppLogic.LoggedInUser != null)
            {
                FacebookService.Logout(null);
                buttonUserLogin.Enabled = true;
                tabControlFeatures.Enabled = false;

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
            listBoxFriendsSelect.Items.Clear();
            pictureBoxFriends.Image = null;
            pictureBoxProfile.Image = null;
        }

        #region Basic Facebook Experience

        private void displayUserInfo()
        {
            this.Text = "Connected as: " + AppLogic.LoggedInUser.Name;
            pictureBoxProfile.LoadAsync(AppLogic.LoggedInUser.PictureLargeURL);
            labelUserName.Text = AppLogic.LoggedInUser.Name;
        }

        private void fetchFriends()
        {
            listBoxFriendsList.Items.Clear();
            listBoxFriendsList.DisplayMember = "Name";
            listBoxFriendsSelect.Items.Clear();
            listBoxFriendsSelect.DisplayMember = "Name";

            foreach (User friend in AppLogic.LoggedInUser.Friends)
            {
                listBoxFriendsList.Items.Add(friend);
                listBoxFriendsSelect.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (AppLogic.LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("You have no friends. Life Sucks.");
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
                User selectedFriend = listBoxFriendsList.SelectedItem as User;

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

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            foreach (Page page in AppLogic.LoggedInUser.LikedPages)
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

        private void fetchCheckins()
        {
            foreach (Checkin checkin in AppLogic.LoggedInUser.Checkins)
            {
                listBoxCheckins.Items.Add(checkin.Place.Name);
            }

            if (AppLogic.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status status = AppLogic.LoggedInUser.PostStatus(textBoxPostStatus.Text);
            MessageBox.Show("Status posted! ID : " + status.Id);
            textBoxPostStatus.Text = string.Empty;
        }

        private void fetchPosts()
        {
            foreach (Post post in AppLogic.LoggedInUser.Posts)
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

            if (AppLogic.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";

            foreach (Event fbEvent in AppLogic.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent);
            }

            if (AppLogic.LoggedInUser.Events.Count == 0)
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
        #endregion

        #region Lunch Time Tab

        private void buttonListRestaurantPages_Click(object sender, EventArgs e)
        {
            populateCommonRestaurants();
        }

        private void populateColleagues()
        {
            listBoxColleagues.Items.Clear();
            foreach (User colleague in m_AppLogic.LunchTimeMatchmaker.Colleagues)
            {
                listBoxColleagues.Items.Add(colleague.Name);
            }

            if (m_AppLogic.LunchTimeMatchmaker.Colleagues.Count() == 0)
            {
                MessageBox.Show("No Colleagues to retrive :(");
            }
        }

        private void populateUserLikedRestaurants()
        {
            listBoxUserLikedRestaurants.Items.Clear();
            foreach (Page restaurant in m_AppLogic.LunchTimeMatchmaker.UserLikedRestaurants)
            {
                listBoxUserLikedRestaurants.Items.Add(restaurant.Name);
            }

            if (m_AppLogic.LunchTimeMatchmaker.UserLikedRestaurants.Count() == 0)
            {
                MessageBox.Show("No Liked Restaurants. You should go out more :)");
            }
        }

        private void populateCommonRestaurants()
        {
            listboxCommonRestaurants.Items.Clear();
            foreach (string restaurantName in m_AppLogic.LunchTimeMatchmaker.CommonLikedRestaurants)
            {
                listboxCommonRestaurants.Items.Add(restaurantName);
            }

            if (m_AppLogic.LunchTimeMatchmaker.CommonLikedRestaurants.Count() == 0)
            {
                MessageBox.Show("No common restaurants to retrive :(");
            }
        }

        #endregion

        #region Sports Planner Tab

        private void fillCategoryComboBox()
        {
            string[] Activity = { "BasketBall", "FootBall", "Tennis", "Running", "Walking", "Cycling", "Surfing", "Swimming", "Climbing" };

            foreach (string Act in Activity)
            {
                comboBoxActivity.Items.Add(Act);
            }
        }

        private void buttonGetForecast_Click(object sender, EventArgs e)
        {
            DailyWeatherInfo currentWeatherInfo = m_AppLogic.SportsPlanner.GetWeatherInfo(textBoxCity.Text);

            foreach (ThreeHoursWeatherInfo item in currentWeatherInfo.Forecast)
            {
                listBoxWeatherData.Items.Add(currentWeatherInfo.Location + ": " + item.ToString());
            }
        }

        private void tabControlFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((sender as TabControl).SelectedIndex == 1)
            {
                m_AppLogic.InitLunchTime();
                populateColleagues();
                populateUserLikedRestaurants();
            }
            else if((sender as TabControl).SelectedIndex == 2)
            {
                m_AppLogic.InitSportsPlanner();
                fillCategoryComboBox();
                labelSportPlanner.Text = k_SportInfo;
            }
        }

        private void comboBoxActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            textBoxActivityPost.Text = string.Empty;
            textBoxActivityPost.Text = textBoxActivityPost.Text + comboBox.SelectedItem.ToString() + ": ";
        }

        private void buttonShareActivity_Click(object sender, EventArgs e)
        {
            Status status = AppLogic.LoggedInUser.PostStatus(textBoxActivityPost.Text);
            MessageBox.Show("Activity posted! ID : " + status.Id);
            textBoxActivityPost.Text = string.Empty;
        }

        private void listBoxFriendsSelect_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            
            if (!textBoxActivityPost.Text.Contains(listBox.SelectedItem.ToString()))
            {
                textBoxActivityPost.Text = textBoxActivityPost.Text + (listBox.SelectedItem as User).Name + ", ";
            }
        }

        private void listBoxWeatherData_DoubleClick(object sender, EventArgs e)
        {
            textBoxActivityPost.Text = textBoxActivityPost.Text + Environment.NewLine + "In - " + (sender as ListBox).SelectedItem.ToString();
        }

        #endregion
    }
}