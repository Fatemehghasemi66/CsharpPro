using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(object id);
        List<T> GetIAll();
        bool AddItem(T item);
        bool UpdateItem(T item);
        bool DeleteItem(int id);
    }
}
