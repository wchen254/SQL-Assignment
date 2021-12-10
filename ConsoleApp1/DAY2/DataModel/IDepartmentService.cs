using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2.DataModel
{
    internal interface IDepartmentService
    {
        int setHead(string name);
        string getHead();
        decimal budget(DateTime date);
        string[] getCourses();
    }
}
