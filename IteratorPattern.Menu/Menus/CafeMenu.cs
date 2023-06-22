using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Menu.Iterators;

namespace IteratorPattern.Menu.Menus
{
    public class CafeMenu: IMenu
    {
        private readonly Hashtable _menuItems = new();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries",
                "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99, 1);
            AddItem("Soup of the Day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69, 2);
            AddItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29, 3);
        }

        //added the index integer to be the Hashtable key value
        public void AddItem(string name, string description,
            bool isVegetarian, double price, int index)
        {
            var menuItem = new MenuItem(name, description,
                isVegetarian, price);

            _menuItems.Add(index, menuItem);
        }

        public List<MenuItem> CreateMenuItems()
        {
            return _menuItems.Values.Cast<MenuItem>().ToList();
        }
    }
}
