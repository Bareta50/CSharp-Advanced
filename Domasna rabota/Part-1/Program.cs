using Part_1.Helper.Generic;
using Part_1.Transport;
//------------== Print ==------------
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("------------== Print ==------------");
Console.ResetColor();
ConsolePrint<int>.Print(623);
ConsolePrint<string>.Print("Hello World");
ConsolePrint<double>.Print(3.14);
//------------== PrintList ==------------
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("------------== PrintList ==------------");
Console.ResetColor();
List<int> intList = new List<int> { 1, 2, 3, 4, 5 };
ConsolePrint<int>.PrintList(intList);

//------------== Vehicle ==------------
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------== Vehicle ==------------");
Console.ResetColor();

Boat boat = new Boat();
Car car = new Car();
MotorBike motorBike = new MotorBike();
Plane plane = new Plane();
boat.DisplayInfo();
car.DisplayInfo();
motorBike.DisplayInfo();
plane.DisplayInfo();