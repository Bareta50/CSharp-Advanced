using Part1.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Entities.Moddels
{
    public class Developers : Human
    {
     
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int FeaturesDEveloped { get; set; }
        public int FeaturesDeveloped { get; private set; }

        public Developers(int id, string firstName, string lastName, int age, string phone, List<string> programmingLanguages, int featuresDEveloped) : base(id,firstName,lastName,age,phone)
        {
           
            ProgrammingLanguages = programmingLanguages;
            FeaturesDEveloped = featuresDEveloped;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - {FeaturesDeveloped} features developed!";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak ....");
            Console.WriteLine("Opens ChatGPT ....");
            Console.WriteLine("tak tak tak tak tak....");
        }
    }
}
