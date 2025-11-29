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
            this.textBoxNewPost = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.buttonPublishPost = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(1285, 1114);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(144, 66);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(1095, 1114);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(144, 66);
            this.buttonFriends.TabIndex = 3;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // textBoxUserFullName
            // 
            this.textBoxUserFullName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserFullName.Location = new System.Drawing.Point(1233, 283);
            this.textBoxUserFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserFullName.Name = "textBoxUserFullName";
            this.textBoxUserFullName.ReadOnly = true;
            this.textBoxUserFullName.Size = new System.Drawing.Size(202, 31);
            this.textBoxUserFullName.TabIndex = 4;
            // 
            // pictureBox_Profile
            // 
            this.pictureBox_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.Image")));
            this.pictureBox_Profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.InitialImage")));
            this.pictureBox_Profile.Location = new System.Drawing.Point(1233, 59);
            this.pictureBox_Profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Profile.Name = "pictureBox_Profile";
            this.pictureBox_Profile.Size = new System.Drawing.Size(202, 190);
            this.pictureBox_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Profile.TabIndex = 5;
            this.pictureBox_Profile.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(39, 1134);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(209, 58);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUserPhotos
            // 
            this.buttonUserPhotos.Location = new System.Drawing.Point(909, 1114);
            this.buttonUserPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserPhotos.Name = "buttonUserPhotos";
            this.buttonUserPhotos.Size = new System.Drawing.Size(144, 66);
            this.buttonUserPhotos.TabIndex = 7;
            this.buttonUserPhotos.Text = "Photos";
            this.buttonUserPhotos.UseVisualStyleBackColor = true;
            this.buttonUserPhotos.Click += new System.EventHandler(this.buttonUserPhotos_Click);
            // 
            // textBoxNewPost
            // 
            this.textBoxNewPost.Location = new System.Drawing.Point(51, 123);
            this.textBoxNewPost.Multiline = true;
            this.textBoxNewPost.Name = "textBoxNewPost";
            this.textBoxNewPost.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNewPost.Size = new System.Drawing.Size(1030, 217);
            this.textBoxNewPost.TabIndex = 8;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.Location = new System.Drawing.Point(53, 78);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(348, 37);
            this.labelPost.TabIndex = 9;
            this.labelPost.Text = "What\'s on your mind?";
            // 
            // buttonPublishPost
            // 
            this.buttonPublishPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublishPost.Location = new System.Drawing.Point(959, 371);
            this.buttonPublishPost.Name = "buttonPublishPost";
            this.buttonPublishPost.Size = new System.Drawing.Size(121, 63);
            this.buttonPublishPost.TabIndex = 10;
            this.buttonPublishPost.Text = "Publish";
            this.buttonPublishPost.UseVisualStyleBackColor = true;
            this.buttonPublishPost.Click += new System.EventHandler(this.buttonPublishPost_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 25;
            this.listBoxLikedPages.Location = new System.Drawing.Point(28, 531);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(315, 504);
            this.listBoxLikedPages.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pages you recently liked:";
            // 
            // FormMainFacebookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1229);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonPublishPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.textBoxNewPost);
            this.Controls.Add(this.buttonUserPhotos);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox_Profile);
            this.Controls.Add(this.textBoxUserFullName);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMainFacebookWindow";
            this.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Text = "FacebookWindow";
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
        private System.Windows.Forms.TextBox textBoxNewPost;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Button buttonPublishPost;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label label1;
    }
}