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
        public FormUserStatistics(LoginResult loginResult)
        {
            InitializeComponent();
            m_LoginResult = loginResult;
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
            //displayMostActiveAlbum(); /////// needed?
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
                labelCountTotalFriends.Text = "-1";
            }

        }

        private void displayTotalPosts()
        {
            try
            {
                int totalPosts = m_LoginResult.LoggedInUser.Posts.Count;
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
                return 0;
            }

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
                        if (IsValidPhoto(photo))
                        {
                            totalPhotos++;
                        }
                    }
                }
                catch
                {
                    // album is broken
                    // skip it silently or show message
                    // MessageBox.Show("Problem loading album.");
                    continue;
                }
            }

            return totalPhotos;
        }

        //private int countTotalPhotos()
        //{
        //    int totalPhotos = 0;

        //    if (m_LoginResult.LoggedInUser.Albums != null)
        //    {
        //        try
        //        {
        //            foreach (Album album in m_LoginResult.LoggedInUser.Albums)
        //            {
        //                if (album.Photos != null)
        //                {
        //                    try
        //                    {
        //                        foreach (Photo photo in album.Photos)
        //                        {
        //                            if (IsValidPhoto(photo))
        //                            {
        //                                totalPhotos++;
        //                            }
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        MessageBox.Show("Error: " + ex.Message);

        //                        MessageBox.Show("Unable to load this album.");
        //                    }
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);

        //            return -2;
        //        }

        //    }

        //    return totalPhotos;
        //}

        private bool IsValidPhoto(Photo photo)
        {
            try
            {
                return photo != null && photo.PictureNormalURL != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                return false;
            }
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

        //private void displayMostActiveAlbum()
        //{
        //    Album mostActiveAlbum = null;

        //    int maxPhotos = 0;

        //    foreach (Album album in m_LoginResult.LoggedInUser.Albums)
        //    {
        //        if (album.Photos != null && album.Photos.Count > maxPhotos)
        //        {
        //            maxPhotos = album.Photos.Count;
        //            mostActiveAlbum = album;
        //        }
        //    }
        //    labelMostActiveAlbum.Text = mostActiveAlbum != null ? mostActiveAlbum.Name : "N/A";
        //}

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
            try
            {
                if (m_LoginResult.LoggedInUser.Albums == null || m_LoginResult.LoggedInUser.Albums.Count == 0)
                {
                    return 0;
                }

                int totalPhotos = countTotalPhotos();
                int totalAlbums = m_LoginResult.LoggedInUser.Albums.Count;

                return totalPhotos / totalAlbums;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

                return -2;
            }


        }


    }
}
