using CsharpPro.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Repository;

internal class CustomerRepository : BaseRepository
{
    public override bool AddItem<T>(T item)
    {
        throw new NotImplementedException();
    }

    public override T GetItem<T>()
    {
        throw new NotImplementedException();
    }

    public override List<T> GetItems<T>()
    {
        throw new NotImplementedException();
    }
}
