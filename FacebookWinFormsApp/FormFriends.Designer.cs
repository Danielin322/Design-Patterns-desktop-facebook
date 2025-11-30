namespace BasicFacebookFeatures
{
    partial class FormFriends
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
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.textBoxFriendsTitle = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.FriendName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewFriends
            // 
            this.listViewFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FriendName,
            this.Action});
            this.listViewFriends.HideSelection = false;
            this.listViewFriends.Location = new System.Drawing.Point(158, 184);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(1085, 910);
            this.listViewFriends.TabIndex = 0;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            this.listViewFriends.View = System.Windows.Forms.View.Details;
            // 
            // textBoxFriendsTitle
            // 
            this.textBoxFriendsTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxFriendsTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFriendsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFriendsTitle.Location = new System.Drawing.Point(1068, 86);
            this.textBoxFriendsTitle.Name = "textBoxFriendsTitle";
            this.textBoxFriendsTitle.Size = new System.Drawing.Size(175, 55);
            this.textBoxFriendsTitle.TabIndex = 1;
            this.textBoxFriendsTitle.Text = "Friends";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(161, 107);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(290, 31);
            this.textBoxSearchName.TabIndex = 2;
            this.textBoxSearchName.Text = "friends name";
            // 
            // buttonSearchName
            // 
            this.buttonSearchName.Location = new System.Drawing.Point(477, 105);
            this.buttonSearchName.Name = "buttonSearchName";
            this.buttonSearchName.Size = new System.Drawing.Size(111, 32);
            this.buttonSearchName.TabIndex = 3;
            this.buttonSearchName.Text = "search";
            this.buttonSearchName.UseVisualStyleBackColor = true;
            this.buttonSearchName.Click += new System.EventHandler(this.buttonSearchName_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1203, 1127);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(144, 66);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FriendName
            // 
            this.FriendName.Width = 250;
            // 
            // Action
            // 
            this.Action.Width = 100;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 1223);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSearchName);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.textBoxFriendsTitle);
            this.Controls.Add(this.listViewFriends);
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            this.Load += new System.EventHandler(this.FormFriends_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.TextBox textBoxFriendsTitle;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearchName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ColumnHeader FriendName;
        private System.Windows.Forms.ColumnHeader Action;
    }
}