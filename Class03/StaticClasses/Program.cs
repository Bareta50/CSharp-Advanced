
using StaticClasses;
using StaticClasses.Entities.Enum;
using StaticClasses.Entities.Helpers;
using StaticClasses.Entities.Moddels;



//Console.ForegroundColor = ConsoleColor.Cyan;
//Console.WriteLine("===== Order Management App =====");
//Console.ResetColor();

//ConsoleHelper consoleHelper = new ConsoleHelper();
//consoleHelper.WriteInColor("===== Order Management App =====", ConsoleColor.Cyan);

ConsoleHelper.WritingColor("===== Order Management App =====", ConsoleColor.Cyan);

//Console.WriteLine(OrdersStaticDB.Users.Count);
//Console.WriteLine(OrdersStaticDB.Users.Count);
//Console.WriteLine(OrdersStaticDB.Users.Count);
//Console.WriteLine(OrdersStaticDB.Users.Count);

Console.WriteLine("\nPlease choose an option:");
Console.WriteLine("1) List all users");
Console.WriteLine("2) Add new order to user");
Console.WriteLine("3) Exit");

string input = Console.ReadLine();
int option = Validationhelper.ValidateNumberInput(input);
bool isRunning = true;
while (isRunning) {
    if (option == -1)
    {
        ConsoleHelper.WritingColor("Invalid input. Please try again!", ConsoleColor.Red);
        Console.ReadLine();
        continue;
    }

    switch (option)
    {
        case 1:
            break;
        case 2:
            ConsoleHelper.WritingColor("Enter User ID:", ConsoleColor.Green);
            int userId = Convert.ToInt32(Console.ReadLine());

            ConsoleHelper.WritingColor("Enter Order Ttitle:", ConsoleColor.DarkRed);
            string title = Console.ReadLine();

            ConsoleHelper.WritingColor("Enter Order Description:", ConsoleColor.DarkRed);
            string description = Console.ReadLine();

           
            break;
        case 3:
            ConsoleHelper.WritingColor("Exiting the application...", ConsoleColor.Red);
            break;
        default:
            ConsoleHelper.WritingColor("Invalid option. Please try again!", ConsoleColor.Red);
            break;
    }
    Console.ReadLine();
}

