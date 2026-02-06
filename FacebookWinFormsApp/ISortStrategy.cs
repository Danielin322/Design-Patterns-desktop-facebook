using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface ISortStrategy
    {
        List<Album> Sort(List<Album> i_Albums);
    }
}
