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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxBirthdayDate = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxContactDetails = new System.Windows.Forms.TextBox();
            this.textBoxUserCity = new System.Windows.Forms.TextBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonSeeFriends = new System.Windows.Forms.Button();
            this.listBoxPhotos = new System.Windows.Forms.ListBox();
            this.buttonSeeAllPhotos = new System.Windows.Forms.Button();
            this.textBoxUserLocation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxLikesByUser = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Profile
            // 
            this.pictureBox_Profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Profile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.Image")));
            this.pictureBox_Profile.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Profile.InitialImage")));
            this.pictureBox_Profile.Location = new System.Drawing.Point(1148, 41);
            this.pictureBox_Profile.Name = "pictureBox_Profile";
            this.pictureBox_Profile.Size = new System.Drawing.Size(251, 236);
            this.pictureBox_Profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Profile.TabIndex = 7;
            this.pictureBox_Profile.TabStop = false;
            // 
            // textBoxUserFullName
            // 
            this.textBoxUserFullName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserFullName.Location = new System.Drawing.Point(1058, 324);
            this.textBoxUserFullName.Name = "textBoxUserFullName";
            this.textBoxUserFullName.ReadOnly = true;
            this.textBoxUserFullName.Size = new System.Drawing.Size(341, 44);
            this.textBoxUserFullName.TabIndex = 6;
            this.textBoxUserFullName.Text = "textBoxUserFullName";
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserEmail.Location = new System.Drawing.Point(1110, 1055);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.ReadOnly = true;
            this.textBoxUserEmail.Size = new System.Drawing.Size(303, 38);
            this.textBoxUserEmail.TabIndex = 9;
            this.textBoxUserEmail.Text = "textBoxUserEmail";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1100, 447);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(301, 49);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "about (the title)";
            // 
            // textBoxBirthdayDate
            // 
            this.textBoxBirthdayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthdayDate.Location = new System.Drawing.Point(1100, 557);
            this.textBoxBirthdayDate.Name = "textBoxBirthdayDate";
            this.textBoxBirthdayDate.Size = new System.Drawing.Size(299, 38);
            this.textBoxBirthdayDate.TabIndex = 11;
            this.textBoxBirthdayDate.Text = "birthday date";
            this.textBoxBirthdayDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxGender
            // 
            this.textBoxGender.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGender.Location = new System.Drawing.Point(1104, 630);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.ReadOnly = true;
            this.textBoxGender.Size = new System.Drawing.Size(295, 38);
            this.textBoxGender.TabIndex = 12;
            this.textBoxGender.Text = "user gender";
            // 
            // textBoxContactDetails
            // 
            this.textBoxContactDetails.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactDetails.Location = new System.Drawing.Point(983, 977);
            this.textBoxContactDetails.Name = "textBoxContactDetails";
            this.textBoxContactDetails.ReadOnly = true;
            this.textBoxContactDetails.Size = new System.Drawing.Size(424, 49);
            this.textBoxContactDetails.TabIndex = 13;
            this.textBoxContactDetails.Text = "Contact details (the title)";
            this.textBoxContactDetails.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // textBoxUserCity
            // 
            this.textBoxUserCity.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserCity.Location = new System.Drawing.Point(1110, 1118);
            this.textBoxUserCity.Name = "textBoxUserCity";
            this.textBoxUserCity.ReadOnly = true;
            this.textBoxUserCity.Size = new System.Drawing.Size(295, 38);
            this.textBoxUserCity.TabIndex = 14;
            this.textBoxUserCity.Text = "user city";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 25;
            this.listBoxPosts.Location = new System.Drawing.Point(118, 74);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(794, 329);
            this.listBoxPosts.TabIndex = 15;
            // 
            // buttonSeeFriends
            // 
            this.buttonSeeFriends.Location = new System.Drawing.Point(1104, 766);
            this.buttonSeeFriends.Name = "buttonSeeFriends";
            this.buttonSeeFriends.Size = new System.Drawing.Size(292, 53);
            this.buttonSeeFriends.TabIndex = 16;
            this.buttonSeeFriends.Text = "see all friends";
            this.buttonSeeFriends.UseVisualStyleBackColor = true;
            this.buttonSeeFriends.Click += new System.EventHandler(this.buttonSeeFriends_Click);
            // 
            // listBoxPhotos
            // 
            this.listBoxPhotos.FormattingEnabled = true;
            this.listBoxPhotos.ItemHeight = 25;
            this.listBoxPhotos.Location = new System.Drawing.Point(118, 889);
            this.listBoxPhotos.Name = "listBoxPhotos";
            this.listBoxPhotos.Size = new System.Drawing.Size(687, 204);
            this.listBoxPhotos.TabIndex = 17;
            // 
            // buttonSeeAllPhotos
            // 
            this.buttonSeeAllPhotos.Location = new System.Drawing.Point(118, 1111);
            this.buttonSeeAllPhotos.Name = "buttonSeeAllPhotos";
            this.buttonSeeAllPhotos.Size = new System.Drawing.Size(233, 57);
            this.buttonSeeAllPhotos.TabIndex = 18;
            this.buttonSeeAllPhotos.Text = "see all photos";
            this.buttonSeeAllPhotos.UseVisualStyleBackColor = true;
            this.buttonSeeAllPhotos.Click += new System.EventHandler(this.buttonSeeAllPhotos_Click);
            // 
            // textBoxUserLocation
            // 
            this.textBoxUserLocation.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxUserLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserLocation.Location = new System.Drawing.Point(1104, 700);
            this.textBoxUserLocation.Name = "textBoxUserLocation";
            this.textBoxUserLocation.ReadOnly = true;
            this.textBoxUserLocation.Size = new System.Drawing.Size(295, 38);
            this.textBoxUserLocation.TabIndex = 19;
            this.textBoxUserLocation.Text = "user location";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 766);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "see all likes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxLikesByUser
            // 
            this.listBoxLikesByUser.FormattingEnabled = true;
            this.listBoxLikesByUser.ItemHeight = 25;
            this.listBoxLikesByUser.Location = new System.Drawing.Point(118, 543);
            this.listBoxLikesByUser.Name = "listBoxLikesByUser";
            this.listBoxLikesByUser.Size = new System.Drawing.Size(687, 204);
            this.listBoxLikesByUser.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 57);
            this.button2.TabIndex = 22;
            this.button2.Text = "see all posts";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 1246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxLikesByUser);
            this.Controls.Add(this.textBoxUserLocation);
            this.Controls.Add(this.buttonSeeAllPhotos);
            this.Controls.Add(this.listBoxPhotos);
            this.Controls.Add(this.buttonSeeFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.textBoxUserCity);
            this.Controls.Add(this.textBoxContactDetails);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.textBoxBirthdayDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.pictureBox_Profile);
            this.Controls.Add(this.textBoxUserFullName);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Profile;
        private System.Windows.Forms.TextBox textBoxUserFullName;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxBirthdayDate;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxContactDetails;
        private System.Windows.Forms.TextBox textBoxUserCity;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button buttonSeeFriends;
        private System.Windows.Forms.ListBox listBoxPhotos;
        private System.Windows.Forms.Button buttonSeeAllPhotos;
        private System.Windows.Forms.TextBox textBoxUserLocation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxLikesByUser;
        private System.Windows.Forms.Button button2;
    }
}