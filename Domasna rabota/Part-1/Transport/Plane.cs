using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1.Transport
{
    public class Plane : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("I am a Plane, I fly in the sky");
        }
    }
}
