using IteratorPattern.Menu.Menus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Menu.Iterators
{
    public class PancakeHouseMenuIterator: IIterator
    {
        public ArrayList MenuItems;
        public int Position;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            MenuItems = menuItems;
        }


        public bool HasNext()
        {
            return Position < MenuItems.Count && MenuItems[Position] != null;
        }

        public MenuItem Next()
        {
            var menuItem = (MenuItem)MenuItems[Position];
            Position += 1;

            return menuItem;
        }
    }
}
