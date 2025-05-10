using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Moddels
{
    public class Cat : Pet
    {
        public bool IsLazy { get; set; } = true;
        public override void Eat()
        {
            Console.WriteLine("The CAT is eating... nom,nom,nom!");
        }
    }
}
