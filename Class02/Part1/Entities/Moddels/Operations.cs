using Part1.Entities.BaseEntity;
using Part1.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Entities.Moddels
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; } = new List<string>();
        public Operations(int id, string firstName, string lastName, int age, string phone, List<string> projects) : base(id, firstName, lastName, age, phone)
        {
            Projects = projects;
        }

        public override string GetInfo()
        {
            return $"{GetFullName()} ({Age}) - Currently working on {Projects.Count} projects!";
        }
        public bool CheckInfrasructures(int status)
        {
            return status < 400;
        }
    }
}
