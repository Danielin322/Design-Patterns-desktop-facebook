using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadeProfile
    {
        private User m_LoggedInUser;

        public FacadeProfile(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public string GetName()
        {
            string name = "";

            if (m_LoggedInUser != null)
            {
                name = m_LoggedInUser.Name;
            }

            return name;
        }

        public string GetBirthday()
        {
            string birthday = "";

            if (m_LoggedInUser != null)
            {
                birthday = m_LoggedInUser.Birthday;
            }

            return birthday;
        }

        public string GetEmail()
        {
            string email = "";

            if (m_LoggedInUser != null)
            {
                email = m_LoggedInUser.Email;
            }

            return email;
        }

        public string GetCity()
        {
            string city = "";

            if (m_LoggedInUser != null)
            {
                if (m_LoggedInUser.Location != null)
                {
                    city = m_LoggedInUser.Location.Name;
                }
            }

            return city;
        }

        public string GetHometown()
        {
            string hometown = "";

            if (m_LoggedInUser != null)
            {
                if (m_LoggedInUser.Hometown != null)
                {
                    hometown = m_LoggedInUser.Hometown.Name;
                }
            }

            return hometown;
        }

        public string GetGender()
        {
            string gender = "";

            if (m_LoggedInUser != null)
            {
                gender = m_LoggedInUser.Gender.ToString();
            }

            return gender;
        }

        public string GetProfilePicture()
        {
            string url = null;

            if (m_LoggedInUser != null)
            {
                url = m_LoggedInUser.PictureNormalURL;
            }

            return url;
        }

        public List<string> GetPosts()
        {
            List<string> postContents = new List<string>();

            if (m_LoggedInUser != null)
            {
                if (m_LoggedInUser.Posts != null)
                {
                    foreach (Post post in m_LoggedInUser.Posts)
                    {
                        string content = "";

                        if (post.Message != null)
                        {
                            content = post.Message;
                        }
                        else if (post.Caption != null)
                        {
                            content = post.Caption;
                        }

                        if (content != "")
                        {
                            postContents.Add(content);
                        }
                    }
                }
            }

            return postContents;
        }
    }
}