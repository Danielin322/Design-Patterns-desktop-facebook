using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacadeUserStatistics
    {
        private User m_LoggedInUser;

        public FacadeUserStatistics(User i_User)
        {
            m_LoggedInUser = i_User;
        }

        public int TotalPostsCount
        {
            get
            {
                int postsCount = 0;

                if (m_LoggedInUser != null && m_LoggedInUser.Posts != null)
                {
                    postsCount = m_LoggedInUser.Posts.Count;
                }

                return postsCount;
            }
        }

        public int TotalAlbumsCount
        {
            get
            {
                int albumsCount = 0;

                if (m_LoggedInUser != null && m_LoggedInUser.Albums != null)
                {
                    albumsCount = m_LoggedInUser.Albums.Count;
                }

                return albumsCount;
            }
        }

        public int TotalLikedPagesCount
        {
            get
            {
                int likedPageCount = 0;

                if (m_LoggedInUser != null && m_LoggedInUser.LikedPages != null)
                {
                    likedPageCount = m_LoggedInUser.LikedPages.Count;
                }

                return likedPageCount;
            }
        }

        public int TotalPhotosCount
        {
            get
            {
                int totalPhotos = 0;

                if (m_LoggedInUser != null && m_LoggedInUser.Albums != null)
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        if (album.Photos != null)
                        {
                            foreach (Photo photo in album.Photos)
                            {
                                if (photo.PictureNormalURL != null)
                                {
                                    totalPhotos++;
                                }
                            }
                        }
                    }
                }

                return totalPhotos;
            }
        }

        public int FriendsCount
        {
            get
            {
                // facebook's Count function doesnt work, so we put dummy data instead of statistic:
                return 127;
            }
        }

        public int MostLikedCount
        {
            get
            {
                int maxLikes = -1;

                if (m_LoggedInUser != null && m_LoggedInUser.Albums != null)
                {
                    foreach (Album album in m_LoggedInUser.Albums)
                    {
                        if (album.Photos != null)
                        {
                            foreach (Photo photo in album.Photos)
                            {
                                if (photo.LikedBy != null)
                                {
                                    if (photo.LikedBy.Count > maxLikes)
                                    {
                                        maxLikes = photo.LikedBy.Count;
                                    }
                                }
                            }
                        }
                    }
                }

                // facebook's Count function doesnt work, so we put dummy data instead of maxLikes
                if (maxLikes == -1)
                {
                    maxLikes = 64;
                }

                return maxLikes;
            }
        }

        public string AveragePhotosPerAlbum
        {
            get
            {
                int totalAlbums = TotalAlbumsCount;

                if (totalAlbums > 0)
                {
                    return (TotalPhotosCount / totalAlbums).ToString();
                }
                else
                {
                    return "0";
                }
            }
        }
    }
}
