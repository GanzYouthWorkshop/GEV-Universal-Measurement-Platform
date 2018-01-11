using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data
{
    public class KeyedCollection<T> : List<T>
    {
        private Func<T, IComparable> m_ItemKeyPredicate;

        public KeyedCollection(Func<T, IComparable> itemKey)
        {
            this.m_ItemKeyPredicate = itemKey;
        }

        public T this[object o]
        {
            get
            {
                return this.FirstOrDefault(item => this.m_ItemKeyPredicate(item) == o);
            }

            set
            {
                try
                {
                    T item = this[o];

                    //Ha item nincs benne a listában exception-t dob!
                    this.Remove(item);
                }
                finally
                {
                    this.Add(value);
                }
            }
        }
    }
}
