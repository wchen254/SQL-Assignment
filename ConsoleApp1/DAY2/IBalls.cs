using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2
{
    public interface IBalls<T> where T : class
    {
        int Insert(T obj);

        int Throw(int id);

        int Pop(int id);
    }
}
