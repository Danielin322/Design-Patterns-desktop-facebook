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
            List<Button> navButtons = NavigationButtonsFactory.CreateButtons(NavigationButtonsFactory.eButtonsTypes.Photos, m_MainForm, m_LoggedInUser);
            int xPosition = 1042; // Starting X
            int yPosition = 865; // Starting 
            int spacing = 10;

            foreach (Button btn in navButtons)
            {
                btn.Location = new Point(xPosition, yPosition);
                this.Controls.Add(btn);
                xPosition -= btn.Height + spacing;
            }
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
    }
}