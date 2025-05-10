using Part01.Entities.Interfaces;
using Part01.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Entities.Data 
{
    public  class GenericDB<T> : IGenericDb<T> where T : BaseEntity
    {
        private List<T> _db;
        public GenericDB()
        {
            _db = new List<T>();
        }
        public List<T> GetAll()
        {
            return _db;
        }
        public T GetById(int id)
        {
            
            return _db.SingleOrDefault(e => e.Id == id);
        }
       
        public void Insert(T item)
        {
            _db.Add(item);
            Console.WriteLine($"Item was added in the {typeof(T).Name} Database!");
        }

        public void PrintAll()
        {
            foreach (T item in _db)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void RemoveById(int id)
        {
            T itemToRemove = GetById(id);
            //ArgumentException.ThrowIfNullOrWhiteSpace(itemToRemove);
            if (itemToRemove is null)
            {
                throw new ArgumentNullException(nameof(itemToRemove), "Item not found");
            }
            _db.Remove(itemToRemove);
        }
    }
}
