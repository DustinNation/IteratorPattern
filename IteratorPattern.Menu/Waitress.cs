using System;
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
        private PancakeHouseMenu _pancakeHouseMenu;
        private DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public string PrintMenu()
        {
            StringBuilder stringBuilder = new();

            var pancakeIterator = _pancakeHouseMenu.CreateIterator();
            var dinerIterator = _dinerMenu.CreateIterator();

            stringBuilder.Append("MENU\n----\nBREAKFAST\n");
            stringBuilder.Append(PrintMenu(pancakeIterator));
            stringBuilder.Append("\nLUNCH\n");
            stringBuilder.Append(PrintMenu(dinerIterator));

            return stringBuilder.ToString();
        }

        private static string PrintMenu(IIterator iterator)
        {
            StringBuilder stringBuilder = new();

            while (iterator.HasNext())
            {
                var menuItem = (MenuItem)iterator.Next();

                stringBuilder.Append(menuItem.Name + ", ");
                stringBuilder.Append(menuItem.Price + " -- ");
                stringBuilder.Append(menuItem.Description + "\n");
            }

            return stringBuilder.ToString();
        }
    }
}
