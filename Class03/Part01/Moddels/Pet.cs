using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Moddels
{
    public class Pet
    {
        public string Name { get; set; } = string.Empty;
        public virtual void Eat () 
        {
            Console.WriteLine("Nom,Nom,Nom");
        }
    }
}
