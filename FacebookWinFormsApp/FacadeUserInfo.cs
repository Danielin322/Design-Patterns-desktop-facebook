using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacadeUserInfo
    {

        public LoginResult LoginResult { get; set; }
        public User LoggedInUser => LoginResult?.LoggedInUser;

        public int TotalPostsCount
        {
            get { return GetTotalPostsCount(); }
        }

        public int TotalAlbumsCount
        {
            get { return GetTotalAlbumsCount(); }
        }

        public int TotalLikedPagesCount
        {
            get { return GetTotalLikedPagesCount(); }
        }

        public int TotalPhotosCount
        {
            get { return GetTotalPhotosCount(); }
        }

        public int FriendsCount
        {
            get { return GetFakeFriendsCount(); }
        }

        public int MostLikedCount
        {
            get { return GetMostLikedPhotoCount(); }
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

        public string GetUserName()
        {
            string name = "";

            if (LoggedInUser != null)
            {
                name = LoggedInUser.Name;
            }

            return name;
        }

        public string GetUserBirthday()
        {
            string birthday = "";

            if (LoggedInUser != null)
            {
                birthday = LoggedInUser.Birthday;
            }

            return birthday;
        }

        public string GetUserEmail()
        {
            string email = "";

            if (LoggedInUser != null)
            {
                email = LoggedInUser.Email;
            }

            return email;
        }

        public string GetUserCity()
        {
            string city = "";

            if (LoggedInUser != null && LoggedInUser.Location != null)
            {
                city = LoggedInUser.Location.Name;
            }

            return city;
        }

        public string GetUserHometown()
        {
            string hometown = "";

            if (LoggedInUser != null && LoggedInUser.Hometown != null)
            {
                hometown = LoggedInUser.Hometown.Name;
            }

            return hometown;
        }

        public string GetUserGender()
        {
            string gender = "";

            if (LoggedInUser != null && LoggedInUser.Gender != null)
            {
                gender = LoggedInUser.Gender.ToString();
            }

            return gender;
        }

        public string GetProfilePictureURL()
        {
            string profilePictureURL = null;

            if (LoggedInUser != null)
            {
                profilePictureURL = LoggedInUser.PictureNormalURL;
            }

            return profilePictureURL;
        }

        public List<string> GetUserPostsContent()
        {
            List<string> postsContent = new List<string>();
            string content = "";

            if (LoggedInUser != null && LoggedInUser.Posts != null)
            {
                foreach (Post post in LoggedInUser.Posts)
                {
                    if (post.Message != null)
                    {
                        content = post.Message;
                    }
                    else if (post.Caption != null)
                    {
                        content = post.Caption;
                    }

                    if (!string.IsNullOrEmpty(content))
                    {
                        postsContent.Add(content);
                    }
                }
            }

            return postsContent;
        }

        public List<Photo> GetAllUserPhotos()
        {
            List<Photo> userPhotos = new List<Photo>();

            if (LoggedInUser != null && LoggedInUser.Albums != null)
            {
                foreach (Album album in LoggedInUser.Albums)
                {
                    if (album.Photos != null)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            userPhotos.Add(photo);
                        }
                    }
                }
            }

            return userPhotos;
        }


        public int GetTotalPostsCount()
        {
            int postsCount = 0;

            if (LoggedInUser != null && LoggedInUser.Posts != null)
            {
                postsCount = LoggedInUser.Posts.Count;
            }

            return postsCount;
        }

        public int GetTotalAlbumsCount()
        {
            int albumsCount = 0;

            if (LoggedInUser != null && LoggedInUser.Albums != null)
            {
                albumsCount = LoggedInUser.Albums.Count;
            }

            return albumsCount;
        }

        public int GetTotalLikedPagesCount()
        {
            int likedPageCount = 0;

            if (LoggedInUser != null && LoggedInUser.LikedPages != null)
            {
                likedPageCount = LoggedInUser.LikedPages.Count;
            }

            return likedPageCount;
        }

        public int GetTotalPhotosCount()
        {
            int totalPhotos = 0;

            if (LoggedInUser != null && LoggedInUser.Albums != null)
            {
                foreach (Album album in LoggedInUser.Albums)
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

        public int GetFakeFriendsCount()
        {
            // No permissions to fetch friends amount, so return fake statistic:
            return 127;


            /* If there was permissions to fetch friends, it would be:
                   int totalFriends = LoggedInUser.Friends.Count;
                   return totalFriends;
            */
        }

        public int GetMostLikedPhotoCount()
        {
            int maxLikes = -1;

            if (LoggedInUser != null && LoggedInUser.Albums != null)
            {
                foreach (Album album in LoggedInUser.Albums)
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

            /* facebook's Count function doesnt work, so we put dummy data intead of maxLikes*/
            if (maxLikes == -1)
            {
                maxLikes = 64;
            }

            return maxLikes;
        }

        public List<Page> GetLikedPages()
        {
            List<Page> likedPages = new List<Page>();

            if (LoggedInUser != null && LoggedInUser.LikedPages != null)
            {
                foreach (Page page in LoggedInUser.LikedPages)
                {
                    likedPages.Add(page);
                }
            }

            return likedPages;
        }

        public void Login()
        {
            LoginResult = FacebookService.Login(
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
                "user_videos");
        }

        public void Connect(string i_AccessToken)
        {
            LoginResult = FacebookService.Connect(i_AccessToken);
        }
    }
}
