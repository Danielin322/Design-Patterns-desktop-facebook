using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FacebookObjectCollection<T> : IAggregate<T>
    {
        private readonly List<T> r_List;

        public FacebookObjectCollection(IEnumerable<T> i_Collection)
        {
            r_List = new List<T>(i_Collection);
        }

        public IIterator<T> CreateIterator()
        {
            return new FacebookListIterator<T>(r_List);
        }
    }
}