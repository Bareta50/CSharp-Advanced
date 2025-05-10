using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1.Helper.Generic
{
    public static class ConsolePrint<T>
    { 
        public static void Print(T print)
        {
            Console.WriteLine($"{print}");
        }

        public static void PrintList(List<T> print)
        {
            foreach (T item in print)
            {
                Console.WriteLine(item);
            }
        }

    }
}
