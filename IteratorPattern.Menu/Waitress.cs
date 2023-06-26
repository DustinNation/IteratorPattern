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
        private List<IMenu> _menus;

        public Waitress(List<IMenu> menus)
        {
            _menus = menus;
        }

        public string PrintMenu()
        {
            StringBuilder stringBuilder = new();
            using var menuEnumerator = _menus.GetEnumerator();

            stringBuilder.Append("MENU\n----");

            while (menuEnumerator.MoveNext())
            {
                var menu = menuEnumerator.Current;

                if (TryCast<PancakeHouseMenu>(menu, out _))
                {
                    stringBuilder.Append("\nBREAKFAST\n");
                }
                else if (TryCast<DinerMenu>(menu, out _))
                {
                    stringBuilder.Append("\nLUNCH\n");
                }
                else if (TryCast<CafeMenu>(menu, out _))
                {
                    stringBuilder.Append("\nDINNER\n");
                }

                stringBuilder.Append(PrintMenu(menu.CreateMenuItems()));
            }

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

        public static bool TryCast<T>(object obj, out T? result)
        {
            if (obj is T obj1)
            {
                result = obj1;
                return true;
            }

            result = default(T);
            return false;
        }
    }
}
