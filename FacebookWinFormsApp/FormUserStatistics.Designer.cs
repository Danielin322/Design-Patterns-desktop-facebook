namespace BasicFacebookFeatures
{
    partial class FormUserStatistics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label averagePhotosPerAlbumLabel2;
            System.Windows.Forms.Label totalLikedPagesCountLabel2;
            System.Windows.Forms.Label mostLikedCountLabel2;
            System.Windows.Forms.Label friendsCountLabel2;
            System.Windows.Forms.Label totalPostsCountLabel2;
            System.Windows.Forms.Label totalPhotosCountLabel2;
            System.Windows.Forms.Label totalAlbumsCountLabel2;
            this.labelUserStatistics = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonUserPhotos = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.facadeUserInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facadeUserStatisticsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.averagePhotosPerAlbumLabel3 = new System.Windows.Forms.Label();
            this.totalLikedPagesCountLabel3 = new System.Windows.Forms.Label();
            this.mostLikedCountLabel3 = new System.Windows.Forms.Label();
            this.friendsCountLabel3 = new System.Windows.Forms.Label();
            this.totalPostsCountLabel3 = new System.Windows.Forms.Label();
            this.totalPhotosCountLabel3 = new System.Windows.Forms.Label();
            this.totalAlbumsCountLabel3 = new System.Windows.Forms.Label();
            averagePhotosPerAlbumLabel2 = new System.Windows.Forms.Label();
            totalLikedPagesCountLabel2 = new System.Windows.Forms.Label();
            mostLikedCountLabel2 = new System.Windows.Forms.Label();
            friendsCountLabel2 = new System.Windows.Forms.Label();
            totalPostsCountLabel2 = new System.Windows.Forms.Label();
            totalPhotosCountLabel2 = new System.Windows.Forms.Label();
            totalAlbumsCountLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facadeUserInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facadeUserStatisticsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserStatistics
            // 
            this.labelUserStatistics.AutoSize = true;
            this.labelUserStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserStatistics.Location = new System.Drawing.Point(434, 94);
            this.labelUserStatistics.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserStatistics.Name = "labelUserStatistics";
            this.labelUserStatistics.Size = new System.Drawing.Size(314, 51);
            this.labelUserStatistics.TabIndex = 0;
            this.labelUserStatistics.Text = "User Statistics";
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHome.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(1039, 822);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(131, 53);
            this.buttonHome.TabIndex = 29;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonUserPhotos
            // 
            this.buttonUserPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUserPhotos.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonUserPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserPhotos.Location = new System.Drawing.Point(888, 822);
            this.buttonUserPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserPhotos.Name = "buttonUserPhotos";
            this.buttonUserPhotos.Size = new System.Drawing.Size(131, 53);
            this.buttonUserPhotos.TabIndex = 28;
            this.buttonUserPhotos.Text = "Photos";
            this.buttonUserPhotos.UseVisualStyleBackColor = false;
            this.buttonUserPhotos.Click += new System.EventHandler(this.buttonUserPhotos_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonProfile.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(1190, 822);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(121, 53);
            this.buttonProfile.TabIndex = 30;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // facadeUserInfoBindingSource
            // 
            this.facadeUserInfoBindingSource.DataSource = typeof(BasicFacebookFeatures.FacadeUserInfo);
            // 
            // facadeUserStatisticsBindingSource
            // 
            this.facadeUserStatisticsBindingSource.DataSource = typeof(BasicFacebookFeatures.FacadeUserStatistics);
            // 
            // averagePhotosPerAlbumLabel2
            // 
            averagePhotosPerAlbumLabel2.AutoSize = true;
            averagePhotosPerAlbumLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            averagePhotosPerAlbumLabel2.Location = new System.Drawing.Point(737, 412);
            averagePhotosPerAlbumLabel2.Name = "averagePhotosPerAlbumLabel2";
            averagePhotosPerAlbumLabel2.Size = new System.Drawing.Size(398, 33);
            averagePhotosPerAlbumLabel2.TabIndex = 38;
            averagePhotosPerAlbumLabel2.Text = "Average Photos Per Album:";
            averagePhotosPerAlbumLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // averagePhotosPerAlbumLabel3
            // 
            this.averagePhotosPerAlbumLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "AveragePhotosPerAlbum", true));
            this.averagePhotosPerAlbumLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averagePhotosPerAlbumLabel3.Location = new System.Drawing.Point(1163, 399);
            this.averagePhotosPerAlbumLabel3.Name = "averagePhotosPerAlbumLabel3";
            this.averagePhotosPerAlbumLabel3.Size = new System.Drawing.Size(117, 46);
            this.averagePhotosPerAlbumLabel3.TabIndex = 39;
            this.averagePhotosPerAlbumLabel3.Text = "label1";
            this.averagePhotosPerAlbumLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalLikedPagesCountLabel2
            // 
            totalLikedPagesCountLabel2.AutoSize = true;
            totalLikedPagesCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalLikedPagesCountLabel2.Location = new System.Drawing.Point(737, 247);
            totalLikedPagesCountLabel2.Name = "totalLikedPagesCountLabel2";
            totalLikedPagesCountLabel2.Size = new System.Drawing.Size(365, 33);
            totalLikedPagesCountLabel2.TabIndex = 39;
            totalLikedPagesCountLabel2.Text = "Total Liked Pages Count:";
            totalLikedPagesCountLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalLikedPagesCountLabel3
            // 
            this.totalLikedPagesCountLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "TotalLikedPagesCount", true));
            this.totalLikedPagesCountLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLikedPagesCountLabel3.Location = new System.Drawing.Point(1163, 237);
            this.totalLikedPagesCountLabel3.Name = "totalLikedPagesCountLabel3";
            this.totalLikedPagesCountLabel3.Size = new System.Drawing.Size(126, 43);
            this.totalLikedPagesCountLabel3.TabIndex = 40;
            this.totalLikedPagesCountLabel3.Text = "label1";
            this.totalLikedPagesCountLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mostLikedCountLabel2
            // 
            mostLikedCountLabel2.AutoSize = true;
            mostLikedCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mostLikedCountLabel2.Location = new System.Drawing.Point(737, 584);
            mostLikedCountLabel2.Name = "mostLikedCountLabel2";
            mostLikedCountLabel2.Size = new System.Drawing.Size(266, 33);
            mostLikedCountLabel2.TabIndex = 40;
            mostLikedCountLabel2.Text = "Most Liked Count:";
            mostLikedCountLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mostLikedCountLabel3
            // 
            this.mostLikedCountLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "MostLikedCount", true));
            this.mostLikedCountLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostLikedCountLabel3.Location = new System.Drawing.Point(1163, 575);
            this.mostLikedCountLabel3.Name = "mostLikedCountLabel3";
            this.mostLikedCountLabel3.Size = new System.Drawing.Size(115, 42);
            this.mostLikedCountLabel3.TabIndex = 41;
            this.mostLikedCountLabel3.Text = "label1";
            this.mostLikedCountLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // friendsCountLabel2
            // 
            friendsCountLabel2.AutoSize = true;
            friendsCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            friendsCountLabel2.Location = new System.Drawing.Point(54, 247);
            friendsCountLabel2.Name = "friendsCountLabel2";
            friendsCountLabel2.Size = new System.Drawing.Size(220, 33);
            friendsCountLabel2.TabIndex = 41;
            friendsCountLabel2.Text = "Friends Count:";
            // 
            // friendsCountLabel3
            // 
            this.friendsCountLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "FriendsCount", true));
            this.friendsCountLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsCountLabel3.Location = new System.Drawing.Point(414, 237);
            this.friendsCountLabel3.Name = "friendsCountLabel3";
            this.friendsCountLabel3.Size = new System.Drawing.Size(111, 49);
            this.friendsCountLabel3.TabIndex = 42;
            this.friendsCountLabel3.Text = "label1";
            this.friendsCountLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalPostsCountLabel2
            // 
            totalPostsCountLabel2.AutoSize = true;
            totalPostsCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPostsCountLabel2.Location = new System.Drawing.Point(54, 412);
            totalPostsCountLabel2.Name = "totalPostsCountLabel2";
            totalPostsCountLabel2.Size = new System.Drawing.Size(272, 33);
            totalPostsCountLabel2.TabIndex = 42;
            totalPostsCountLabel2.Text = "Total Posts Count:";
            // 
            // totalPostsCountLabel3
            // 
            this.totalPostsCountLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "TotalPostsCount", true));
            this.totalPostsCountLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPostsCountLabel3.Location = new System.Drawing.Point(414, 390);
            this.totalPostsCountLabel3.Name = "totalPostsCountLabel3";
            this.totalPostsCountLabel3.Size = new System.Drawing.Size(125, 61);
            this.totalPostsCountLabel3.TabIndex = 43;
            this.totalPostsCountLabel3.Text = "label1";
            this.totalPostsCountLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalPhotosCountLabel2
            // 
            totalPhotosCountLabel2.AutoSize = true;
            totalPhotosCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalPhotosCountLabel2.Location = new System.Drawing.Point(54, 584);
            totalPhotosCountLabel2.Name = "totalPhotosCountLabel2";
            totalPhotosCountLabel2.Size = new System.Drawing.Size(290, 33);
            totalPhotosCountLabel2.TabIndex = 43;
            totalPhotosCountLabel2.Text = "Total Photos Count:";
            // 
            // totalPhotosCountLabel3
            // 
            this.totalPhotosCountLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "TotalPhotosCount", true));
            this.totalPhotosCountLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPhotosCountLabel3.Location = new System.Drawing.Point(414, 739);
            this.totalPhotosCountLabel3.Name = "totalPhotosCountLabel3";
            this.totalPhotosCountLabel3.Size = new System.Drawing.Size(121, 48);
            this.totalPhotosCountLabel3.TabIndex = 44;
            this.totalPhotosCountLabel3.Text = "label1";
            this.totalPhotosCountLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // totalAlbumsCountLabel2
            // 
            totalAlbumsCountLabel2.AutoSize = true;
            totalAlbumsCountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalAlbumsCountLabel2.Location = new System.Drawing.Point(54, 747);
            totalAlbumsCountLabel2.Name = "totalAlbumsCountLabel2";
            totalAlbumsCountLabel2.Size = new System.Drawing.Size(298, 33);
            totalAlbumsCountLabel2.TabIndex = 44;
            totalAlbumsCountLabel2.Text = "Total Albums Count:";
            // 
            // totalAlbumsCountLabel3
            // 
            this.totalAlbumsCountLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facadeUserStatisticsBindingSource, "TotalAlbumsCount", true));
            this.totalAlbumsCountLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAlbumsCountLabel3.Location = new System.Drawing.Point(414, 583);
            this.totalAlbumsCountLabel3.Name = "totalAlbumsCountLabel3";
            this.totalAlbumsCountLabel3.Size = new System.Drawing.Size(121, 40);
            this.totalAlbumsCountLabel3.TabIndex = 45;
            this.totalAlbumsCountLabel3.Text = "label1";
            this.totalAlbumsCountLabel3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FormUserStatistics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1367, 916);
            this.Controls.Add(totalAlbumsCountLabel2);
            this.Controls.Add(this.totalAlbumsCountLabel3);
            this.Controls.Add(totalPhotosCountLabel2);
            this.Controls.Add(this.totalPhotosCountLabel3);
            this.Controls.Add(totalPostsCountLabel2);
            this.Controls.Add(this.totalPostsCountLabel3);
            this.Controls.Add(friendsCountLabel2);
            this.Controls.Add(this.friendsCountLabel3);
            this.Controls.Add(mostLikedCountLabel2);
            this.Controls.Add(this.mostLikedCountLabel3);
            this.Controls.Add(totalLikedPagesCountLabel2);
            this.Controls.Add(this.totalLikedPagesCountLabel3);
            this.Controls.Add(averagePhotosPerAlbumLabel2);
            this.Controls.Add(this.averagePhotosPerAlbumLabel3);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonUserPhotos);
            this.Controls.Add(this.labelUserStatistics);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUserStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUserStatistics";
            this.Load += new System.EventHandler(this.FormUserStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facadeUserInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facadeUserStatisticsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserStatistics;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonUserPhotos;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.BindingSource facadeUserInfoBindingSource;
        private System.Windows.Forms.BindingSource facadeUserStatisticsBindingSource;
        private System.Windows.Forms.Label averagePhotosPerAlbumLabel3;
        private System.Windows.Forms.Label totalLikedPagesCountLabel3;
        private System.Windows.Forms.Label mostLikedCountLabel3;
        private System.Windows.Forms.Label friendsCountLabel3;
        private System.Windows.Forms.Label totalPostsCountLabel3;
        private System.Windows.Forms.Label totalPhotosCountLabel3;
        private System.Windows.Forms.Label totalAlbumsCountLabel3;
    }
}