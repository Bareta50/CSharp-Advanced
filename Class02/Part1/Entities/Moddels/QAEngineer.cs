using Part1.Entities.BaseEntity;
using Part1.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Entities.Moddels
{
    public class QAEngineer : Human, ITester,IDev
    {   
        public List<string> TestingFrameworks { get; set; }
        public QAEngineer(int id, string firstName, string lastName, int age, string phone, List<string> testingFrameworks) : base(id, firstName, lastName, age, phone)
        {
            TestingFrameworks = testingFrameworks;
        }
        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - Knows testing frameworks {string.Join(", ", TestingFrameworks)}";
        }
        public void TestingFeature(string features)
        {
            Console.WriteLine("Run test...");
            Console.WriteLine("Run AutoTest...");
            Console.WriteLine("bla bla bla...");
            Console.WriteLine("bla bla bla........ DONE!");
        }

        public void Code()
        {
            Console.WriteLine("Running code v.0.003alpha");
            Console.WriteLine(".....");
            Console.WriteLine(".....");
            Console.WriteLine("v.0.003alpha complete!");
        }
    }
}
