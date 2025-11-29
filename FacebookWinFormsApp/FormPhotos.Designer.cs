namespace BasicFacebookFeatures
{
    partial class FormPhotos
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
            this.buttonUserPhotos = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserPhotos
            // 
            this.buttonUserPhotos.Location = new System.Drawing.Point(860, 1106);
            this.buttonUserPhotos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUserPhotos.Name = "buttonUserPhotos";
            this.buttonUserPhotos.Size = new System.Drawing.Size(144, 66);
            this.buttonUserPhotos.TabIndex = 28;
            this.buttonUserPhotos.Text = "Photos";
            this.buttonUserPhotos.UseVisualStyleBackColor = true;
            // 
            // buttonFriends
            // 
            this.buttonFriends.Location = new System.Drawing.Point(1046, 1106);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(144, 66);
            this.buttonFriends.TabIndex = 27;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(1236, 1106);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(144, 66);
            this.buttonProfile.TabIndex = 26;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // flowLayoutPanelPhotos
            // 
            this.flowLayoutPanelPhotos.AutoScroll = true;
            this.flowLayoutPanelPhotos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPhotos.Location = new System.Drawing.Point(55, 302);
            this.flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            this.flowLayoutPanelPhotos.Size = new System.Drawing.Size(1361, 784);
            this.flowLayoutPanelPhotos.TabIndex = 30;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 25;
            this.listBoxAlbums.Location = new System.Drawing.Point(1102, 39);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(297, 229);
            this.listBoxAlbums.TabIndex = 31;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(682, 1106);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(144, 66);
            this.buttonHome.TabIndex = 32;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 1229);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.flowLayoutPanelPhotos);
            this.Controls.Add(this.buttonUserPhotos);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.buttonProfile);
            this.Name = "FormPhotos";
            this.Text = "FormPhotos";
            this.Load += new System.EventHandler(this.FormPhotos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserPhotos;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonHome;
    }
}