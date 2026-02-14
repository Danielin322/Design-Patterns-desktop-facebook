using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace BasicFacebookFeatures
{
    public class FacebookListIterator<T> : IIterator<T>
    {
        private List<T> m_Collection;
        private int m_CurrentIndex = 0;

        public FacebookListIterator(IEnumerable<T> i_Collection)
        {
            m_Collection = new List<T>(i_Collection);
        }

        public bool HasNext()
        {
            return m_CurrentIndex < m_Collection.Count;
        }

        public T Next()
        {
            T currentItem = m_Collection[m_CurrentIndex];
            m_CurrentIndex++;

            return currentItem;
        }
    }
}