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
            List<Button> navButtons = NavigationButtonsFactory.CreateButtons(NavigationButtonsFactory.eButtonsTypes.Statistics, m_MainForm, m_LoggedInUser);
            int xPosition = 1042; // Starting X
            int yPosition = 865; // Starting Y
            int spacing = 10;

            foreach (Button btn in navButtons)
            {
                btn.Location = new Point(xPosition, yPosition);
                this.Controls.Add(btn);
                xPosition -= btn.Height + spacing;
            }
            try
            {
                facadeUserStatisticsBindingSource.DataSource = m_Facade;
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
}