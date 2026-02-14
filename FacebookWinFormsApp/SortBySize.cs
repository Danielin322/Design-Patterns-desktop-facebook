using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;


namespace BasicFacebookFeatures
{
    public class SortBySize : ISortStrategy
    {
        public List<Album> Sort(List<Album> i_Albums)
        {
            List<Album> sortedAlbums = i_Albums.OrderBy(album => album.Count ?? 0).ToList();
            return sortedAlbums;
        }
    }
}