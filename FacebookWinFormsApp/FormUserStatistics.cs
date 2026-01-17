using Facebook;
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
        private FacadeUserStatistics m_Facade;
        private FormMainFacebookWindow m_MainForm;
        private User m_LoggedInUser;

        public FormUserStatistics(User i_LoggedInUser, FormMainFacebookWindow i_MainForm)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_MainForm = i_MainForm;

            m_Facade = new FacadeUserStatistics(i_LoggedInUser);
        }

        private void FormUserStatistics_Load(object sender, EventArgs e)
        {
            try
            {
                facadeUserInfoBindingSource.DataSource = m_Facade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message);
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoggedInUser, m_MainForm);
            this.Close();
            profileForm.Show();
        }

        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos(m_LoggedInUser, m_MainForm);
            this.Close();
            photosForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            m_MainForm.Show();
            this.Close();
        }
    }
    //    private FacadeUserStatistics m_Facade;
    //    private FormMainFacebookWindow m_MainForm;
    //    public FormUserStatistics(FacadeUserStatistics i_Facade, FormMainFacebookWindow i_MainForm)
    //    {
    //        InitializeComponent();
    //        m_Facade = i_Facade;
    //        m_MainForm = i_MainForm;
    //    }

    //    private void FormUserStatistics_Load(object sender, EventArgs e)
    //    {
    //        facadeUserInfoBindingSource.DataSource = m_Facade;

    //        try
    //        {
    //            calculateAndDisplayStatistics();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error loading statistics: " + ex.Message);
    //        }
    //    }

    //    private void calculateAndDisplayStatistics()
    //    {
    //        displayTotalFriends();
    //        displayTotalPosts();
    //        displayTotalPhotos();
    //        displayTotalAlbums();
    //        displayTotalLikedPages();
    //        displayAveragePhotosPerAlbum();
    //        displayMostLikes();

    //    }

    //    private void displayMostLikes()
    //    {
    //        int maxLikes = m_Facade.GetMostLikedPhotoCount();
    //        //labelCountMostLikedPhoto.Text = maxLikes.ToString();


    //        //int maxLikes = 0;

    //        //try
    //        //{
    //        //    if (m_LoginResult.LoggedInUser.Albums != null)
    //        //    {
    //        //        foreach (Album album in m_LoginResult.LoggedInUser.Albums)
    //        //        {
    //        //            try
    //        //            {
    //        //                if (album.Photos == null)
    //        //                {
    //        //                    continue;
    //        //                }

    //        //                int albumMaxLikes = GetMostLikedPhotoCount(album);

    //        //                if (albumMaxLikes > maxLikes)
    //        //                {
    //        //                    maxLikes = albumMaxLikes;
    //        //                }
    //        //            }
    //        //            catch
    //        //            {
    //        //                // skip broken albums
    //        //                continue;
    //        //            }
    //        //        }
    //        //    }
    //        //}
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error finding most liked photo: " + ex.Message);
    //        //}

    //        ///* facebook's Count function doesnt work, so we put dummy data intead of maxLikes*/
    //        //labelCountMostLikedPhoto.Text = "64";
    //    }

    //    //public int GetMostLikedPhotoCount(Album album)
    //    //{

    //    //    int maxLikes = 0;
    //    //    int likes = 0;

    //    //    foreach (Photo photo in album.Photos)
    //    //    {
    //    //        if (!isValidPhoto(photo))
    //    //        {
    //    //            continue;
    //    //        }


    //    //        if (photo.LikedBy != null)
    //    //        {
    //    //            likes = photo.LikedBy.Count;
    //    //        }

    //    //        if (likes > maxLikes)
    //    //        {
    //    //            maxLikes = likes;
    //    //        }
    //    //    }

    //    //    /* facebook's Count function doesnt work, so we put dummy data intead of maxLikes*/

    //    //    return maxLikes;
    //    //}


    //    private void displayTotalFriends()
    //    {
    //        int friendsCount = m_Facade.GetFakeFriendsCount();
    //        //labelCountTotalFriends.Text = friendsCount.ToString();

    //        //try
    //        //{
    //        //    // no permissions to fetch friends amount, so fake statistic:
    //        //    int fakeAmountOfFriends = 127;
    //        //    labelCountTotalFriends.Text = fakeAmountOfFriends.ToString();

    //        //    /* if there were permissions to fetch friends, it would be:
    //        //    int totalFriends = m_LoginResult.LoggedInUser.Friends.Count;
    //        //    it should be: labelCountTotalFriends.Text = totalFriends.ToString();*/
    //        //}
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error: " + ex.Message);
    //        //}
    //    }

    //    //private int countAllPosts()
    //    //{
    //    //    int totalPosts = 0;

    //    //    try
    //    //    {
    //    //        totalPosts = m_LoginResult.LoggedInUser.Posts.Count;
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        MessageBox.Show("Error counting posts: " + ex.Message);
    //    //    }
    //    //    return totalPosts;

    //    //}

    //    //private void dummyFunctionToTriggerFetch(Post i_Post)
    //    //{
    //    //    string dummyFetch = i_Post.Message; // Trigger auto-fetch of next pages
    //    //}

    //    private void displayTotalPosts()
    //    {
    //        int totalPosts = m_Facade.GetTotalPostsCount();
    //        //labelCountTotalPosts.Text = totalPosts.ToString();




    //        //int totalPosts = 0;

    //        //try
    //        //{
    //        //    totalPosts = countAllPosts();
    //        //    labelCountTotalPosts.Text = totalPosts.ToString();
    //        //}
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error: " + ex.Message);
    //        //    labelCountTotalPosts.Text = "-1";
    //        //}
    //    }

    //    private void displayTotalPhotos()
    //    {
    //        int totalPhotos = m_Facade.GetTotalPhotosCount();
    //        //labelCountTotalPhotos.Text = totalPhotos.ToString();




    //        //int totalPhotos = 0;
    //        //try
    //        //{
    //        //    totalPhotos = countTotalPhotos();
    //        //}
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error: " + ex.Message);  
    //        //}

    //        //labelCountTotalPhotos.Text = totalPhotos.ToString();
    //    }

    //    //private int countTotalPhotos()
    //    //{
    //    //    int totalPhotos = 0;

    //    //    if (m_LoginResult.LoggedInUser.Albums != null)
    //    //    {
    //    //        foreach (Album album in m_LoginResult.LoggedInUser.Albums)
    //    //        {
    //    //            try
    //    //            {
    //    //                if (album.Photos == null)
    //    //                {
    //    //                    continue;
    //    //                }

    //    //                foreach (Photo photo in album.Photos)
    //    //                {
    //    //                    if (isValidPhoto(photo))
    //    //                    {
    //    //                        totalPhotos++;
    //    //                    }
    //    //                }
    //    //            }
    //    //            catch
    //    //            {
    //    //                // the album is broken, we skip it instead of throwing error
    //    //                continue;
    //    //            }
    //    //        }
    //    //    }
    //    //    return totalPhotos;
    //    //}

    //    private bool isValidPhoto(Photo i_Photo)
    //    {
    //        bool isValid = false;

    //        try
    //        {
    //            isValid = i_Photo != null && i_Photo.PictureNormalURL != null;
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show("Error: " + ex.Message);
    //            isValid =false;
    //        }

    //        return isValid;
    //    }

    //    private void displayTotalAlbums()
    //    {
    //        int totalAlbums = m_Facade.GetTotalAlbumsCount();
    //        //labelCountTotalAlbums.Text = totalAlbums.ToString();



    //        //int totalAlbums = 0;
    //        //try
    //        //{
    //        //    totalAlbums = m_LoginResult.LoggedInUser.Albums.Count;

    //        //}
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error: " + ex.Message);
    //        //}

    //        //labelCountTotalAlbums.Text = totalAlbums.ToString();

    //    }

    //    private void displayTotalLikedPages()
    //    {
    //        int totalLikedPages = m_Facade.GetTotalLikedPagesCount();
    //        //labelCountLikedPages.Text = totalLikedPages.ToString();



    //        //int totalLikedPages = 0;

    //        //try
    //        //{
    //        //    totalLikedPages = m_LoginResult.LoggedInUser.LikedPages.Count;

    //        //}
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error: " + ex.Message);
    //        //}

    //        //labelCountLikedPages.Text = totalLikedPages.ToString();

    //    }

    //    private void displayAveragePhotosPerAlbum()
    //    {
    //        int average = 0;
    //        int totalPhotos = m_Facade.GetTotalPhotosCount();
    //        int totalAlbums = m_Facade.GetTotalAlbumsCount();

    //        if (totalAlbums > 0)
    //        {
    //            average = totalPhotos / totalAlbums;
    //        }

    //        //labelCountAvgPhotosPerAlbum.Text = average.ToString();


    //        //int average = 0;
    //        //try
    //        //{
    //        //    average = calculateAveragePhotosPerAlbum();
    //        //                }
    //        //catch (Exception ex)
    //        //{
    //        //    MessageBox.Show("Error: " + ex.Message);
    //        //}

    //        //labelCountAvgPhotosPerAlbum.Text = average.ToString();

    //    }

    //    //private int calculateAveragePhotosPerAlbum()
    //    //{
    //    //    int average = 0;
    //    //    try
    //    //    {
    //    //        if (m_LoginResult.LoggedInUser.Albums == null || m_LoginResult.LoggedInUser.Albums.Count == 0)
    //    //        {
    //    //            average = 0;
    //    //        }

    //    //        int totalPhotos = countTotalPhotos();
    //    //        int totalAlbums = m_LoginResult.LoggedInUser.Albums.Count;

    //    //        average = totalPhotos / totalAlbums;
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        MessageBox.Show("Error: " + ex.Message);
    //    //    }

    //    //    return average;
    //    //}

    //    private void buttonProfile_Click(object sender, EventArgs e)
    //    {
    //        FormProfile profileForm = new FormProfile(m_Facade, m_MainForm);
    //        this.Close();
    //        profileForm.Show();
    //    }

    //    private void buttonUserPhotos_Click(object sender, EventArgs e)
    //    {
    //        FormPhotos photosForm = new FormPhotos(m_Facade, m_MainForm);
    //        this.Close();
    //        photosForm.Show();
    //    }

    //    private void buttonHome_Click(object sender, EventArgs e)
    //    {
    //        m_MainForm.Show();
    //        this.Close();
    //    }
    //}
}