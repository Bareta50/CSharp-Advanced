using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Moddels
{
    public class Dog : Pet
    {
         public bool IsGoodBoy { get; set; }
        public override void Eat()
        {
            Console.WriteLine("The DOG is eating... Nom,nom,nom!");
        }
    }
}
