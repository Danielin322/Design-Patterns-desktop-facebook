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
            this.textBoxUserFullName = new System.Windows.Forms.TextBox();
            this.pictureBox_Profile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUserPhotos = new System.Windows.Forms.Button();
            this.textBoxNewPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.buttonPublishPost = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.LablePagesYouLiked = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SpecialMomentsCollage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonProfile.AutoSize = true;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(1042, 865);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(108, 53);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // textBoxUserFullName
            // 
            this.textBoxUserFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserFullName.BackColor = System.Drawing.Color.Lavender;
            this.textBoxUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserFullName.Location = new System.Drawing.Point(903, 276);
            this.textBoxUserFullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserFullName.Name = "textBoxUserFullName";
            this.textBoxUserFullName.ReadOnly = true;
            this.textBoxUserFullName.Size = new System.Drawing.Size(212, 31);
            this.textBoxUserFullName.TabIndex = 4;
            this.textBoxUserFullName.TabStop = false;
            // 
            // pictureBox_Profile
            // 
            this.pictureBox_Profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Profile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.Image")));
            this.pictureBox_Profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.InitialImage")));
            this.pictureBox_Profile.Location = new System.Drawing.Point(903, 48);
            this.pictureBox_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Profile.Name = "pictureBox_Profile";
            this.pictureBox_Profile.Size = new System.Drawing.Size(212, 209);
            this.pictureBox_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Profile.TabIndex = 5;
            this.pictureBox_Profile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(29, 860);
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
            this.buttonUserPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUserPhotos.AutoSize = true;
            this.buttonUserPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserPhotos.Location = new System.Drawing.Point(918, 865);
            this.buttonUserPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserPhotos.Name = "buttonUserPhotos";
            this.buttonUserPhotos.Size = new System.Drawing.Size(108, 53);
            this.buttonUserPhotos.TabIndex = 7;
            this.buttonUserPhotos.Text = "Photos";
            this.buttonUserPhotos.UseVisualStyleBackColor = true;
            this.buttonUserPhotos.Click += new System.EventHandler(this.buttonUserPhotos_Click);
            // 
            // textBoxNewPost
            // 
            this.textBoxNewPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPost.Location = new System.Drawing.Point(29, 105);
            this.textBoxNewPost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewPost.Multiline = true;
            this.textBoxNewPost.Name = "textBoxNewPost";
            this.textBoxNewPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNewPost.Size = new System.Drawing.Size(717, 156);
            this.textBoxNewPost.TabIndex = 8;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.Location = new System.Drawing.Point(33, 48);
            this.labelPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(348, 37);
            this.labelPost.TabIndex = 9;
            this.labelPost.Text = "What\'s on your mind?";
            // 
            // buttonPublishPost
            // 
            this.buttonPublishPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPublishPost.AutoSize = true;
            this.buttonPublishPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublishPost.Location = new System.Drawing.Point(655, 276);
            this.buttonPublishPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPublishPost.Name = "buttonPublishPost";
            this.buttonPublishPost.Size = new System.Drawing.Size(126, 50);
            this.buttonPublishPost.TabIndex = 10;
            this.buttonPublishPost.Text = "Publish";
            this.buttonPublishPost.UseVisualStyleBackColor = true;
            this.buttonPublishPost.Click += new System.EventHandler(this.buttonPublishPost_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 31;
            this.listBoxLikedPages.Location = new System.Drawing.Point(29, 399);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(408, 407);
            this.listBoxLikedPages.TabIndex = 11;
            // 
            // LablePagesYouLiked
            // 
            this.LablePagesYouLiked.AutoSize = true;
            this.LablePagesYouLiked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LablePagesYouLiked.Location = new System.Drawing.Point(33, 329);
            this.LablePagesYouLiked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LablePagesYouLiked.Name = "LablePagesYouLiked";
            this.LablePagesYouLiked.Size = new System.Drawing.Size(394, 37);
            this.LablePagesYouLiked.TabIndex = 12;
            this.LablePagesYouLiked.Text = "Pages you recently liked:";
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStatistics.AutoSize = true;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.Location = new System.Drawing.Point(783, 865);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(119, 53);
            this.buttonStatistics.TabIndex = 13;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // SpecialMomentsCollage
            // 
            this.SpecialMomentsCollage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SpecialMomentsCollage.AutoSize = true;
            this.SpecialMomentsCollage.BackColor = System.Drawing.Color.MediumPurple;
            this.SpecialMomentsCollage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialMomentsCollage.Location = new System.Drawing.Point(566, 860);
            this.SpecialMomentsCollage.Name = "SpecialMomentsCollage";
            this.SpecialMomentsCollage.Size = new System.Drawing.Size(201, 62);
            this.SpecialMomentsCollage.TabIndex = 14;
            this.SpecialMomentsCollage.Text = "Special moments";
            this.SpecialMomentsCollage.UseVisualStyleBackColor = false;
            this.SpecialMomentsCollage.Click += new System.EventHandler(this.SpecialMomentsCollage_Click);
            // 
            // FormMainFacebookWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1169, 943);
            this.Controls.Add(this.SpecialMomentsCollage);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.LablePagesYouLiked);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonPublishPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxNewPost);
            this.Controls.Add(this.buttonUserPhotos);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox_Profile);
            this.Controls.Add(this.textBoxUserFullName);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainFacebookWindow";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookWindow";
            this.Load += new System.EventHandler(this.FormMainFacebookWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.TextBox textBoxUserFullName;
        private System.Windows.Forms.PictureBox pictureBox_Profile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonUserPhotos;
        private System.Windows.Forms.TextBox textBoxNewPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Button buttonPublishPost;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label LablePagesYouLiked;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button SpecialMomentsCollage;
    }
}