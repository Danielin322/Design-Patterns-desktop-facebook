using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadeMain
    {
        private LoginResult m_LoginResult;

        public LoginResult LoginResult
        {
            get
            {
                return m_LoginResult;
            }
            set
            {
                m_LoginResult = value;
            }
        }

        public User LoggedInUser
        {
            get
            {
                User user = null;
                if (m_LoginResult != null)
                {
                    user = m_LoginResult.LoggedInUser;
                }
                return user;
            }
        }

        public void Login()
        {
            m_LoginResult = FacebookService.Login(
                "1389047795918927",
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
            );
        }

        public void Connect(string i_AccessToken)
        {
            m_LoginResult = FacebookService.Connect(i_AccessToken);
        }
    }
}
