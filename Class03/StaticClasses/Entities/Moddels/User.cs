using StaticClasses.Entities.Moddels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticClasses.Entities.Helpers;
namespace StaticClasses.Entities.Moddels
{
    public class User : BaseEntity
    {
     
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }   

        public User(int id, string username, string address) : base(id)
        {
            
            Username = username;
            Address = address;
            
        }

        public void PrintOrders()
        {
            ConsoleHelper.WritingColor("Your orders:", ConsoleColor.Green);
            for (int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Orders[i].GetInfo()}");
            }
        }
    }
}
