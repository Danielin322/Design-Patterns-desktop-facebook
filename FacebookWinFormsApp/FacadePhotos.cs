using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadePhotos
    {
        private User m_LoggedInUser;

        public FacadePhotos(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public FacebookObjectCollection<Album> GetUserAlbums()
        {
            return m_LoggedInUser?.Albums;
        }

        public List<Photo> GetValidPhotosFromAlbum(Album i_Album)
        {
            List<Photo> validPhotos = new List<Photo>();

            if (i_Album != null && i_Album.Photos != null)
            {
                foreach (Photo photo in i_Album.Photos)
                {
                    if (isValidPhoto(photo))
                    {
                        validPhotos.Add(photo);
                    }
                }
            }

            return validPhotos;
        }

        private bool isValidPhoto(Photo i_Photo)
        {
            return i_Photo != null && !string.IsNullOrEmpty(i_Photo.PictureNormalURL);
        }
    }
}