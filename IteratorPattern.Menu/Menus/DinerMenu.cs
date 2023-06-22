using System.Collections;
using IteratorPattern.Menu.Iterators;

namespace IteratorPattern.Menu.Menus;

public class DinerMenu: IMenu
{
    private const int MaxItems = 6;
    private readonly MenuItem[] _menuItems;
    private int _numberOfItems;

    public DinerMenu()
    {
        _menuItems = new MenuItem[MaxItems];

        AddItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat",
            true,
            2.99);

        AddItem("BLT",
            "Bacon with lettuce & tomato on whole wheat",
            false,
            2.99);

        AddItem("Soup of the day",
            "Soup of the day, with a side of potato salad",
            false,
            3.29);

        AddItem("Hotdog",
            "A hot dog with sauerkraut, relish, onions, topped with cheese",
            false,
            3.05);

        AddItem("Steamed Veggies and Brown Rice",
            "Steamed vegetables over brown rice",
            true,
            3.99);

        AddItem("Pasta",
            "Spaghetti with Marina Sauce and a slice of sourdough bread",
            true,
            3.89);
    }

    public void AddItem(string name, string description, bool isVegetarian, double price)
    {
        var menuItem = new MenuItem(name, description, isVegetarian, price);

        if (_numberOfItems >= MaxItems)
        {
            Console.WriteLine("Sorry, menu is full! Can't add item to menu");
        }
        else
        {
            _menuItems[_numberOfItems] = menuItem;
            _numberOfItems += 1;
        }
    }

    public MenuItem[] GetMenuItems()
    {
        return _menuItems;
    }

    //public IEnumerable CreateIterator()
    //{
    //    return _menuItems.ToArray().AsEnumerable();
    //}

    public ICollection<MenuItem> CreateMenuItems()
    {
        return _menuItems.ToArray().AsEnumerable().ToList();
    }
}