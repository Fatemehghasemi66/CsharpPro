using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPro.Contracts;

internal abstract class BaseRepository
{
    public abstract List<T> GetItems<T>();
    public abstract T GetItem<T>();
    public abstract bool AddItem<T>(T item);

}
