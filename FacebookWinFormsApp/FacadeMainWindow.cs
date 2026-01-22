using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadeMainWindow
    {
        private User m_LoggedInUser;

        public FacadeMainWindow(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public string GetProfilePictureURL()
        {
            string url = null;

            if (m_LoggedInUser != null)
            {
                url = m_LoggedInUser.PictureNormalURL;
            }

            return url;
        }

        public string GetUserName()
        {
            string name = "";

            if (m_LoggedInUser != null)
            {
                name = m_LoggedInUser.Name;
            }

            return name;
        }

        public List<Page> GetLikedPages()
        {
            List<Page> pageList = new List<Page>();

            if (m_LoggedInUser != null)
            {
                if (m_LoggedInUser.LikedPages != null)
                {
                    foreach (Page page in m_LoggedInUser.LikedPages)
                    {
                        pageList.Add(page);
                    }
                }
            }

            return pageList;
        }

        public void PublishPost(string i_TextToPost)
        {
            // Posting a new status (facebook doesnt allow posting from here)
        }
    }
}