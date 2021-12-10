using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2.DataModel
{
    internal interface InstructorService : IPersonService
    {
        string getdepartment();
        int setdepartment(string department);
        decimal bonus(DateTime joinDate);
    }
}
