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

        public FormProfile(LoginResult loginResult)
        {
            m_LoginResult = loginResult;
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonSeeAllPhotos_Click(object sender, EventArgs e)
        {
            // move to the same form that the button "photos" from main sends us
        }

        private void buttonSeeFriends_Click(object sender, EventArgs e)
        {
            // move to the same form that the button "friends" from main sends us
        }

        private void FormProfile_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            // Show picture of user
            pictureBox_Profile.LoadAsync(m_LoginResult.LoggedInUser.PictureNormalURL);

            //show user name
            textBoxUserFullName.Text = m_LoginResult.LoggedInUser.Name;

            textBoxBirthdayDate.Text = m_LoginResult.LoggedInUser.Birthday;
            textBoxContactDetails.Text = m_LoginResult.LoggedInUser.Link;
            textBoxUserCity.Text = m_LoginResult.LoggedInUser.Location.Name;
            textBoxUserEmail.Text = m_LoginResult.LoggedInUser.Email;   
            textBoxUserLocation.Text = m_LoginResult.LoggedInUser.Hometown.Name;
            textBoxGender.Text = m_LoginResult.LoggedInUser.Gender.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                fetchPosts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Items.Clear();

            foreach (Post post in m_LoginResult.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }
    }
}
