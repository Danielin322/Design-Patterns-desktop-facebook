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
    public partial class FormCollageOfPhotos : Form
    {
        private LoginResult m_LoginResult;
        private FormMainFacebookWindow m_MainForm;
        private List<Photo> m_PhotosForCollage;
        private Timer m_Timer;
        private int m_PhotoIndex = 0;

        public FormCollageOfPhotos(LoginResult i_LoginResult, FormMainFacebookWindow i_MainForm)
        {
            m_LoginResult = i_LoginResult;
            m_MainForm = i_MainForm;
            InitializeComponent();
            m_Timer = new Timer();
            m_Timer.Interval = 2000;
            m_Timer.Tick += Timer_Tick;
            m_Timer.Start();
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (m_PhotosForCollage == null || m_PhotosForCollage.Count == 0)
            {
                return;
            }

            PictureBox[] placesForPhotos = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };
            for (int i = 0; i < placesForPhotos.Length; i++)
            {
                placesForPhotos[i].SizeMode = PictureBoxSizeMode.Zoom;
                placesForPhotos[i].LoadAsync(m_PhotosForCollage[m_PhotoIndex].PictureNormalURL);
                m_PhotoIndex = (m_PhotoIndex + 1) % m_PhotosForCollage.Count;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            m_Timer.Stop();
            m_MainForm.Show();
            this.Close();
        }

        private void FormCollageOfPhotos_Load(object sender, EventArgs e)
        {
            List<Photo> photosForCollage = new List<Photo>();
            foreach (Album album in m_LoginResult.LoggedInUser.Albums)
            {
                try
                {
                    foreach (Photo photo in album.Photos)
                    {
                        try
                        {
                            if (photo.PictureNormalURL != null)
                            {
                                photosForCollage.Add(photo);
                            }
                        }
                        catch
                        {
                            //cant fetch photo
                        }
                    }
                }
                catch
                {
                    //cant fetch album
                }
            }

            m_PhotosForCollage = photosForCollage;
        }

        private void FormCollageOfPhotos_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_MainForm.Close();
        }
    }
}