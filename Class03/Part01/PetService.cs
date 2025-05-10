using Part01.Moddels;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01
{
    public class PetService
    {
        public void PrintPetInfo(string owner, Dog dog)
        {
            Console.WriteLine($"Dog {dog.Name} is {(dog.IsGoodBoy ? "Good boy!" : "Not good boy!")}. Owner {owner}");
        }
        public void PrintPetInfo(Dog dog, string owner)
        {
            Console.WriteLine($"Dog {dog.Name} is {(dog.IsGoodBoy ? "Good boy!" : "Not good boy!")}. Owner {owner}");
        }
    }
}
