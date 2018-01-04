using GEV.UMP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Calculation.MeasureItem
{
    public class ItemManager
    {
        public static KeyedCollection<Item> CurrentItems { get; } = new KeyedCollection<Item>(item => item.ID);

        private static ulong m_CurrentId = 0;

        public static Item CreateNewItem()
        {
            Item i = new Item() { ID = m_CurrentId };

            CurrentItems.Add(i);
            return i;
        }
    }
}
