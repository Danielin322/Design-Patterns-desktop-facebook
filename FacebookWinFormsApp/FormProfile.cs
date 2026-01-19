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
            //try
            //{
            //    loadUserData();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error loading profile data: " + ex.Message);
            //}
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

            //textBoxUserFullName.Text = m_Facade.GetName();
            //textBoxBirthdayDate.Text = m_Facade.GetBirthday();
            //textBoxUserCity.Text = m_Facade.GetCity();
            //textBoxUserEmail.Text = m_Facade.GetEmail();
            //textBoxUserLocation.Text = m_Facade.GetHometown();
            //textBoxGender.Text = m_Facade.GetGender();

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

        private void buttonUserPhotos_Click(object sender, EventArgs e)
        {
            FormPhotos photosForm = new FormPhotos(m_LoggedInUser, m_MainForm);
            this.Close();
            photosForm.Show();
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

        //    private FacadeProfile m_Facade;
        //    private FormMainFacebookWindow m_MainForm;


        //    public FormProfile(FacadeProfile i_Facade, FormMainFacebookWindow i_MainForm)
        //    {
        //        m_Facade = i_Facade;
        //        m_MainForm = i_MainForm;
        //        InitializeComponent();
        //    }

        //     private void FormProfile_Load(object sender, EventArgs e)
        //    {
        //        string pictureUrl = m_Facade.GetProfilePicture();
        //        if (!string.IsNullOrEmpty(pictureUrl))
        //        {
        //            pictureBox_Profile.LoadAsync(pictureUrl);
        //        }

        //        textBoxUserFullName.Text = m_Facade.GetName();
        //        textBoxBirthdayDate.Text = m_Facade.GetBirthday();
        //        textBoxUserCity.Text = m_Facade.GetCity();
        //        textBoxUserEmail.Text = m_Facade.GetEmail();
        //        textBoxUserLocation.Text = m_Facade.GetHometown();
        //        textBoxGender.Text = m_Facade.GetGender();

        //        displayPosts();


        //        //if (m_Facade.LoggedInUser == null)
        //        //{
        //        //    MessageBox.Show("Login failed or user data not available.");
        //        //    this.Close();
        //        //    return;
        //        //}

        //        //if (!string.IsNullOrEmpty(m_Facade.GetProfilePictureURL()))
        //        //{
        //        //    pictureBox_Profile.LoadAsync(m_Facade.GetProfilePictureURL());
        //        //}

        //        //textBoxUserFullName.Text = m_Facade.GetUserName();
        //        //textBoxBirthdayDate.Text = m_Facade.GetUserBirthday();
        //        //textBoxUserCity.Text = m_Facade.GetUserCity();
        //        //textBoxUserEmail.Text = m_Facade.GetUserEmail();
        //        //textBoxUserLocation.Text = m_Facade.GetUserHometown();
        //        //textBoxGender.Text = m_Facade.GetUserGender();

        //        //displayPosts();




        //        //if (m_LoginResult?.LoggedInUser == null)
        //        //{
        //        //    MessageBox.Show("Login failed or user data not available.");
        //        //    this.Close();
        //        //    return;
        //        //}

        //        //// Show picture of user
        //        //if (!string.IsNullOrEmpty(m_LoginResult.LoggedInUser.PictureNormalURL))
        //        //{
        //        //    pictureBox_Profile.LoadAsync(m_LoginResult.LoggedInUser.PictureNormalURL);
        //        //}

        //        //// if some of the info is missing, we show empty string
        //        //textBoxUserFullName.Text = m_LoginResult.LoggedInUser.Name ?? "";
        //        //textBoxBirthdayDate.Text = m_LoginResult.LoggedInUser.Birthday ?? "";
        //        //textBoxUserCity.Text = m_LoginResult.LoggedInUser.Location?.Name ?? "";
        //        //textBoxUserEmail.Text = m_LoginResult.LoggedInUser.Email ?? "";
        //        //textBoxUserLocation.Text = m_LoginResult.LoggedInUser.Hometown?.Name ?? "";
        //        //textBoxGender.Text = m_LoginResult.LoggedInUser.Gender?.ToString() ?? "";
        //        //fetchPosts();
        //    }

        //    private void displayPosts()
        //    {
        //        try
        //        {
        //            flowLayoutPanelPosts.Controls.Clear();

        //            List<string> posts = m_Facade.GetPosts();

        //            foreach (string postText in posts)
        //            {
        //                addPostToFlowPanel(postText);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error displaying posts: " + ex.Message);
        //        }
        //    }

        //    //private void fetchPosts()
        //    //{
        //    //    try
        //    //    {
        //    //        flowLayoutPanelPosts.Controls.Clear();

        //    //        foreach (Post post in m_LoginResult.LoggedInUser.Posts)
        //    //        {
        //    //            string content = null;

        //    //            if (post.Message != null)
        //    //            {                       
        //    //                content = post.Message;
        //    //            }
        //    //            else if (post.Caption != null)
        //    //            {
        //    //                content = post.Caption;
        //    //            }
        //    //            else
        //    //            {
        //    //                content = string.Format("[{0}]", post.Type);
        //    //            }

        //    //            if (!string.IsNullOrEmpty(content))
        //    //            {
        //    //                addPostToFlowPanel(content);
        //    //            }
        //    //        }
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show(ex.Message);
        //    //    }
        //    //}

        //    private void addPostToFlowPanel(string i_PostText)
        //    {
        //        Label postLabel = new Label();

        //        postLabel.AutoSize = false;
        //        postLabel.Width = flowLayoutPanelPosts.Width - 30;
        //        postLabel.Padding = new Padding(10);
        //        postLabel.Margin = new Padding(5);
        //        postLabel.Text = i_PostText;
        //        postLabel.BackColor = Color.White;
        //        postLabel.BorderStyle = BorderStyle.FixedSingle;
        //        postLabel.Font = new Font("Segoe UI", 10);
        //        postLabel.Height = TextRenderer.MeasureText(i_PostText, postLabel.Font, new Size(postLabel.Width, int.MaxValue)).Height + 20;
        //        flowLayoutPanelPosts.Controls.Add(postLabel);
        //    }

        //    private void buttonUserPhotos_Click(object sender, EventArgs e)
        //    {
        //        FormPhotos photosForm = new FormPhotos(m_MainForm);
        //        this.Close();
        //        photosForm.Show();
        //    }

        //    private void buttonHome_Click(object sender, EventArgs e)
        //    {
        //        m_MainForm.Show();
        //        this.Close();
        //    }

        //    private void buttonStatistics_Click(object sender, EventArgs e)
        //    {
        //        FormUserStatistics formStats = new FormUserStatistics(m_MainForm);
        //        this.Close();
        //        formStats.Show();
        //    }

    }
}