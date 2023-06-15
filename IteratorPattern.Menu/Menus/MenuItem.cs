using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Menu.Menus
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, string description, bool isVegetarian, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public double GetPrice()
        {
            return Price;
        }

        public bool IsItemVegetarian()
        {
            return IsVegetarian;
        }
    }
}
