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
            this.textBoxUserFullName = new System.Windows.Forms.TextBox();
            this.pictureBox_Profile = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.labelPost = new System.Windows.Forms.Label();
            this.buttonPublishPost = new System.Windows.Forms.Button();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.LablePagesYouLiked = new System.Windows.Forms.Label();
            this.RichTextBoxNewPost = new System.Windows.Forms.RichTextBox();
            this.colorDialogPost = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.pictureBox_Profile.Size = new System.Drawing.Size(212, 203);
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
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPost.Location = new System.Drawing.Point(491, 299);
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
            this.buttonPublishPost.BackColor = System.Drawing.Color.MediumPurple;
            this.buttonPublishPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublishPost.Location = new System.Drawing.Point(973, 743);
            this.buttonPublishPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPublishPost.Name = "buttonPublishPost";
            this.buttonPublishPost.Size = new System.Drawing.Size(126, 50);
            this.buttonPublishPost.TabIndex = 10;
            this.buttonPublishPost.Text = "Publish";
            this.buttonPublishPost.UseVisualStyleBackColor = false;
            this.buttonPublishPost.Click += new System.EventHandler(this.buttonPublishPost_Click);
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 31;
            this.listBoxLikedPages.Location = new System.Drawing.Point(7, 100);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxLikedPages.Size = new System.Drawing.Size(408, 624);
            this.listBoxLikedPages.TabIndex = 11;
            // 
            // LablePagesYouLiked
            // 
            this.LablePagesYouLiked.AutoSize = true;
            this.LablePagesYouLiked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LablePagesYouLiked.Location = new System.Drawing.Point(11, 30);
            this.LablePagesYouLiked.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LablePagesYouLiked.Name = "LablePagesYouLiked";
            this.LablePagesYouLiked.Size = new System.Drawing.Size(394, 37);
            this.LablePagesYouLiked.TabIndex = 12;
            this.LablePagesYouLiked.Text = "Pages you recently liked:";
            // 
            // RichTextBoxNewPost
            // 
            this.RichTextBoxNewPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBoxNewPost.Location = new System.Drawing.Point(468, 428);
            this.RichTextBoxNewPost.Name = "RichTextBoxNewPost";
            this.RichTextBoxNewPost.Size = new System.Drawing.Size(664, 277);
            this.RichTextBoxNewPost.TabIndex = 13;
            this.RichTextBoxNewPost.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonColor,
            this.toolStripSeparator5,
            this.toolStripButtonBold,
            this.toolStripSeparator4,
            this.toolStripButtonUnderline,
            this.toolStripSeparator3,
            this.toolStripButtonClear,
            this.toolStripSeparator2,
            this.toolStripButtonUndo,
            this.toolStripSeparator1,
            this.toolStripButtonRedo});
            this.toolStrip1.Location = new System.Drawing.Point(659, 801);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(497, 50);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonColor
            // 
            this.toolStripButtonColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonColor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonColor.Image")));
            this.toolStripButtonColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonColor.Name = "toolStripButtonColor";
            this.toolStripButtonColor.Size = new System.Drawing.Size(71, 44);
            this.toolStripButtonColor.Text = "color";
            this.toolStripButtonColor.Click += new System.EventHandler(this.toolStripButtonColor_Click);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBold.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonBold.Text = "B";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUnderline.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(46, 44);
            this.toolStripButtonUnderline.Text = "U";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripButtonClear
            // 
            this.toolStripButtonClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClear.Image")));
            this.toolStripButtonClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClear.Name = "toolStripButtonClear";
            this.toolStripButtonClear.Size = new System.Drawing.Size(72, 44);
            this.toolStripButtonClear.Text = "Clear";
            this.toolStripButtonClear.Click += new System.EventHandler(this.toolStripButtonClear_Click);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(76, 44);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(72, 44);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // FormMainFacebookWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1169, 943);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.RichTextBoxNewPost);
            this.Controls.Add(this.LablePagesYouLiked);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.buttonPublishPost);
            this.Controls.Add(this.labelPost);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.pictureBox_Profile);
            this.Controls.Add(this.textBoxUserFullName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainFacebookWindow";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookWindow";
            this.Load += new System.EventHandler(this.FormMainFacebookWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Profile)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUserFullName;
        private System.Windows.Forms.PictureBox pictureBox_Profile;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Button buttonPublishPost;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Label LablePagesYouLiked;
        private System.Windows.Forms.RichTextBox RichTextBoxNewPost;
        private System.Windows.Forms.ColorDialog colorDialogPost;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonColor;
        private System.Windows.Forms.ToolStripButton toolStripButtonBold;
        private System.Windows.Forms.ToolStripButton toolStripButtonUnderline;
        private System.Windows.Forms.ToolStripButton toolStripButtonClear;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}