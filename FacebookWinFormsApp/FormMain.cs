using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FacadeUserInfo m_Facade = new FacadeUserInfo();

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        //FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_Facade.LoginResult == null)
            {
                login();
            }


            //Clipboard.SetText("design.patterns");

            //if (m_LoginResult == null)
            //{
            //    login();
            //}
        }

        private void login()
        {
            m_Facade.Login();

            if (string.IsNullOrEmpty(m_Facade.LoginResult.ErrorMessage))
            {
                FormMainFacebookWindow fbWindow = new FormMainFacebookWindow(m_Facade);
                fbWindow.FormClosed += logout;
                this.Hide();
                fbWindow.Show();
            }
            else
            {
                MessageBox.Show(m_Facade.LoginResult.ErrorMessage, "Login Failed");
            }



            //m_LoginResult = FacebookService.Login(
            //    "1389047795918927",
            //    /// requested permissions:
            //    "email",
            //    "public_profile",
            //    "user_age_range",
            //    "user_birthday",
            //    "user_friends",
            //    "user_gender",
            //    "user_hometown",
            //    "user_likes",
            //    "user_link",
            //    "user_location",
            //    "user_photos",
            //    "user_posts",
            //    "user_videos");

            //if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            //{
            //    //Create and show FacebookWindow
            //    FormMainFacebookWindow fbWindow = new FormMainFacebookWindow(m_LoginResult);
            //    fbWindow.FormClosed += logout;
            //    this.Hide(); //hides FormMain
            //    fbWindow.Show(); // opens FacebookWindow
            //}
            //else
            //{
            //    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            //}
        }

        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            try
            {
                string accessToken = "EAAUm6cZC4eUEB..."; // הטוקן שלך
                m_Facade.Connect(accessToken);

                FormMainFacebookWindow fbWindow = new FormMainFacebookWindow(m_Facade);
                fbWindow.FormClosed += logout;
                this.Hide();
                fbWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed: " + ex.Message);
            }


            //try
            //{
            //    m_LoginResult = FacebookService.Connect("EAAUm6cZC4eUEBQTAa3rRgO39UZCIJLeD9OpF5SYAevqSaFI16sfjT6JznpAUbyX5Soyj4Uv2ZBRkesoHO9omNcJ3KSYPZCExgaKrIprACUMIVnhiHzT5a46zbdC2VkvZC04n1ZARj8WmvOCYyuIdmRZBNjtWZCFJrbjFoms5t3sU8G9dO1xDCYH7kkfU67heIUZCFDIuTtL0CzF2JUHBpRpwPdXYilOJW811z3C5fY9TOyBiUwZAqx4ZAV6YS5ZBBtYKdsb7");
            //    //Create and show FacebookWindow
            //    FormMainFacebookWindow fbWindow = new FormMainFacebookWindow(m_LoginResult);
            //    fbWindow.FormClosed += logout;
            //    this.Hide(); //hides FormMain
            //    fbWindow.Show(); // opens FacebookWindow

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(m_LoginResult.ErrorMessage, "Login Failed");
            //}
        }

        private void logout(object sender, EventArgs e)
        {
            this.Show();

            m_Facade.LoginResult = null;
            buttonLogin.Enabled = true;
            buttonConnectAsDesig.Enabled = true;

            //this.Show();
            //m_LoginResult = null;
            //buttonLogin.Enabled = true;
            //buttonConnectAsDesig.Enabled = true;
        }
    }
}