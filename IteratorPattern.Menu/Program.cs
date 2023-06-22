using IteratorPattern.Menu;
using IteratorPattern.Menu.Menus;

var pancakeHouseMenu = new PancakeHouseMenu();
var dinerMenu = new DinerMenu();
var cafeMenu = new CafeMenu();

var waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);

Console.WriteLine(waitress.PrintMenu());