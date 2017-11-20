namespace A18_Ex01_Or_200337251_Naor_301032157
{
    partial class FacebookAppDashboard
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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            this.listBoxFriendsList = new System.Windows.Forms.ListBox();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.buttonFetchFriends = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonGetPages = new System.Windows.Forms.Button();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxCheckins = new System.Windows.Forms.ListBox();
            this.buttonFetchCheckins = new System.Windows.Forms.Button();
            this.labelCheckins = new System.Windows.Forms.Label();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.textBoxPostStatus = new System.Windows.Forms.TextBox();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.buttonFetchPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonFetchEvents = new System.Windows.Forms.Button();
            this.lableEvents = new System.Windows.Forms.Label();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.labelRecentPosts = new System.Windows.Forms.Label();
            this.pictureBoxPages = new System.Windows.Forms.PictureBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxEvents = new System.Windows.Forms.PictureBox();
            this.buttonListRestaurantPages = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(16, 34);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(219, 89);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Click += new System.EventHandler(this.pictureBoxProfilePhoto_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(16, 15);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name";
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Location = new System.Drawing.Point(243, 34);
            this.buttonUserLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(139, 53);
            this.buttonUserLogin.TabIndex = 2;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.ItemHeight = 16;
            this.listBoxFriendsList.Location = new System.Drawing.Point(16, 324);
            this.listBoxFriendsList.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(227, 116);
            this.listBoxFriendsList.TabIndex = 3;
            this.listBoxFriendsList.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsList_SelectedIndexChanged);
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Location = new System.Drawing.Point(12, 294);
            this.labelFriendsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(77, 17);
            this.labelFriendsList.TabIndex = 4;
            this.labelFriendsList.Text = "FriendsList";
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(144, 288);
            this.buttonFetchFriends.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchFriends.TabIndex = 5;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 16;
            this.listBoxLikedPages.Location = new System.Drawing.Point(499, 324);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(211, 116);
            this.listBoxLikedPages.TabIndex = 6;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // buttonGetPages
            // 
            this.buttonGetPages.Location = new System.Drawing.Point(611, 288);
            this.buttonGetPages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetPages.Name = "buttonGetPages";
            this.buttonGetPages.Size = new System.Drawing.Size(100, 28);
            this.buttonGetPages.TabIndex = 5;
            this.buttonGetPages.Text = "Fetch ";
            this.buttonGetPages.UseVisualStyleBackColor = true;
            this.buttonGetPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(495, 294);
            this.labelLikedPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(82, 17);
            this.labelLikedPages.TabIndex = 4;
            this.labelLikedPages.Text = "LikedPages";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(243, 95);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(137, 28);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.ItemHeight = 16;
            this.listBoxCheckins.Location = new System.Drawing.Point(17, 494);
            this.listBoxCheckins.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(225, 116);
            this.listBoxCheckins.TabIndex = 8;
            // 
            // buttonFetchCheckins
            // 
            this.buttonFetchCheckins.Location = new System.Drawing.Point(144, 458);
            this.buttonFetchCheckins.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchCheckins.Name = "buttonFetchCheckins";
            this.buttonFetchCheckins.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchCheckins.TabIndex = 9;
            this.buttonFetchCheckins.Text = "Fetch";
            this.buttonFetchCheckins.UseVisualStyleBackColor = true;
            this.buttonFetchCheckins.Click += new System.EventHandler(this.buttonFetchCheckins_Click);
            // 
            // labelCheckins
            // 
            this.labelCheckins.AutoSize = true;
            this.labelCheckins.Location = new System.Drawing.Point(13, 464);
            this.labelCheckins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(65, 17);
            this.labelCheckins.TabIndex = 10;
            this.labelCheckins.Text = "Checkins";
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Location = new System.Drawing.Point(419, 15);
            this.labelPostStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(88, 17);
            this.labelPostStatus.TabIndex = 11;
            this.labelPostStatus.Text = "Post Status :";
            // 
            // textBoxPostStatus
            // 
            this.textBoxPostStatus.Location = new System.Drawing.Point(423, 34);
            this.textBoxPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostStatus.Name = "textBoxPostStatus";
            this.textBoxPostStatus.Size = new System.Drawing.Size(416, 22);
            this.textBoxPostStatus.TabIndex = 12;
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(848, 34);
            this.buttonPostStatus.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(100, 28);
            this.buttonPostStatus.TabIndex = 13;
            this.buttonPostStatus.Text = "Post";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // buttonFetchPosts
            // 
            this.buttonFetchPosts.Location = new System.Drawing.Point(525, 80);
            this.buttonFetchPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchPosts.Name = "buttonFetchPosts";
            this.buttonFetchPosts.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchPosts.TabIndex = 14;
            this.buttonFetchPosts.Text = "Fetch Posts";
            this.buttonFetchPosts.UseVisualStyleBackColor = true;
            this.buttonFetchPosts.Click += new System.EventHandler(this.buttonFetchPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 16;
            this.listBoxPosts.Location = new System.Drawing.Point(423, 116);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(416, 148);
            this.listBoxPosts.TabIndex = 15;
            // 
            // buttonFetchEvents
            // 
            this.buttonFetchEvents.Location = new System.Drawing.Point(611, 458);
            this.buttonFetchEvents.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchEvents.Name = "buttonFetchEvents";
            this.buttonFetchEvents.Size = new System.Drawing.Size(100, 28);
            this.buttonFetchEvents.TabIndex = 16;
            this.buttonFetchEvents.Text = "Fetch";
            this.buttonFetchEvents.UseVisualStyleBackColor = true;
            this.buttonFetchEvents.Click += new System.EventHandler(this.buttonFetchEvents_Click);
            // 
            // lableEvents
            // 
            this.lableEvents.AutoSize = true;
            this.lableEvents.Location = new System.Drawing.Point(495, 464);
            this.lableEvents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableEvents.Name = "lableEvents";
            this.lableEvents.Size = new System.Drawing.Size(51, 17);
            this.lableEvents.TabIndex = 17;
            this.lableEvents.Text = "Events";
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(499, 494);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(211, 116);
            this.listBoxEvents.TabIndex = 18;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // labelRecentPosts
            // 
            this.labelRecentPosts.AutoSize = true;
            this.labelRecentPosts.Location = new System.Drawing.Point(423, 86);
            this.labelRecentPosts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecentPosts.Name = "labelRecentPosts";
            this.labelRecentPosts.Size = new System.Drawing.Size(92, 17);
            this.labelRecentPosts.TabIndex = 19;
            this.labelRecentPosts.Text = "Recent Posts";
            // 
            // pictureBoxPages
            // 
            this.pictureBoxPages.Location = new System.Drawing.Point(745, 324);
            this.pictureBoxPages.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPages.Name = "pictureBoxPages";
            this.pictureBoxPages.Size = new System.Drawing.Size(133, 117);
            this.pictureBoxPages.TabIndex = 20;
            this.pictureBoxPages.TabStop = false;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(288, 324);
            this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(133, 117);
            this.pictureBoxFriends.TabIndex = 20;
            this.pictureBoxFriends.TabStop = false;
            // 
            // pictureBoxEvents
            // 
            this.pictureBoxEvents.Location = new System.Drawing.Point(745, 494);
            this.pictureBoxEvents.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxEvents.Name = "pictureBoxEvents";
            this.pictureBoxEvents.Size = new System.Drawing.Size(133, 117);
            this.pictureBoxEvents.TabIndex = 20;
            this.pictureBoxEvents.TabStop = false;
            // 
            // buttonListRestaurantPages
            // 
            this.buttonListRestaurantPages.Location = new System.Drawing.Point(103, 171);
            this.buttonListRestaurantPages.Name = "buttonListRestaurantPages";
            this.buttonListRestaurantPages.Size = new System.Drawing.Size(193, 39);
            this.buttonListRestaurantPages.TabIndex = 21;
            this.buttonListRestaurantPages.Text = "List al restaurants";
            this.buttonListRestaurantPages.UseVisualStyleBackColor = true;
            this.buttonListRestaurantPages.Click += new System.EventHandler(this.buttonListRestaurantPages_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.AutoSize = true;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(19, 131);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(139, 21);
            this.checkBoxRememberUser.TabIndex = 22;
            this.checkBoxRememberUser.Text = "Remember user?";
            this.checkBoxRememberUser.UseVisualStyleBackColor = true;
            // 
            // FacebookAppDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 631);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonListRestaurantPages);
            this.Controls.Add(this.pictureBoxEvents);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.pictureBoxPages);
            this.Controls.Add(this.labelRecentPosts);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.lableEvents);
            this.Controls.Add(this.buttonFetchEvents);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonFetchPosts);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.textBoxPostStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.labelCheckins);
            this.Controls.Add(this.buttonFetchCheckins);
            this.Controls.Add(this.listBoxCheckins);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonGetPages);
            this.Controls.Add(this.buttonFetchFriends);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.labelFriendsList);
            this.Controls.Add(this.listBoxFriendsList);
            this.Controls.Add(this.buttonUserLogin);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxProfile);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FacebookAppDashboard";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookExprience";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUserLogin;
        private System.Windows.Forms.ListBox listBoxFriendsList;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.Button buttonFetchFriends;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonGetPages;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxCheckins;
        private System.Windows.Forms.Button buttonFetchCheckins;
        private System.Windows.Forms.Label labelCheckins;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.TextBox textBoxPostStatus;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.Button buttonFetchPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonFetchEvents;
        private System.Windows.Forms.Label lableEvents;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label labelRecentPosts;
        private System.Windows.Forms.PictureBox pictureBoxPages;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxEvents;
        private System.Windows.Forms.Button buttonListRestaurantPages;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
    }
}

