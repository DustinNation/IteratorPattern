using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorPattern.Menu.Iterators;
using IteratorPattern.Menu.Menus;

namespace IteratorPattern.Menu
{
    public class Waitress
    {
        private readonly IMenu _pancakeHouseMenu;
        private readonly IMenu _dinerMenu;
        private readonly IMenu _cafeMenu;

        public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
            _cafeMenu = cafeMenu;
        }

        public string PrintMenu()
        {
            StringBuilder stringBuilder = new();

            var pancakeIterator = _pancakeHouseMenu.CreateMenuItems();
            var dinerIterator = _dinerMenu.CreateMenuItems();
            var cafeIterator = _cafeMenu.CreateMenuItems();

            stringBuilder.Append("MENU\n----\nBREAKFAST\n");
            stringBuilder.Append(PrintMenu(pancakeIterator));
            
            stringBuilder.Append("\nLUNCH\n");
            stringBuilder.Append(PrintMenu(dinerIterator));

            stringBuilder.Append("\nDINNER\n");
            stringBuilder.Append(PrintMenu(cafeIterator));

            return stringBuilder.ToString();
        }

        private static string PrintMenu(List<MenuItem> iterator)
        {
            StringBuilder stringBuilder = new();

            using var menuItems = iterator.GetEnumerator();

            while (menuItems.MoveNext())
            {
                var menuItem = menuItems.Current;

                stringBuilder.Append(menuItem.Name + ", ");
                stringBuilder.Append(menuItem.Price + " -- ");
                stringBuilder.Append(menuItem.Description + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
