using IteratorPattern.Menu;
using IteratorPattern.Menu.Iterators;
using IteratorPattern.Menu.Menus;

var pancakeHouseMenu = new PancakeHouseMenu();
var dinerMenu = new DinerMenu();
var cafeMenu = new CafeMenu();

var menuList = new List<IMenu>
{
    pancakeHouseMenu,
    dinerMenu,
    cafeMenu
};

var waitress = new Waitress(menuList);

Console.WriteLine(waitress.PrintMenu());