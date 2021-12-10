using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2.DataModel
{
    internal interface IStudentService : IPersonService
    {
        string[] takeCourses(string course);
        float gpa(string grade);
    }
}
