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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Page = FacebookWrapper.ObjectModel.Page;

namespace BasicFacebookFeatures
{
    public sealed partial class FormMainFacebookWindow : Form
    {
        private static FormMainFacebookWindow s_Instance = null;
        private static readonly object s_Lock = new object();
        private FacadeMainWindow m_Facade;
        private User m_LoggedInUser;

        private FormMainFacebookWindow(User i_LoggedInUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_Facade = new FacadeMainWindow(m_LoggedInUser);
        }

        public static FormMainFacebookWindow GetInstance(User i_LoggedInUser)
        {
            if (s_Instance == null)
            {
                lock (s_Lock)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new FormMainFacebookWindow(i_LoggedInUser);
                    }
                }
            }
            return s_Instance;
        }

        private void FormMainFacebookWindow_Load(object sender, EventArgs e)
        {
            List<System.Windows.Forms.Button> navButtons = NavigationButtonsFactory.CreateButtons(NavigationButtonsFactory.eButtonTypes.home, this, this, m_LoggedInUser);

            foreach (System.Windows.Forms.Button btn in navButtons)
            {
                this.Controls.Add(btn);
            }
            loadBasicUserInfo();
            fetchLikedPages();
        }

        private void loadBasicUserInfo()
        {
            string profileUrl = m_Facade.GetProfilePictureURL();

            if (profileUrl != null)
            {
                pictureBox_Profile.LoadAsync(profileUrl);
            }

            textBoxUserFullName.Text = m_Facade.GetUserName();
            buttonLogout.Enabled = true;
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                List<Page> pages = m_Facade.GetLikedPages();

                if (pages.Count > 0)
                {
                    foreach (Page page in pages)
                    {
                        listBoxLikedPages.Items.Add(page);
                    }
                }
                else
                {
                    listBoxLikedPages.Items.Add("No liked pages found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching liked pages: " + ex.Message);
            }
        }

        private void buttonPublishPost_Click(object sender, EventArgs e)
        {
            m_Facade.PublishPost(textBoxNewPost.Text);
            MessageBox.Show("Post published successfully! (not really...)");
            textBoxNewPost.Clear();
        }


        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoggedInUser, this);
            this.Hide();
            profileForm.Show();
        }

        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos(m_LoggedInUser, this);
            this.Hide();
            photosForm.Show();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormUserStatistics formStats = new FormUserStatistics(m_LoggedInUser, this);
            this.Hide();
            formStats.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Close();
        }

        private void SpecialMomentsCollage_Click(object sender, EventArgs e)
        {
            FormCollageOfPhotos collageForm = new FormCollageOfPhotos(m_LoggedInUser, this);
            this.Hide();
            collageForm.Show();
        }
    }
}