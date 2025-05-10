//Polymorphism 
using Part01;
using Part01.Moddels;
using System.Linq;
#region Runtime Polymorphism
// In C#, runtime polymorphism is achieved through method overriding.
// This means that a derived class can provide a specific implementation
// of a method that is already defined in its base class.



Pet pet = new Pet()
{
    Name = "Lukas"
};
pet.Eat(); // Output: Nom,Nom,Nom
Dog Dzeki = new Dog()
{
    Name = "Dzeki",
    IsGoodBoy = true
};
Dzeki.Eat(); // Output: The DOG is eating... Nom,nom,nom!
Cat cat = new Cat()
{
    Name = "Murka",
    IsLazy = true
};
cat.Eat(); // Output: The CAT is eating... Mrrrow!

PetService petService = new PetService();
petService.PrintPetInfo("Mihael", Dzeki);
#endregion