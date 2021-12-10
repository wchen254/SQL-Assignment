using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2.Property
{
    public interface ICourseService<T> where T : class
    {
        int Insert(T obj);
        int Update(T obj);
        int Delete(int id);
        List<T> GetAll();
        T GetById(int id);
    }
}
