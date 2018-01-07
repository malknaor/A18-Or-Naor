using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using AppLogic;

namespace A18_Ex02_Or_200337251_Naor_301032157
{
    public partial class MainForm : Form
    {
        private const string k_AppID1 = "495417090841854";

        private const string k_AppID2 = "1450160541956417";

        private const string k_SportInfo = @"Instruction:
1.Select Activity.
2.Select The Time.
3.Add Friends (by double click).
3.Type in the City.
4.Get Forecast (5 Days Forecast).
5.Select the desired day (by double click)
6.Post Activity.";

        private AppLogic m_AppLogic;

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

            comboBoxAppID.Items.Add(k_AppID1);
            comboBoxAppID.Items.Add(k_AppID2);

            if (AppSettings.Instance.RememberUser)
            {
                loadUIAppSettings();
            }
        }

        private void loadUIAppSettings()
        { // TODO - UI manager facade??? or maybe to get rid of the app settings.
            Size = AppSettings.Instance.LastWindowSize;
            Location = AppSettings.Instance.LastWindowLocation;
            checkBoxRememberUser.Checked = AppSettings.Instance.RememberUser;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (AppSettings.Instance.RememberUser && !string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                m_AppLogic.LoginToFacebook();
                doAfterLogin();
            }
        }

        private void doAfterLogin()
        {
            if (Session.Instance.LoggedInUser != null)
            {
                buttonLogout.Enabled = true;
                buttonUserLogin.Enabled = false;
                tabControlFeatures.Enabled = true;
            }

            new Thread(populateUIBasicFacebookData).Start(); 
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
            AppSettings.Instance.LastWindowLocation = this.Location;
            AppSettings.Instance.LastWindowSize = this.Size;
            AppSettings.Instance.RememberUser = this.checkBoxRememberUser.Checked;
            AppSettings.Instance.LastAccessToken = Session.Instance.LoginResult.AccessToken;
            AppSettings.Instance.SaveToFile();
        }

        private void populateUIBasicFacebookData()
        {
            this.Invoke(new Action(displayUserInfo));
            new Thread(fetchFriends).Start();
            new Thread(fetchEvents).Start();
            new Thread(fetchLikedPages).Start();
            new Thread(fetchCheckins).Start();
            new Thread(fetchPosts).Start();             
        }

        private void buttonUserLogin_Click(object sender, EventArgs e)
        {
            m_AppLogic.LoginToFacebook();
            doAfterLogin();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (Session.Instance.LoggedInUser != null)
            {
                // TODO - Should this be inside the Session class?
                FacebookService.Logout(null);
                buttonUserLogin.Enabled = true;
                tabControlFeatures.Enabled = false;
                m_AppLogic.ClearUserSettings();
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
            Text = "Connected as: " + Session.Instance.LoggedInUser.Name;
            pictureBoxProfile.LoadAsync(Session.Instance.LoggedInUser.PictureLargeURL);
            labelUserName.Text = Session.Instance.LoggedInUser.Name;
        }

        private void fetchFriends()
        {
            listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.Items.Clear()));
            listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.DisplayMember = "Name"));

            foreach (User friend in Session.Instance.LoggedInUser.Friends)
            {
                listBoxFriendsList.Invoke(new Action(() => listBoxFriendsList.Items.Add(friend)));
                listBoxFriendsSelect.Invoke(new Action(() => listBoxFriendsSelect.Items.Add(friend)));
            }

            if (Session.Instance.LoggedInUser.Friends.Count == 0)
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
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Clear()));
            listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.DisplayMember = "Name"));

            foreach (Page page in Session.Instance.LoggedInUser.LikedPages)
            {
                listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
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
            listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Clear()));

            foreach (Checkin checkin in Session.Instance.LoggedInUser.Checkins)
            {
                listBoxCheckins.Invoke(new Action(() => listBoxCheckins.Items.Add(checkin.Place.Name)));
            }

            if (Session.Instance.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No Checkins to retrieve :(");
            }
        }

        private void buttonPostStatus_Click(object sender, EventArgs e)
        {
            Status status = Session.Instance.LoggedInUser.PostStatus(textBoxPostStatus.Text);
            MessageBox.Show("Status posted! ID : " + status.Id);
            textBoxPostStatus.Text = string.Empty;
        }

        private void fetchPosts()
        {
            foreach (Post post in Session.Instance.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                }
                else
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }

            if (Session.Instance.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void fetchEvents()
        {
            foreach (Event fbEvent in Session.Instance.LoggedInUser.Events)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(fbEvent)));
            }

            if (Session.Instance.LoggedInUser.Events.Count == 0)
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

        private void populateCategoryComboBox()
        {
            foreach (string activity in m_AppLogic.SportsActivityPlanner.ActivityCategory)
            {
                comboBoxActivity.Items.Add(activity);
            }
        }

        private void populateTimeComboBox()
        {
            foreach (string time in m_AppLogic.SportsActivityPlanner.HoursCategory)
            {
                comboBoxTime.Items.Add(time);
            }
        }

        private void buttonGetForecast_Click(object sender, EventArgs e)
        {
            List<string> currentForecast = null;
            try
            {
                currentForecast = m_AppLogic.SportsActivityPlanner.GetWGetWeeklyForecastByCityAndHour(textBoxCity.Text, comboBoxTime.SelectedItem.ToString());

                foreach (string forecast in currentForecast)
                {
                    listBoxWeatherData.Items.Add(forecast);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    @"City Not Found.
Please try again",
"ERROR");
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
            Status status = Session.Instance.LoggedInUser.PostStatus(textBoxActivityPost.Text);
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
            textBoxActivityPost.Text = textBoxActivityPost.Text + Environment.NewLine + "At - " + (sender as ListBox).SelectedItem.ToString();
        }

        #endregion

        private void tabControlFeatures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as TabControl).SelectedIndex == 1)
            {
                m_AppLogic.InitLunchTime();
                populateColleagues();
                populateUserLikedRestaurants();
            }
            else if ((sender as TabControl).SelectedIndex == 2)
            {
                m_AppLogic.InitSportsActivityPlanner();
                populateCategoryComboBox();
                populateTimeComboBox();
                labelSportPlanner.Text = k_SportInfo;
            }
        }

        private void comboBoxAppID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            Session.Instance.AppID = comboBox.SelectedItem.ToString();
        }
    }
}