using Part1.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Entities.Moddels
{
    public class Tester : Human
    {
        public int BugsFound { get; set; }
        public Tester(int id, string firstName, string lastName, int age, string phone, int bugsFound) : base(id, firstName, lastName, age, phone)
        {
            BugsFound = bugsFound;
        }
        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - found {BugsFound} bugs so far!";
        }
        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested...");
            Console.WriteLine("Testing completed!");
        }
    }
}
