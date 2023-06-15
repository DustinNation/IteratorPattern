using IteratorPattern.Menu;
using IteratorPattern.Menu.Menus;

var pancakeHouseMenu = new PancakeHouseMenu();
var dinerMenu = new DinerMenu();

var waitress = new Waitress(pancakeHouseMenu, dinerMenu);

Console.WriteLine(waitress.PrintMenu());