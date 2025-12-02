using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormProfile : Form
    {
        private LoginResult m_LoginResult;

        public FormProfile(LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            InitializeComponent();
        }

         private void FormProfile_Load(object sender, EventArgs e)
        {
            if (m_LoginResult?.LoggedInUser == null)
            {
                MessageBox.Show("Login failed or user data not available.");
                this.Close();
                return;
            }

            // Show picture of user
            if (!string.IsNullOrEmpty(m_LoginResult.LoggedInUser.PictureNormalURL))
            {
                pictureBox_Profile.LoadAsync(m_LoginResult.LoggedInUser.PictureNormalURL);
            }

            // if some of the info is missing, we show empty string
            textBoxUserFullName.Text = m_LoginResult.LoggedInUser.Name ?? "";
            textBoxBirthdayDate.Text = m_LoginResult.LoggedInUser.Birthday ?? "";
            textBoxUserCity.Text = m_LoginResult.LoggedInUser.Location?.Name ?? "";
            textBoxUserEmail.Text = m_LoginResult.LoggedInUser.Email ?? "";
            textBoxUserLocation.Text = m_LoginResult.LoggedInUser.Hometown?.Name ?? "";
            textBoxGender.Text = m_LoginResult.LoggedInUser.Gender?.ToString() ?? "";

            fetchPosts();
        }

        private void fetchPosts()
        {
            try
            {
                flowLayoutPanelPosts.Controls.Clear();

                foreach (Post post in m_LoginResult.LoggedInUser.Posts)
                {
                    string content = null;

                    if (post.Message != null)
                    {                       
                        content = post.Message;
                    }
                    else if (post.Caption != null)
                    {
                        content = post.Caption;
                    }
                    else
                    {
                        content = string.Format("[{0}]", post.Type);
                    }

                    if (!string.IsNullOrEmpty(content))
                    {
                        addPostToFlowPanel(content);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addPostToFlowPanel(string i_PostText)
        {
            Label postLabel = new Label();

            postLabel.AutoSize = false;
            postLabel.Width = flowLayoutPanelPosts.Width - 30;
            postLabel.Padding = new Padding(10);
            postLabel.Margin = new Padding(5);
            postLabel.Text = i_PostText;
            postLabel.BackColor = Color.White;
            postLabel.BorderStyle = BorderStyle.FixedSingle;
            postLabel.Font = new Font("Segoe UI", 10);
            postLabel.Height = TextRenderer.MeasureText(i_PostText, postLabel.Font, new Size(postLabel.Width, int.MaxValue)).Height + 20;
            flowLayoutPanelPosts.Controls.Add(postLabel);
        }

        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos(m_LoginResult);
            this.Close();
            photosForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormUserStatistics formStats = new FormUserStatistics(m_LoginResult);
            this.Close();
            formStats.Show();
        }
    }
}