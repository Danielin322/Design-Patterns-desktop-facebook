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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BasicFacebookFeatures
{
    public partial class FormMainFacebookWindow : Form
    {
        private LoginResult m_LoginResult;
        public FormMainFacebookWindow(LoginResult loginResult)
        {
            m_LoginResult = loginResult;
            InitializeComponent();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoginResult);
            this.Close();
            profileForm.Show();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            // move to friends form (dont forget to give the user option to go back)
        }
        

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Close();   
        }


        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos(m_LoginResult);
            this.Close();
            photosForm.Show();
        }

       

        private void FormMainFacebookWindow_Load(object sender, EventArgs e)
        {
            // Show picture of user
            pictureBox_Profile.LoadAsync(m_LoginResult.LoggedInUser.PictureNormalURL);

            //show user name
            textBoxUserFullName.Text = m_LoginResult.LoggedInUser.Name;

            // Enable user to log out
            buttonLogout.Enabled = true;
            
            fetchLikedPages();

        }

        private void buttonPublishPost_Click(object sender, EventArgs e)
        {
            textBoxNewPost.Clear();
            MessageBox.Show("Post published successfully! (not really...)");

        }



        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoginResult.LoggedInUser.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
