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

        public ISortStrategy SortStrategy { get; set; } = new SortByName();

        public FacadePhotos(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public List<Photo> GetValidPhotosFromAlbum(Album i_Album)
        {
            List<Photo> validPhotos = new List<Photo>();

            if (i_Album != null && i_Album.Photos != null)
            {
                IAggregate<Photo> photoAggregate = new FacebookObjectCollection<Photo>(i_Album.Photos);
                IIterator<Photo> photoIterator = photoAggregate.CreateIterator();

                while (photoIterator.HasNext())
                {
                    Photo photo = photoIterator.Next();
                    if (isValidPhoto(photo))
                    {
                        validPhotos.Add(photo);
                    }
                }
            }

            return validPhotos;
        }

        public List<Album> GetSortedAlbums()
        {
            List<Album> albums = m_LoggedInUser.Albums.ToList();
            return SortStrategy.Sort(albums);
        }

        private bool isValidPhoto(Photo i_Photo)
        {
            return i_Photo != null && !string.IsNullOrEmpty(i_Photo.PictureNormalURL);
        }
    }
}