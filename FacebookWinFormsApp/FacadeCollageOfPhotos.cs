using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                IAggregate<Album> albumAggregate = new FacebookObjectCollection<Album>(m_LoggedInUser.Albums);
                IIterator<Album> albumIterator = albumAggregate.CreateIterator();
                while (albumIterator.HasNext())
                {
                    Album currentAlbum = albumIterator.Next();
                    try
                    {
                        if (currentAlbum.Photos != null)
                        {
                            IAggregate<Photo> photoAggregate = new FacebookObjectCollection<Photo>(currentAlbum.Photos);
                            IIterator<Photo> photoIterator = photoAggregate.CreateIterator();
                            while (photoIterator.HasNext())
                            {
                                Photo currentPhoto = photoIterator.Next();
                                try
                                {
                                    if (currentPhoto.PictureNormalURL != null)
                                    {
                                        allPhotosList.Add(currentPhoto);
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