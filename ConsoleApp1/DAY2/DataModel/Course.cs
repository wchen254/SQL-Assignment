using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAY2.Property;

namespace DAY2
{
    public class Course : ICourseService<Student>
    {
        List<Student> lstStudent = new List<Student>();

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Student obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
