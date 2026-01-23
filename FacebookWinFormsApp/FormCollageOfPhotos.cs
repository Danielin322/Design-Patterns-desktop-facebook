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
        private FacadeCollageOfPhotos m_Facade;
        private FormMainFacebookWindow m_MainForm;
        private List<Photo> m_PhotosForCollage;
        private Timer m_Timer;
        private User m_LoggedInUser;
        private int m_PhotoIndex = 0;

        public FormCollageOfPhotos(User i_LoggedInUser, FormMainFacebookWindow i_MainForm)
        {
            m_LoggedInUser = i_LoggedInUser;
            m_MainForm = i_MainForm;
            m_Facade = new FacadeCollageOfPhotos(i_LoggedInUser);

            InitializeComponent();

            m_Timer = new Timer();
            m_Timer.Interval = 2000;
            m_Timer.Tick += Timer_Tick;
        }

        private void FormCollageOfPhotos_Load(object sender, EventArgs e)
        {
            List<Button> navButtons = NavigationButtonsFactory.CreateButtons(NavigationButtonsFactory.eButtonTypes.SpecialMoments, this, m_MainForm, m_LoggedInUser);

            foreach (Button btn in navButtons)
            {
                this.Controls.Add(btn);
            }
            m_PhotosForCollage = m_Facade.GetAllUserPhotos();

            if (m_PhotosForCollage.Count > 0)
            {
                m_Timer.Start();
            }
            else
            {
                MessageBox.Show("No photos found to create a collage.");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (m_PhotosForCollage.Count > 0)
            {
                PictureBox[] placesForPhotos = { pictureBox1, pictureBox2, pictureBox3, pictureBox4 };

                for (int i = 0; i < placesForPhotos.Length; i++)
                {
                    placesForPhotos[i].SizeMode = PictureBoxSizeMode.Zoom;
                    string url = m_PhotosForCollage[m_PhotoIndex].PictureNormalURL;
                    placesForPhotos[i].LoadAsync(url);

                    m_PhotoIndex = (m_PhotoIndex + 1) % m_PhotosForCollage.Count;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_Timer.Stop();
            m_MainForm.Show();
            this.Close();
        }
    }
}