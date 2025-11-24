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
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonSearchName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(158, 184);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1085, 977);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(949, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 62);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Friends";
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
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 1223);
            this.Controls.Add(this.buttonSearchName);
            this.Controls.Add(this.textBoxSearchName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Name = "FormFriends";
            this.Text = "FormFriends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Button buttonSearchName;
    }
}