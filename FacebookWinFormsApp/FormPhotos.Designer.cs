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
            this.buttonProfile = new System.Windows.Forms.Button();
            this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.labelMyPhotos = new System.Windows.Forms.Label();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(931, 901);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(108, 53);
            this.buttonProfile.TabIndex = 26;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // flowLayoutPanelPhotos
            // 
            this.flowLayoutPanelPhotos.AutoScroll = true;
            this.flowLayoutPanelPhotos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPhotos.Location = new System.Drawing.Point(41, 242);
            this.flowLayoutPanelPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanelPhotos.Name = "flowLayoutPanelPhotos";
            this.flowLayoutPanelPhotos.Size = new System.Drawing.Size(764, 627);
            this.flowLayoutPanelPhotos.TabIndex = 30;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 29;
            this.listBoxAlbums.Location = new System.Drawing.Point(842, 242);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(224, 294);
            this.listBoxAlbums.TabIndex = 31;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(795, 901);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(108, 53);
            this.buttonHome.TabIndex = 32;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // labelMyPhotos
            // 
            this.labelMyPhotos.AutoSize = true;
            this.labelMyPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPhotos.Location = new System.Drawing.Point(380, 106);
            this.labelMyPhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyPhotos.Name = "labelMyPhotos";
            this.labelMyPhotos.Size = new System.Drawing.Size(401, 85);
            this.labelMyPhotos.TabIndex = 33;
            this.labelMyPhotos.Text = "My Photos";
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(667, 901);
            this.buttonStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(108, 53);
            this.buttonStatistics.TabIndex = 34;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // FormPhotos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1178, 999);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.labelMyPhotos);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.flowLayoutPanelPhotos);
            this.Controls.Add(this.buttonProfile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhotos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPhotos_FormClosing);
            this.Load += new System.EventHandler(this.FormPhotos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Label labelMyPhotos;
        private System.Windows.Forms.Button buttonStatistics;
    }
}