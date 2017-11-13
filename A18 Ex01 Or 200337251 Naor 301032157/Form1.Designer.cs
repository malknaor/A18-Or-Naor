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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUserLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxProfilePhoto
            // 
            this.pictureBoxProfilePhoto.Location = new System.Drawing.Point(12, 47);
            this.pictureBoxProfilePhoto.Name = "pictureBoxProfilePhoto";
            this.pictureBoxProfilePhoto.Size = new System.Drawing.Size(163, 68);
            this.pictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfilePhoto.TabIndex = 0;
            this.pictureBoxProfilePhoto.TabStop = false;
            this.pictureBoxProfilePhoto.Click += new System.EventHandler(this.pictureBoxProfilePhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "labelUserName";
            // 
            // buttonUserLogin
            // 
            this.buttonUserLogin.Location = new System.Drawing.Point(181, 57);
            this.buttonUserLogin.Name = "buttonUserLogin";
            this.buttonUserLogin.Size = new System.Drawing.Size(104, 43);
            this.buttonUserLogin.TabIndex = 2;
            this.buttonUserLogin.Text = "Login";
            this.buttonUserLogin.UseVisualStyleBackColor = true;
            this.buttonUserLogin.Click += new System.EventHandler(this.buttonUserLogin_Click);
            // 
            // formFacebookApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 322);
            this.Controls.Add(this.buttonUserLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxProfilePhoto);
            this.Name = "formFacebookApp";
            this.Text = "FacebookExprience";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfilePhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUserLogin;
    }
}

