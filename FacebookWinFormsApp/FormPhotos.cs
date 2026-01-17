using FacebookWrapper.ObjectModel;
using FacebookWrapper;
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
    public partial class FormPhotos : Form
    {
        private FacadePhotos m_Facade;
        private FormMainFacebookWindow m_MainForm;
        private User m_LoggedInUser;

        public FormPhotos(User i_LoggedInUser, FormMainFacebookWindow i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_MainForm = i_MainForm;
            m_Facade = new FacadePhotos(i_LoggedInUser);

            InitializeComponent();
        }

        private void FormPhotos_Load(object sender, EventArgs e)
        {
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            try
            {
                listBoxAlbums.Items.Clear();
                listBoxAlbums.DisplayMember = "Name";

                FacebookObjectCollection<Album> albums = m_Facade.GetUserAlbums();

                if (albums != null && albums.Count > 0)
                {
                    foreach (Album album in albums)
                    {
                        listBoxAlbums.Items.Add(album);
                    }
                }
                else
                {
                    MessageBox.Show("No Albums to retrieve :(");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching albums: " + ex.Message);
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                flowLayoutPanelPhotos.Controls.Clear();
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

                if (selectedAlbum == null)
                {
                    MessageBox.Show("Unable to load this album.");
                    return;
                }

                try
                {
                    List<Photo> photosToShow = m_Facade.GetValidPhotosFromAlbum(selectedAlbum);

                    foreach (Photo photo in photosToShow)
                    {
                        addPhotoToLayoutPanel(photo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading photos: " + ex.Message);
                }
            }
        }

        private void addPhotoToLayoutPanel(Photo i_Photo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.LoadAsync(i_Photo.PictureNormalURL);
            flowLayoutPanelPhotos.Controls.Add(pictureBox);
        }


        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoggedInUser, m_MainForm);
            this.Close();
            profileForm.Show();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormUserStatistics formStats = new FormUserStatistics(m_LoggedInUser, m_MainForm);
            this.Close();
            formStats.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            m_MainForm.Show();
            this.Close();
        }


        //private FacadeUserInfo m_Facade;
        //private FormMainFacebookWindow m_MainForm;
        //public FormPhotos(FacadeUserInfo i_Facade, FormMainFacebookWindow i_MainForm)
        //{
        //    m_Facade = i_Facade;
        //    m_MainForm = i_MainForm;
        //    InitializeComponent();
        //}

        //private void FormPhotos_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        fetchAlbums();
        //    }
        //    catch (KeyNotFoundException)
        //    {
        //        // We solve this error, so the exception is not needed in this case
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void fetchAlbums()
        //{
        //    listBoxAlbums.Items.Clear();
        //    listBoxAlbums.DisplayMember = "Name";

        //    if (m_Facade.LoggedInUser != null && m_Facade.LoggedInUser.Albums != null)
        //    {
        //        foreach (Album album in m_Facade.LoggedInUser.Albums)
        //        {
        //            listBoxAlbums.Items.Add(album);
        //        }
        //    }

        //    if (listBoxAlbums.Items.Count == 0)
        //    {
        //        MessageBox.Show("No Albums to retrieve :(");
        //    }




        //    //    listBoxAlbums.Items.Clear();
        //    //listBoxAlbums.DisplayMember = "Name";

        //    //foreach (Album album in m_LoginResult.LoggedInUser.Albums)
        //    //{
        //    //    listBoxAlbums.Items.Add(album);
        //    //}
        //    //if (listBoxAlbums.Items.Count == 0)
        //    //{
        //    //    MessageBox.Show("No Albums to retrieve :(");
        //    //}
        //}

        //private bool isValidPhoto(Photo i_Photo)
        //{
        //    bool isValid = false;
        //    try
        //    {
        //        isValid = i_Photo != null && i_Photo.PictureNormalURL != null;
        //    }
        //    catch
        //    {
        //        isValid = false;
        //    }
        //    return isValid;
        //}

        //private void addPhotoToLayoutPanel(Photo io_Photo)
        //{
        //    PictureBox pictureBox = new PictureBox();
        //    pictureBox.Size = new Size(100, 100);
        //    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        //    pictureBox.LoadAsync(io_Photo.PictureNormalURL);
        //    flowLayoutPanelPhotos.Controls.Add(pictureBox);
        //}

        //private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    displaySelectedAlbum();
        //}

        //private void displaySelectedAlbum()
        //{
        //    if (listBoxAlbums.SelectedItems.Count == 1)
        //    {
        //        flowLayoutPanelPhotos.Controls.Clear();

        //        Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

        //        if (selectedAlbum == null)
        //        {
        //            MessageBox.Show("Unable to load this album.");
        //            return;
        //        }

        //        try
        //        {
        //            foreach (Photo photo in selectedAlbum.Photos)
        //            {
        //                if (isValidPhoto(photo))
        //                {
        //                    addPhotoToLayoutPanel(photo);
        //                }
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Unable to load this album.");
        //        }
        //    }
        //}

        //private void buttonProfile_Click(object sender, EventArgs e)
        //{
        //    FormProfile profileForm = new FormProfile(m_Facade, m_MainForm);
        //    this.Close();
        //    profileForm.Show();
        //}

        //private void buttonHome_Click(object sender, EventArgs e)
        //{
        //    m_MainForm.Show();
        //    this.Close();
        //}

        //private void buttonStatistics_Click(object sender, EventArgs e)
        //{
        //    FormUserStatistics formStats = new FormUserStatistics(m_Facade, m_MainForm);
        //    this.Close();
        //    formStats.Show();
        //}

    }
}