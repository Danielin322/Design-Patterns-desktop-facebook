using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BasicFacebookFeatures
{
    public partial class FormProfile : Form
    {
        private FacadeProfile m_Facade;
        private FormMainFacebookWindow m_MainForm;
        private User m_LoggedInUser;

        public FormProfile(User i_LoggedInUser, FormMainFacebookWindow i_MainForm)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_MainForm = i_MainForm;

            m_Facade = new FacadeProfile(i_LoggedInUser);
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            new Thread(loadUserData).Start();
            List<Button> navButtons = NavigationButtonsFactory.CreateButtons(NavigationButtonsFactory.eButtonsTypes.Profile,m_MainForm,m_LoggedInUser);
            int xPosition = 12; // Starting X 
            int yPosition = 150; // Starting Y
            int spacing = 10;

            foreach (Button btn in navButtons)
            {
                btn.Location = new Point(xPosition, yPosition);
                this.Controls.Add(btn);
                yPosition += btn.Height + spacing;
            }
        }


        private void loadUserData()
        {
            string name = m_Facade.GetName();
            string birthday = m_Facade.GetBirthday();
            string city = m_Facade.GetCity();
            string email = m_Facade.GetEmail();
            string hometown = m_Facade.GetHometown();
            string gender = m_Facade.GetGender();
            string pictureUrl = m_Facade.GetProfilePicture();

            if (!string.IsNullOrEmpty(pictureUrl))
            {
                pictureBox_Profile.LoadAsync(pictureUrl);
            }

            textBoxUserFullName.Invoke(new Action(() => textBoxUserFullName.Text = name));
            textBoxBirthdayDate.Invoke(new Action(() => textBoxBirthdayDate.Text = birthday));
            textBoxUserCity.Invoke(new Action(() => textBoxUserCity.Text = city));
            textBoxUserEmail.Invoke(new Action(() => textBoxUserEmail.Text = email));
            textBoxUserLocation.Invoke(new Action(() => textBoxUserLocation.Text = hometown));
            textBoxGender.Invoke(new Action(() => textBoxGender.Text = gender));
            displayPosts();
        }

        private void displayPosts()
        {
            try
            {
                List<string> posts = m_Facade.GetPosts();

                flowLayoutPanelPosts.Invoke(new Action(() => flowLayoutPanelPosts.Controls.Clear()));

                foreach (string postText in posts)
                {
                    flowLayoutPanelPosts.Invoke(new Action(() => addPostToFlowPanel(postText)));
                }
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => MessageBox.Show("Error displaying posts: " + ex.Message)));
            }
        }

        private void addPostToFlowPanel(string i_PostText)
        {
            Label postLabel = new Label();
            postLabel.AutoSize = false;
            postLabel.Width = flowLayoutPanelPosts.Width - 30;
            postLabel.Padding = new Padding(10);
            postLabel.Margin = new Padding(5);
            postLabel.Text = i_PostText;
            postLabel.BackColor = Color.White;
            postLabel.BorderStyle = BorderStyle.FixedSingle;
            postLabel.Font = new Font("Segoe UI", 10);
            int textHeight = TextRenderer.MeasureText(i_PostText, postLabel.Font, new Size(postLabel.Width, int.MaxValue)).Height;
            postLabel.Height = textHeight + 20;
            flowLayoutPanelPosts.Controls.Add(postLabel);
        }
    }
}