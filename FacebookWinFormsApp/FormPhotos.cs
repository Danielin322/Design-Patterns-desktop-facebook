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

        public FormPhotos(LoginResult loginResult)
        {
            m_LoginResult = loginResult;
            InitializeComponent();
        }

        private void FormPhotos_Load(object sender, EventArgs e)
        {
            try
            {
                fetchAndShowPhotosFromAlbum();
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

        //private void fetchPhotosFromAlbum()
        //{
        //    foreach (Album album in m_LoginResult.LoggedInUser.Albums)
        //    {
        //        foreach (Photo photo in album.Photos)
        //        {
        //            // Create a NEW PictureBox for each photo
        //            PictureBox pictureBox = new PictureBox();
        //            pictureBox.Size = new Size(200, 200);
        //            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        //            // Load the photo
        //            pictureBox.LoadAsync(photo.PictureNormalURL);

        //            // Add it to a FlowLayoutPanel (so they appear in a grid)
        //            flowLayoutPanelPhotos.Controls.Add(pictureBox);
        //        }
        //    }
        //}

        private void fetchAndShowPhotosFromAlbum()
        {
            foreach (Album album in m_LoginResult.LoggedInUser.Albums)
            {
                if (album.Photos == null)
                {
                    continue;
                }

                foreach (Photo photo in album.Photos)
                {
                    if (IsValidPhoto(photo))
                    {
                        addPhotoToLayoutPanel(photo);
                    }
                }
            }
        }


        private bool IsValidPhoto(Photo photo)
        {
            try
            {
                return photo != null && photo.PictureNormalURL != null;
            }
            catch
            {
                return false;
            }
        }

        private void addPhotoToLayoutPanel(Photo photo)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.LoadAsync(photo.PictureNormalURL);

            flowLayoutPanelPhotos.Controls.Add(pictureBox);
        }


        //private void fetchPhotosFromAlbum()
        //{
        //    var user = m_LoginResult.LoggedInUser;

        //    if (user.Albums == null)
        //    {
        //        MessageBox.Show("No albums found.");
        //        return;
        //    }

        //    foreach (Album album in user.Albums)
        //    {
        //        if (album.Photos == null)
        //        {
        //            continue; // skip empty album
        //        }

        //        foreach (Photo photo in album.Photos)
        //        {
        //            if (photo.PictureNormalURL == null)
        //            {
        //                continue; // skip invalid photos
        //            }

        //            PictureBox pictureBox = new PictureBox();
        //            pictureBox.Size = new Size(200, 200);
        //            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        //            pictureBox.LoadAsync(photo.PictureNormalURL);

        //            flowLayoutPanelPhotos.Controls.Add(pictureBox);
        //        }
        //    }
        //}
    }
}
