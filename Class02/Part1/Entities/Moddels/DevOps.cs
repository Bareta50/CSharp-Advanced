using Part1.Entities.BaseEntity;
using Part1.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1.Entities.Moddels
{
    internal class DevOps : Human, IDevOps
    {
        public DevOps(int id, string firstName, string lastName, int age, string phone, bool AWSCertified, bool azureCertified) : base( id,  firstName,  lastName,  age, phone)
        {
            AWSCertified = AWSCertified;
            AzureCertified = azureCertified;
        }

        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }

        public override string GetInfo()
        {
            string result = $"{GetFullName()} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certificate" : "";
            result += AzureCertified ? " Azure Certificate" : "";
            result += AWSCertified || AzureCertified ? "" : "No certificates yet";
            return result;
        }
        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int>() { 200, 202, 204 };
            if (okStatuses.Contains(status))
            {
                return true;
            }
            return false;
        }
        public void Code()
        {
            Console.WriteLine("Running code v.0.014alpha");
            Console.WriteLine(".....");
            Console.WriteLine(".....");
            Console.WriteLine("v.0.014alpha complete!");
        }

        public bool CheckInfrasructures(int status)
        {
            throw new NotImplementedException();
        }
    }
}
