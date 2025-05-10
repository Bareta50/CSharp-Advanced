Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("====================== Anonymous");
Console.ForegroundColor = ConsoleColor.Red;
Console.Write(" Functions ======================\n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" ");
Console.WriteLine(" ");



List<string> names = new()
{
    "Jane",
    "John",
    "Dan",
    "David",
    "Daniel",
    "Mike",
    "Sara",
    "Anna",
    "Jane"

};

string jhonName = names.Find(name => name.StartsWith("J"));


Func<string, bool> findJohn = name => name == "John";
Func<int,int,int> sum = (num1,num2) => num1 + num2;
Console.WriteLine(sum(321,465));

Func<bool> isNamesEmpty = () => names.Count == 0;
Console.WriteLine($"Is names empty: {isNamesEmpty()}");


// Example of a Func with 2 parameters
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine($"Sum of 2 numbers: {add(5, 10)}");

// Example of a Func with 3 parameters
Func<int, int, int, int> multiply = (a, b, c) => a * b * c;
Console.WriteLine($"Product of 3 numbers: {multiply(2, 3, 4)}");

// Example of a Func with 4 parameters
Func<int, string, double, bool, string> getUserInfo = (id, name, salary, isActive) =>
{
    string result = $"User ID: {id}, Name: {name}, Salary: {salary}, Active: {isActive}";
    return result;
};

Console.WriteLine(getUserInfo(1, "John Doe", 50000.50, true));

//Func<void> printHello = () => Console.WriteLine("Hello, World!");

#region Action 
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.Gray;
Console.Write("====================== Action");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(" Functions ======================\n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" ");
 
Action sayHello = () => Console.WriteLine("Hello, World!");
sayHello();

Action<string> greet = name =>
{
    Console.WriteLine("Unit 1, HAL-9000 activation.");
    Console.WriteLine("HAL-9000 boot-up complete!");
    Console.Write("Hello,");
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.Write($"{name}!\n");  
    Console.ResetColor();
};
greet("John");

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x");
#endregion

#region Predicate
Console.WriteLine(" ");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.Write("====================== Predicate");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(" Functions ======================\n");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(" ");


Predicate<string> nameStartsWithA = name => name.StartsWith("A");
Console.WriteLine(nameStartsWithA("Ginger"));

Func<string, bool> nSWJ = name => name.StartsWith("J");
IEnumerable<string> nameOnJ = names.Where(nSWJ);







Console.WriteLine(" ");
Console.ResetColor();
Console.WriteLine("---------------------------------");
Console.WriteLine("Not Predicate");
foreach (string name in names)
{
    if (name.StartsWith("M"))
    {Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Name starts with M: {name}");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Name does not start with M: {name}");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.ResetColor();
    }
}
Console.WriteLine("Not Predicate");
Console.WriteLine("---------------------------------");
#endregion

































































Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x");
Console.WriteLine("===================================================================");
Console.WriteLine(" ");

