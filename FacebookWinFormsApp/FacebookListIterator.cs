using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicFacebookFeatures
{
    public class FacebookListIterator : IIterator
    {
        private IList m_collection;
        private int m_currentIndex = 0;

        public FacebookListIterator(IList i_Collection)
        {
            m_collection = i_Collection;
        }

        public bool HasNext()
        {
            return m_collection != null && m_currentIndex < m_collection.Count;
        }

        public object Next()
        {
            return m_collection[m_currentIndex++];
        }
    }
}
