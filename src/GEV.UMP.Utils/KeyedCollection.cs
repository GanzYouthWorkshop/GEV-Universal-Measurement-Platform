using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Utils
{
    public class KeyedCollection<T> : List<T>
    {
        private Func<T, IComparable> m_itemKeyPredicate;

        public KeyedCollection(Func<T, IComparable> itemKey)
        {
            this.m_itemKeyPredicate = itemKey;
        }

        public T this[object o]
        {
            get
            {
                return this.FirstOrDefault(item => this.m_itemKeyPredicate(item) == o);
            }
        }
    }
}
