namespace A18_Ex01_Or_200337251_Naor_301032157
{
    partial class formFacebookApp
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
            this.pictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(163, 68);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePhoto.TabIndex = 0;
            this.pictureBoxProfilePhoto.TabStop = false;
            this.pictureBoxProfilePhoto.Click += new System.EventHandler(this.pictureBoxProfilePhoto_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 92);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "labelUserName";
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Location = new System.Drawing.Point(181, 12);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(104, 43);
            this.buttonUserLogin.TabIndex = 2;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // listBoxFriendsList
            // 
            this.listBoxFriendsList.FormattingEnabled = true;
            this.listBoxFriendsList.Location = new System.Drawing.Point(12, 180);
            this.listBoxFriendsList.Name = "listBoxFriendsList";
            this.listBoxFriendsList.Size = new System.Drawing.Size(136, 95);
            this.listBoxFriendsList.TabIndex = 3;
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Location = new System.Drawing.Point(9, 156);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(57, 13);
            this.labelFriendsList.TabIndex = 4;
            this.labelFriendsList.Text = "FriendsList";
            // 
            // buttonFetchFriends
            // 
            this.buttonFetchFriends.Location = new System.Drawing.Point(73, 151);
            this.buttonFetchFriends.Name = "buttonFetchFriends";
            this.buttonFetchFriends.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchFriends.TabIndex = 5;
            this.buttonFetchFriends.Text = "Fetch Friends";
            this.buttonFetchFriends.UseVisualStyleBackColor = true;
            this.buttonFetchFriends.Click += new System.EventHandler(this.buttonFetchFriends_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(154, 180);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(135, 95);
            this.listBoxLikedPages.TabIndex = 6;
            // 
            // buttonGetPages
            // 
            this.buttonGetPages.Location = new System.Drawing.Point(214, 151);
            this.buttonGetPages.Name = "buttonGetPages";
            this.buttonGetPages.Size = new System.Drawing.Size(75, 23);
            this.buttonGetPages.TabIndex = 5;
            this.buttonGetPages.Text = "Fetch ";
            this.buttonGetPages.UseVisualStyleBackColor = true;
            this.buttonGetPages.Click += new System.EventHandler(this.buttonFetchLikedPages_Click);
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(151, 156);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(63, 13);
            this.labelLikedPages.TabIndex = 4;
            this.labelLikedPages.Text = "LikedPages";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(182, 56);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(103, 23);
            this.buttonLogout.TabIndex = 7;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxCheckins
            // 
            this.listBoxCheckins.FormattingEnabled = true;
            this.listBoxCheckins.Location = new System.Drawing.Point(295, 180);
            this.listBoxCheckins.Name = "listBoxCheckins";
            this.listBoxCheckins.Size = new System.Drawing.Size(120, 95);
            this.listBoxCheckins.TabIndex = 8;
            // 
            // buttonFetchCheckins
            // 
            this.buttonFetchCheckins.Location = new System.Drawing.Point(340, 151);
            this.buttonFetchCheckins.Name = "buttonFetchCheckins";
            this.buttonFetchCheckins.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchCheckins.TabIndex = 9;
            this.buttonFetchCheckins.Text = "Fetch";
            this.buttonFetchCheckins.UseVisualStyleBackColor = true;
            this.buttonFetchCheckins.Click += new System.EventHandler(this.buttonFetchCheckins_Click);
            // 
            // labelCheckins
            // 
            this.labelCheckins.AutoSize = true;
            this.labelCheckins.Location = new System.Drawing.Point(295, 156);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(51, 13);
            this.labelCheckins.TabIndex = 10;
            this.labelCheckins.Text = "Checkins";
            // 
            // formFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 323);
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
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Name = "formFacebookApp";
            this.Text = "FacebookExprience";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
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
    }
}

