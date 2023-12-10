using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Contracts
{
    internal interface IGenericRepository<T> where T : class
    {
        T GetById(object id);
        List<T> GetIAll();
        bool AddItem(T item);
        bool DeleteItem(T item);
    }
}
