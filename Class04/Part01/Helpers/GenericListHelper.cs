using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Helpers
{
    public static class GenericListHelper
    {
        public static void PrintList<T>(List<T> list) 
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintListInfo<T>(List<T> lists)
        {
            T first = lists.First();
            Console.WriteLine($"This List has {lists.Count} elements, and is of type {first.GetType().Name}!");
        }
    }
}
