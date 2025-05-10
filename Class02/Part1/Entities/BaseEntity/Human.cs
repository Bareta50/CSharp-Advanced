using Part1.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Part1.Entities.BaseEntity
{
    public abstract class Human : IHuman, IDev
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Phone { get; set; } = string.Empty;
        //public abstract string Nesto { get; set; } very very rearly used!!

        public Human(int id, string firstName, string lastName, int age, string phone)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Phone = phone;
        }

        public string GetFullName()
        {
            return "${ FirstName} {  LastName }";
        }
        public abstract string GetInfo();
        public void Greet(string name)

        {
            Console.WriteLine($"Greeting {name}");
        }
        public void Code()
        {
            Console.WriteLine("Coding....more coding...");
        }
    }
}
