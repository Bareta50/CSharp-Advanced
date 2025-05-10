using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01.Entities.Interfaces
{
    public interface IGenericDb<T>
    {
        void PrintAll();
        void Insert(T item);

        T GetById(int id);
        void RemoveById(int id);
    }
}
