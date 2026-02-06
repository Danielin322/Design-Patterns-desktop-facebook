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
            this.flowLayoutPanelPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelMyPhotos = new System.Windows.Forms.Label();
            this.sortByName = new System.Windows.Forms.Button();
            this.sortBySize = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(842, 242);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(224, 290);
            this.listBoxAlbums.TabIndex = 31;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelMyPhotos
            // 
            this.labelMyPhotos.AutoSize = true;
            this.labelMyPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPhotos.Location = new System.Drawing.Point(380, 106);
            this.labelMyPhotos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyPhotos.Name = "labelMyPhotos";
            this.labelMyPhotos.Size = new System.Drawing.Size(307, 65);
            this.labelMyPhotos.TabIndex = 33;
            this.labelMyPhotos.Text = "My Photos";
            // 
            // sortByName
            // 
            this.sortByName.BackColor = System.Drawing.Color.BlueViolet;
            this.sortByName.Location = new System.Drawing.Point(842, 564);
            this.sortByName.Margin = new System.Windows.Forms.Padding(4);
            this.sortByName.Name = "sortByName";
            this.sortByName.Size = new System.Drawing.Size(224, 44);
            this.sortByName.TabIndex = 37;
            this.sortByName.Text = "Sort Albums By Name";
            this.sortByName.UseVisualStyleBackColor = false;
            this.sortByName.Click += new System.EventHandler(this.sortByName_Click);
            // 
            // sortBySize
            // 
            this.sortBySize.BackColor = System.Drawing.Color.BlueViolet;
            this.sortBySize.Location = new System.Drawing.Point(842, 627);
            this.sortBySize.Margin = new System.Windows.Forms.Padding(4);
            this.sortBySize.Name = "sortBySize";
            this.sortBySize.Size = new System.Drawing.Size(224, 44);
            this.sortBySize.TabIndex = 38;
            this.sortBySize.Text = "Sort Albums By Size";
            this.sortBySize.UseVisualStyleBackColor = false;
            this.sortBySize.Click += new System.EventHandler(this.sortBySize_Click);
            // 
            // FormPhotos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1178, 999);
            this.Controls.Add(this.sortBySize);
            this.Controls.Add(this.sortByName);
            this.Controls.Add(this.labelMyPhotos);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(this.flowLayoutPanelPhotos);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPhotos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhotos";
            this.Load += new System.EventHandler(this.FormPhotos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhotos;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelMyPhotos;
        private System.Windows.Forms.Button sortByName;
        private System.Windows.Forms.Button sortBySize;
    }
}