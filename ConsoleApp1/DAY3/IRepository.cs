using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3
{
    public interface IRepository<T> where T: class
    {
        void Add(T obj);
        void Remove(T obj);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
