using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadeCollageOfPhotos
    {
        private User m_LoggedInUser;

        public FacadeCollageOfPhotos(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public List<Photo> GetAllUserPhotos()
        {
            List<Photo> allPhotosList = new List<Photo>();

            if (m_LoggedInUser != null && m_LoggedInUser.Albums != null)
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    try
                    {
                        if (album.Photos != null)
                        {
                            foreach (Photo photo in album.Photos)
                            {
                                try
                                { 
                                    if (photo.PictureNormalURL != null)
                                    {
                                        allPhotosList.Add(photo);
                                    }
                                }
                                catch
                                {
                                    // Ignore photos that cannot be accessed
                                }

                            }
                        }
                    }
                    catch 
                    {
                        // Ignore albums that cannot be accessed
                    }

                }
            }

            return allPhotosList;
        }
    }
}
