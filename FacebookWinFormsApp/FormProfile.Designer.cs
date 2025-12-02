namespace BasicFacebookFeatures
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            this.pictureBox_Profile = new System.Windows.Forms.PictureBox();
            this.textBoxUserFullName = new System.Windows.Forms.TextBox();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.textBoxBirthdayDate = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxUserCity = new System.Windows.Forms.TextBox();
            this.textBoxUserLocation = new System.Windows.Forms.TextBox();
            this.buttonUserPhotos = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.flowLayoutPanelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.labelMyPosts = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelContactInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Profile
            // 
            this.pictureBox_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.Image")));
            this.pictureBox_Profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.InitialImage")));
            this.pictureBox_Profile.Location = new System.Drawing.Point(902, 33);
            this.pictureBox_Profile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Profile.Name = "pictureBox_Profile";
            this.pictureBox_Profile.Size = new System.Drawing.Size(222, 210);
            this.pictureBox_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Profile.TabIndex = 7;
            this.pictureBox_Profile.TabStop = false;
            // 
            // textBoxUserFullName
            // 
            this.textBoxUserFullName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserFullName.Location = new System.Drawing.Point(868, 259);
            this.textBoxUserFullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserFullName.Name = "textBoxUserFullName";
            this.textBoxUserFullName.ReadOnly = true;
            this.textBoxUserFullName.Size = new System.Drawing.Size(256, 44);
            this.textBoxUserFullName.TabIndex = 6;
            this.textBoxUserFullName.Text = "textBoxUserFullName";
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserEmail.Location = new System.Drawing.Point(868, 753);
            this.textBoxUserEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.ReadOnly = true;
            this.textBoxUserEmail.Size = new System.Drawing.Size(228, 38);
            this.textBoxUserEmail.TabIndex = 9;
            this.textBoxUserEmail.Text = "UserEmail";
            // 
            // textBoxBirthdayDate
            // 
            this.textBoxBirthdayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthdayDate.Location = new System.Drawing.Point(921, 446);
            this.textBoxBirthdayDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBirthdayDate.Name = "textBoxBirthdayDate";
            this.textBoxBirthdayDate.Size = new System.Drawing.Size(225, 38);
            this.textBoxBirthdayDate.TabIndex = 11;
            this.textBoxBirthdayDate.Text = "birthday date";
            // 
            // textBoxGender
            // 
            this.textBoxGender.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGender.Location = new System.Drawing.Point(902, 504);
            this.textBoxGender.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(222, 38);
            this.textBoxGender.TabIndex = 12;
            this.textBoxGender.Text = "user gender";
            // 
            // textBoxUserCity
            // 
            this.textBoxUserCity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCity.Location = new System.Drawing.Point(852, 803);
            this.textBoxUserCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserCity.Name = "textBoxUserCity";
            this.textBoxUserCity.ReadOnly = true;
            this.textBoxUserCity.Size = new System.Drawing.Size(222, 38);
            this.textBoxUserCity.TabIndex = 14;
            this.textBoxUserCity.Text = "user city";
            // 
            // textBoxUserLocation
            // 
            this.textBoxUserLocation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserLocation.Location = new System.Drawing.Point(924, 560);
            this.textBoxUserLocation.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUserLocation.Name = "textBoxUserLocation";
            this.textBoxUserLocation.ReadOnly = true;
            this.textBoxUserLocation.Size = new System.Drawing.Size(222, 38);
            this.textBoxUserLocation.TabIndex = 19;
            this.textBoxUserLocation.Text = "user location";
            // 
            // buttonUserPhotos
            // 
            this.buttonUserPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUserPhotos.Location = new System.Drawing.Point(1053, 922);
            this.buttonUserPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUserPhotos.Name = "buttonUserPhotos";
            this.buttonUserPhotos.Size = new System.Drawing.Size(108, 53);
            this.buttonUserPhotos.TabIndex = 25;
            this.buttonUserPhotos.Text = "Photos";
            this.buttonUserPhotos.UseVisualStyleBackColor = true;
            this.buttonUserPhotos.Click += new System.EventHandler(this.buttonUserPhotos_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(920, 922);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(108, 53);
            this.buttonHome.TabIndex = 27;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // flowLayoutPanelPosts
            // 
            this.flowLayoutPanelPosts.AutoScroll = true;
            this.flowLayoutPanelPosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPosts.Location = new System.Drawing.Point(107, 134);
            this.flowLayoutPanelPosts.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPosts.Name = "flowLayoutPanelPosts";
            this.flowLayoutPanelPosts.Size = new System.Drawing.Size(544, 749);
            this.flowLayoutPanelPosts.TabIndex = 28;
            this.flowLayoutPanelPosts.WrapContents = false;
            // 
            // labelMyPosts
            // 
            this.labelMyPosts.AutoSize = true;
            this.labelMyPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPosts.Location = new System.Drawing.Point(132, 71);
            this.labelMyPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyPosts.Name = "labelMyPosts";
            this.labelMyPosts.Size = new System.Drawing.Size(208, 51);
            this.labelMyPosts.TabIndex = 29;
            this.labelMyPosts.Text = "My Posts";
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.AutoSize = true;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStatistics.Location = new System.Drawing.Point(768, 922);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(127, 53);
            this.buttonStatistics.TabIndex = 30;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(777, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(774, 504);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 33;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(774, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 34;
            this.label4.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(774, 803);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 31);
            this.label5.TabIndex = 35;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(774, 753);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 31);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email:";
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.Location = new System.Drawing.Point(874, 375);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(121, 42);
            this.labelAbout.TabIndex = 37;
            this.labelAbout.Text = "About";
            // 
            // labelContactInfo
            // 
            this.labelContactInfo.AutoSize = true;
            this.labelContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactInfo.Location = new System.Drawing.Point(820, 666);
            this.labelContactInfo.Name = "labelContactInfo";
            this.labelContactInfo.Size = new System.Drawing.Size(230, 42);
            this.labelContactInfo.TabIndex = 38;
            this.labelContactInfo.Text = "Contact Info";
            // 
            // FormProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1206, 1008);
            this.Controls.Add(this.labelContactInfo);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.labelMyPosts);
            this.Controls.Add(this.flowLayoutPanelPosts);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonUserPhotos);
            this.Controls.Add(this.textBoxUserLocation);
            this.Controls.Add(this.textBoxUserCity);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxBirthdayDate);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.pictureBox_Profile);
            this.Controls.Add(this.textBoxUserFullName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Profile;
        private System.Windows.Forms.TextBox textBoxUserFullName;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.TextBox textBoxBirthdayDate;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxUserCity;
        private System.Windows.Forms.TextBox textBoxUserLocation;
        private System.Windows.Forms.Button buttonUserPhotos;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPosts;
        private System.Windows.Forms.Label labelMyPosts;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelContactInfo;
    }
}