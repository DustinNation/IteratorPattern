using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Menu.Menus;

namespace IteratorPattern.Menu.Iterators
{
    public class DinerMenuIterator: IIterator
    {
        public MenuItem[] Items;
        public int Position;

        public DinerMenuIterator(MenuItem[] items)
        {
            Items = items;
        }


        public bool HasNext()
        {
            return Position < Items.Length && Items[Position] != null;
        }

        public MenuItem Next()
        {
            var menuItem = Items[Position];
            Position += 1;

            return menuItem;
        }
    }
}
