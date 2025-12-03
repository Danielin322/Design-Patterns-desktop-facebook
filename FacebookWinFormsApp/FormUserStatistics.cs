using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BasicFacebookFeatures
{
    public partial class FormUserStatistics : Form
    {
        private LoginResult m_LoginResult;
        private FormMainFacebookWindow m_MainForm;
        public FormUserStatistics(LoginResult i_LoginResult, FormMainFacebookWindow i_MainForm)
        {
            InitializeComponent();
            m_LoginResult = i_LoginResult;
            m_MainForm = i_MainForm;
        }

        private void FormUserStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                calculateAndDisplayStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        private void calculateAndDisplayStatistics()
        {
            displayTotalFriends();
            displayTotalPosts();
            displayTotalPhotos();
            displayTotalAlbums();
            displayTotalLikedPages();
            displayAveragePhotosPerAlbum();
        }

        private void displayTotalFriends()
        {
            try
            {
                // no permissions to fetch friends amount, so fake statistic:
                int fakeAmountOfFriends = 127;
                labelCountTotalFriends.Text = fakeAmountOfFriends.ToString();

                /* if there were permissions to fetch friends, it would be:
                int totalFriends = m_LoginResult.LoggedInUser.Friends.Count;
                it should be: labelCountTotalFriends.Text = totalFriends.ToString();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int countAllPosts()
        {
            int totalPosts = 0;
            string dummyFetch = null;

            foreach (Post post in m_LoginResult.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    dummyFetch = post.Message;
                }
                else if (post.Caption != null)
                {
                    dummyFetch = post.Caption;
                }

                dummyFunctionToTriggerFetch(post); // Trigger auto-fetch of next pages
                totalPosts++;
            }

            return totalPosts;
        }

        private void dummyFunctionToTriggerFetch(Post i_Post)
        {
            string dummyFetch = i_Post.Message; // Trigger auto-fetch of next pages
        }

        private void displayTotalPosts()
        {
            int totalPosts = 0;

            try
            {
                totalPosts = countAllPosts();
                labelCountTotalPosts.Text = totalPosts.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                labelCountTotalPosts.Text = "-1";
            }
        }

        private void displayTotalPhotos()
        {
            try
            {
                int totalPhotos = countTotalPhotos();
                labelCountTotalPhotos.Text = totalPhotos.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                labelCountTotalPhotos.Text = "-1";
            }
        }

        private int countTotalPhotos()
        {
            int totalPhotos = 0;

            if (m_LoginResult.LoggedInUser.Albums == null)
            {
                foreach (Album album in m_LoginResult.LoggedInUser.Albums)
                {
                    try
                    {
                        if (album.Photos == null)
                        {
                            continue;
                        }

                        foreach (Photo photo in album.Photos)
                        {
                            if (isValidPhoto(photo))
                            {
                                totalPhotos++;
                            }
                        }
                    }
                    catch
                    {
                        // the album is broken, we skip it instead of throwing error
                        continue;
                    }
                }
            }
            return totalPhotos;
        }

        private bool isValidPhoto(Photo i_Photo)
        {
            bool isValid = false;

            try
            {
                isValid = i_Photo != null && i_Photo.PictureNormalURL != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                isValid =false;
            }

            return isValid;
        }

        private void displayTotalAlbums()
        {
            try
            {
                int totalAlbums = m_LoginResult.LoggedInUser.Albums.Count;
                labelCountTotalAlbums.Text = totalAlbums.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                labelCountTotalAlbums.Text = "-1";
            }
        }

        private void displayTotalLikedPages()
        {
            try
            {
                int totalLikedPages = m_LoginResult.LoggedInUser.LikedPages.Count;
                
                labelCountLikedPages.Text = totalLikedPages.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                labelCountLikedPages.Text = "-1";
            }
        }

        private void displayAveragePhotosPerAlbum()
        {
            try
            {
                int average = calculateAveragePhotosPerAlbum();
                
                labelCountAvgPhotosPerAlbum.Text = average.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                labelCountAvgPhotosPerAlbum.Text = "-1";
            }
        }

        private int calculateAveragePhotosPerAlbum()
        {
            int average = -2;
            try
            {
                if (m_LoginResult.LoggedInUser.Albums == null || m_LoginResult.LoggedInUser.Albums.Count == 0)
                {
                    average = 0;
                }

                int totalPhotos = countTotalPhotos();
                int totalAlbums = m_LoginResult.LoggedInUser.Albums.Count;

                average = totalPhotos / totalAlbums;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                average = -2;
            }

            return average;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoginResult, m_MainForm);
            this.Close();
            profileForm.Show();
        }

        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos(m_LoginResult,m_MainForm);
            this.Close();
            photosForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            m_MainForm.Show();
            this.Close();
        }
    }
}