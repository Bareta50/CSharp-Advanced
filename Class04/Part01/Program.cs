// ====== Class Materials \/
// ====================================> Generic Methods <========================================
// ====================================>    Extentions    <=======================================

using Part01.Entities.Data;
using Part01.Entities.Interfaces;
using Part01.Entities.Models;
using Part01.Helpers;
#region Generic Methods
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("====================================> Generic Methods <========================================");
Console.ResetColor();

List<string> strings = new List<string>() { "Str1", "Str2", "Str3" };
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
List<bool> bools = new List<bool>() { true, false, true, false };
//===== Not Generic Methods =====
/*
NotGenericListHelper notGenericListHelper = new NotGenericListHelper();
notGenericListHelper.PrintStrings(strings);
notGenericListHelper.PrintInfoStrings(strings);
notGenericListHelper.PrintInt(numbers);
notGenericListHelper.PrintInfoIntegers(numbers);
notGenericListHelper.PrintBool(bools);
notGenericListHelper.PrintInfoBooleans(bools);
*/
//===== Generic Methods =====
GenericListHelper.PrintList(strings);
GenericListHelper.PrintListInfo(strings);
GenericListHelper.PrintList(numbers);
GenericListHelper.PrintListInfo(numbers);
GenericListHelper.PrintList(bools);
GenericListHelper.PrintListInfo(bools);
#endregion
#region Generic Methods
// ====== Generic Classes ======
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("====================================> Generic Classes <========================================");
Console.ResetColor();
Product mobilePhone = new Product()
{
    Id = 1,
    Title = "Mobile Phone",
    Description = "iPhone79"
};
GenericDB<Product> ProductsDB = new GenericDB<Product>();

ProductsDB.Insert(mobilePhone);
ProductsDB.Insert(new Product {Id = 2, Title = "Monitor", Description = "GamingMonitor" });
ProductsDB.Insert(new Product { Id = 3, Title = "Mause", Description = "GamingMaus" });
ProductsDB.Insert(new Product { Id = 4, Title = "Keyboard", Description = "GamingKeyboard" });
List<Product> products = ProductsDB.GetAll();

GenericDB<Order> OrdersDB = new GenericDB<Order>();
OrdersDB.Insert(new Order { Id = 1, Address = "Bobky1", Receiver = "Bobsky Bob" });
OrdersDB.Insert(new Order { Id = 2, Address = "Bobky2", Receiver = "Parkson Jill" });
OrdersDB.Insert(new Order { Id = 3, Address = "Bobky3", Receiver = "Ranger Kely" });
List<Order> orders = OrdersDB.GetAll();

ProductsDB.PrintAll();
OrdersDB.PrintAll();


#endregion