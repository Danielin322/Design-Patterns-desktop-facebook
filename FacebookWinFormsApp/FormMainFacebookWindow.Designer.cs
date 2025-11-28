namespace BasicFacebookFeatures
{
    partial class FormMainFacebookWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainFacebookWindow));
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.textBoxUserFullName = new System.Windows.Forms.TextBox();
            this.pictureBox_Profile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUserPhotos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(1064, 902);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(108, 53);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(922, 902);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(108, 53);
            this.buttonFriends.TabIndex = 3;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // textBoxUserFullName
            // 
            this.textBoxUserFullName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserFullName.Location = new System.Drawing.Point(1021, 229);
            this.textBoxUserFullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserFullName.Name = "textBoxUserFullName";
            this.textBoxUserFullName.ReadOnly = true;
            this.textBoxUserFullName.Size = new System.Drawing.Size(152, 26);
            this.textBoxUserFullName.TabIndex = 4;
            this.textBoxUserFullName.TextChanged += new System.EventHandler(this.textBoxUserFullName_TextChanged);
            // 
            // pictureBox_Profile
            // 
            this.pictureBox_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.Image")));
            this.pictureBox_Profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.InitialImage")));
            this.pictureBox_Profile.Location = new System.Drawing.Point(1021, 50);
            this.pictureBox_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Profile.Name = "pictureBox_Profile";
            this.pictureBox_Profile.Size = new System.Drawing.Size(152, 152);
            this.pictureBox_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Profile.TabIndex = 5;
            this.pictureBox_Profile.TabStop = false;
            this.pictureBox_Profile.Click += new System.EventHandler(this.pictureBox_Profile_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(20, 891);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(157, 46);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUserPhotos
            // 
            this.buttonUserPhotos.Location = new System.Drawing.Point(782, 902);
            this.buttonUserPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserPhotos.Name = "buttonUserPhotos";
            this.buttonUserPhotos.Size = new System.Drawing.Size(108, 53);
            this.buttonUserPhotos.TabIndex = 7;
            this.buttonUserPhotos.Text = "Photos";
            this.buttonUserPhotos.UseVisualStyleBackColor = true;
            this.buttonUserPhotos.Click += new System.EventHandler(this.buttonUserPhotos_Click);
            // 
            // FormMainFacebookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 981);
            this.Controls.Add(this.buttonUserPhotos);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox_Profile);
            this.Controls.Add(this.textBoxUserFullName);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainFacebookWindow";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Text = "FacebookWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FacebookWindow_FormClosed);
            this.Load += new System.EventHandler(this.FormMainFacebookWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.TextBox textBoxUserFullName;
        private System.Windows.Forms.PictureBox pictureBox_Profile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonUserPhotos;
    }
}