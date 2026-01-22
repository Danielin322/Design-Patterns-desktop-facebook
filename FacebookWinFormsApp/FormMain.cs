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
        private FacadeMain m_Facade = new FacadeMain();

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_Facade.LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_Facade.Login();

            if (m_Facade.LoginResult.ErrorMessage == null || m_Facade.LoginResult.ErrorMessage == "")
            {
                FormMainFacebookWindow fbWindow = FormMainFacebookWindow.GetInstance(m_Facade.LoggedInUser);
                fbWindow.FormClosed += logout;
                this.Hide();
                fbWindow.Show();
            }
            else
            {
                MessageBox.Show(m_Facade.LoginResult.ErrorMessage, "Login Failed");
            }
        }

        private void buttonConnectAsDesig_Click(object sender, EventArgs e)
        {
            try
            {
                string accessToken = "EAAUm6cZC4eUEBQTAa3rRgO39UZCIJLeD9OpF5SYAevqSaFI16sfjT6JznpAUbyX5Soyj4Uv2ZBRkesoHO9omNcJ3KSYPZCExgaKrIprACUMIVnhiHzT5a46zbdC2VkvZC04n1ZARj8WmvOCYyuIdmRZBNjtWZCFJrbjFoms5t3sU8G9dO1xDCYH7kkfU67heIUZCFDIuTtL0CzF2JUHBpRpwPdXYilOJW811z3C5fY9TOyBiUwZAqx4ZAV6YS5ZBBtYKdsb7";
                m_Facade.Connect(accessToken);

                if (m_Facade.LoggedInUser != null)
                {
                    FormMainFacebookWindow fbWindow = FormMainFacebookWindow.GetInstance(m_Facade.LoggedInUser);
                    fbWindow.FormClosed += logout;
                    this.Hide();
                    fbWindow.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed: " + ex.Message);
            }
        }

        private void logout(object sender, EventArgs e)
        {
            this.Show();
            m_Facade.LoginResult = null;
            buttonLogin.Enabled = true;
            buttonConnectAsDesig.Enabled = true;
        }
    }
}