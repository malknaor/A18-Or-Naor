namespace A18_Ex01_Or_200337251_Naor_301032157
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.tabPageLunchtime = new System.Windows.Forms.TabPage();
            this.listBoxColleagues = new System.Windows.Forms.ListBox();
            this.buttonGetcolleagues = new System.Windows.Forms.Button();
            this.listboxCommonRestaurants = new System.Windows.Forms.ListBox();
            this.buttonListRestaurantPages = new System.Windows.Forms.Button();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.labelRecentPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.lableEvents = new System.Windows.Forms.Label();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.buttonGetPages = new System.Windows.Forms.Button();
            this.pictureBoxPages = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.labelCheckins = new System.Windows.Forms.Label();
            this.buttonFetchCheckins = new System.Windows.Forms.Button();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.tabControlFeatures = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPageLunchtime.SuspendLayout();
            this.tabPageDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).BeginInit();
            this.tabControlFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(13, 25);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(119, 25);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(13, 284);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(160, 28);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRememberUser.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberUser.ForeColor = System.Drawing.Color.White;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(13, 319);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(148, 19);
            this.checkBoxRememberUser.TabIndex = 22;
            this.checkBoxRememberUser.Text = "Remember user?";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUserLogin.BackgroundImage")));
            this.buttonUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUserLogin.Location = new System.Drawing.Point(10, 233);
            this.buttonUserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(167, 43);
            this.buttonUserLogin.TabIndex = 2;
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(10, 60);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(163, 161);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfilePhoto_Click);
            // 
            // tabPageLunchtime
            // 
            this.tabPageLunchtime.Controls.Add(this.listBoxColleagues);
            this.tabPageLunchtime.Controls.Add(this.buttonGetcolleagues);
            this.tabPageLunchtime.Controls.Add(this.listboxCommonRestaurants);
            this.tabPageLunchtime.Controls.Add(this.buttonListRestaurantPages);
            this.tabPageLunchtime.Location = new System.Drawing.Point(4, 25);
            this.tabPageLunchtime.Name = "tabPageLunchtime";
            this.tabPageLunchtime.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLunchtime.Size = new System.Drawing.Size(668, 535);
            this.tabPageLunchtime.TabIndex = 3;
            this.tabPageLunchtime.Text = "LunchTime";
            this.tabPageLunchtime.UseVisualStyleBackColor = true;
            // 
            // listBoxColleagues
            // 
            this.listBoxColleagues.FormattingEnabled = true;
            this.listBoxColleagues.ItemHeight = 16;
            this.listBoxColleagues.Location = new System.Drawing.Point(6, 64);
            this.listBoxColleagues.Name = "listBoxColleagues";
            this.listBoxColleagues.Size = new System.Drawing.Size(178, 132);
            this.listBoxColleagues.TabIndex = 29;
            // 
            // buttonGetcolleagues
            // 
            this.buttonGetcolleagues.Location = new System.Drawing.Point(6, 23);
            this.buttonGetcolleagues.Name = "buttonGetcolleagues";
            this.buttonGetcolleagues.Size = new System.Drawing.Size(178, 31);
            this.buttonGetcolleagues.TabIndex = 28;
            this.buttonGetcolleagues.Text = "Get colleagues";
            this.buttonGetcolleagues.UseVisualStyleBackColor = true;
            this.buttonGetcolleagues.Click += new System.EventHandler(this.buttonGetcolleagues_Click);
            // 
            // listboxCommonRestaurants
            // 
            this.listboxCommonRestaurants.FormattingEnabled = true;
            this.listboxCommonRestaurants.ItemHeight = 16;
            this.listboxCommonRestaurants.Location = new System.Drawing.Point(203, 60);
            this.listboxCommonRestaurants.Name = "listboxCommonRestaurants";
            this.listboxCommonRestaurants.Size = new System.Drawing.Size(204, 132);
            this.listboxCommonRestaurants.TabIndex = 27;
            // 
            // buttonListRestaurantPages
            // 
            this.buttonListRestaurantPages.Location = new System.Drawing.Point(203, 23);
            this.buttonListRestaurantPages.Name = "buttonListRestaurantPages";
            this.buttonListRestaurantPages.Size = new System.Drawing.Size(204, 31);
            this.buttonListRestaurantPages.TabIndex = 26;
            this.buttonListRestaurantPages.Text = "List Common Restaurant";
            this.buttonListRestaurantPages.UseVisualStyleBackColor = true;
            this.buttonListRestaurantPages.Click += new System.EventHandler(this.buttonListRestaurantPages_Click);
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.BackColor = System.Drawing.Color.Transparent;
            this.tabPageDashboard.Controls.Add(this.pictureBoxFriends);
            this.tabPageDashboard.Controls.Add(this.labelRecentPosts);
            this.tabPageDashboard.Controls.Add(this.listBoxPosts);
            this.tabPageDashboard.Controls.Add(this.buttonFetchPosts);
            this.tabPageDashboard.Controls.Add(this.buttonPostStatus);
            this.tabPageDashboard.Controls.Add(this.textBoxPostStatus);
            this.tabPageDashboard.Controls.Add(this.labelPostStatus);
            this.tabPageDashboard.Controls.Add(this.lableEvents);
            this.tabPageDashboard.Controls.Add(this.buttonFetchEvents);
            this.tabPageDashboard.Controls.Add(this.pictureBoxEvents);
            this.tabPageDashboard.Controls.Add(this.listBoxEvents);
            this.tabPageDashboard.Controls.Add(this.labelLikedPages);
            this.tabPageDashboard.Controls.Add(this.buttonGetPages);
            this.tabPageDashboard.Controls.Add(this.pictureBoxPages);
            this.tabPageDashboard.Controls.Add(this.listBoxLikedPages);
            this.tabPageDashboard.Controls.Add(this.buttonFetchFriends);
            this.tabPageDashboard.Controls.Add(this.labelFriendsList);
            this.tabPageDashboard.Controls.Add(this.listBoxFriendsList);
            this.tabPageDashboard.Controls.Add(this.labelCheckins);
            this.tabPageDashboard.Controls.Add(this.buttonFetchCheckins);
            this.tabPageDashboard.Controls.Add(this.listBoxCheckins);
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(668, 535);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Dashboard";
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(213, 69);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(80, 81);
            this.pictureBoxFriends.TabIndex = 40;
            this.pictureBoxFriends.TabStop = false;
            // 
            // labelRecentPosts
            // 
            this.labelRecentPosts.AutoSize = true;
            this.labelRecentPosts.Location = new System.Drawing.Point(102, 397);
            this.labelRecentPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecentPosts.Name = "labelRecentPosts";
            this.labelRecentPosts.Size = new System.Drawing.Size(92, 17);
            this.labelRecentPosts.TabIndex = 39;
            this.labelRecentPosts.Text = "Recent Posts";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(102, 418);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(416, 100);
            this.listBoxPosts.TabIndex = 38;
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(202, 390);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchPosts.TabIndex = 37;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(529, 331);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(100, 28);
            this.buttonPostStatus.TabIndex = 36;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(105, 337);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(416, 22);
            this.textBoxPostStatus.TabIndex = 35;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(12, 337);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(88, 17);
            this.labelPostStatus.TabIndex = 34;
            this.labelPostStatus.Text = "Post Status :";
            // 
            // lableEvents
            // 
            this.lableEvents.AutoSize = true;
            this.lableEvents.Location = new System.Drawing.Point(12, 198);
            this.lableEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEvents.Name = "lableEvents";
            this.lableEvents.Size = new System.Drawing.Size(51, 17);
            this.lableEvents.TabIndex = 33;
            this.lableEvents.Text = "Events";
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(102, 187);
            this.buttonFetchEvents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchEvents.TabIndex = 32;
            this.buttonFetchEvents.Text = "Fetch";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.Location = new System.Drawing.Point(210, 219);
            this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(80, 100);
            this.pictureBoxEvents.TabIndex = 23;
            this.pictureBoxEvents.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(12, 219);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(190, 100);
            this.listBoxEvents.TabIndex = 22;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(310, 199);
            this.labelLikedPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(82, 17);
            this.labelLikedPages.TabIndex = 17;
            this.labelLikedPages.Text = "LikedPages";
            // 
            // buttonGetPages
            // 
            this.buttonGetPages.Location = new System.Drawing.Point(400, 194);
            this.buttonGetPages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetPages.Name = "buttonGetPages";
            this.buttonGetPages.Size = new System.Drawing.Size(100, 28);
            this.buttonGetPages.TabIndex = 18;
            this.buttonGetPages.Text = "Fetch ";
            this.buttonGetPages.UseVisualStyleBackColor = true;
            this.buttonGetPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // pictureBoxPages
            // 
            this.pictureBoxPages.Location = new System.Drawing.Point(508, 235);
            this.pictureBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPages.Name = "pictureBoxPages";
            this.pictureBoxPages.Size = new System.Drawing.Size(80, 84);
            this.pictureBoxPages.TabIndex = 21;
            this.pictureBoxPages.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(313, 235);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(187, 84);
            this.listBoxLikedPages.TabIndex = 19;
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(133, 33);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchFriends.TabIndex = 16;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Location = new System.Drawing.Point(15, 36);
            this.labelFriendsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(77, 17);
            this.labelFriendsList.TabIndex = 15;
            this.labelFriendsList.Text = "FriendsList";
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 16;
            this.listBoxFriendsList.Location = new System.Drawing.Point(15, 72);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(190, 68);
            this.listBoxFriendsList.TabIndex = 14;
            // 
            // labelCheckins
            // 
            this.labelCheckins.AutoSize = true;
            this.labelCheckins.Location = new System.Drawing.Point(328, 36);
            this.labelCheckins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(65, 17);
            this.labelCheckins.TabIndex = 13;
            this.labelCheckins.Text = "Checkins";
            // 
            // buttonFetchCheckins
            // 
            this.buttonFetchCheckins.Location = new System.Drawing.Point(414, 36);
            this.buttonFetchCheckins.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchCheckins.Name = "buttonFetchCheckins";
            this.buttonFetchCheckins.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchCheckins.TabIndex = 12;
            this.buttonFetchCheckins.Text = "Fetch";
            this.buttonFetchCheckins.UseVisualStyleBackColor = true;
            this.buttonFetchCheckins.Click += new System.EventHandler(this.buttonFetchCheckins_Click);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 16;
            this.listBoxCheckins.Location = new System.Drawing.Point(331, 72);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(190, 84);
            this.listBoxCheckins.TabIndex = 11;
            // 
            // tabControlFeatures
            // 
            this.tabControlFeatures.Controls.Add(this.tabPageDashboard);
            this.tabControlFeatures.Controls.Add(this.tabPageLunchtime);
            this.tabControlFeatures.Location = new System.Drawing.Point(180, 55);
            this.tabControlFeatures.Name = "tabControlFeatures";
            this.tabControlFeatures.SelectedIndex = 0;
            this.tabControlFeatures.Size = new System.Drawing.Size(676, 564);
            this.tabControlFeatures.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 704);
            this.Controls.Add(this.tabControlFeatures);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonUserLogin);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxProfile);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookExprience";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPageLunchtime.ResumeLayout(false);
            this.tabPageDashboard.ResumeLayout(false);
            this.tabPageDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).EndInit();
            this.tabControlFeatures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private System.Windows.Forms.TabPage tabPageLunchtime;
        private System.Windows.Forms.ListBox listBoxColleagues;
        private System.Windows.Forms.Button buttonGetcolleagues;
        private System.Windows.Forms.ListBox listboxCommonRestaurants;
        private System.Windows.Forms.Button buttonListRestaurantPages;
        private System.Windows.Forms.TabPage tabPageDashboard;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.Label labelRecentPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.Label lableEvents;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.Button buttonGetPages;
        private System.Windows.Forms.PictureBox pictureBoxPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.Label labelCheckins;
        private System.Windows.Forms.Button buttonFetchCheckins;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.TabControl tabControlFeatures;
    }
}

