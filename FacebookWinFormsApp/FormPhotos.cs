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
        private LoginResult m_LoginResult;
        private FormMainFacebookWindow m_MainForm;
        public FormPhotos(LoginResult i_LoginResult, FormMainFacebookWindow i_MainForm)
        {
            m_LoginResult = i_LoginResult;
            m_MainForm = i_MainForm;
            InitializeComponent();
        }

        private void FormPhotos_Load(object sender, EventArgs e)
        {
            try
            {
                fetchAlbums();
            }
            catch (KeyNotFoundException)
            {
                // We solve this error, so the exception is not needed in this case
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = "Name";

            foreach (Album album in m_LoginResult.LoggedInUser.Albums)
            {
                listBoxAlbums.Items.Add(album);
            }
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private bool isValidPhoto(Photo i_Photo)
        {
            bool isValid = false;
            try
            {
                isValid = i_Photo != null && i_Photo.PictureNormalURL != null;
            }
            catch
            {
                isValid = false;
            }
            return isValid;
        }

        private void addPhotoToLayoutPanel(Photo io_Photo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.LoadAsync(io_Photo.PictureNormalURL);
            flowLayoutPanelPhotos.Controls.Add(pictureBox);
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
                    foreach (Photo photo in selectedAlbum.Photos)
                    {
                        if (isValidPhoto(photo))
                        {
                            addPhotoToLayoutPanel(photo);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to load this album.");
                }
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormProfile profileForm = new FormProfile(m_LoginResult, m_MainForm);
            this.Close();
            profileForm.Show();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            m_MainForm.Show();
            this.Close();
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            FormUserStatistics formStats = new FormUserStatistics(m_LoginResult, m_MainForm);
            this.Close();
            formStats.Show();
        }

        private void FormPhotos_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_MainForm.Close();
        }
    }
}