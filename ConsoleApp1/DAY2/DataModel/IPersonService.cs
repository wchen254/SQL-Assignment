using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY2.DataModel
{
    public interface IPersonService
    {
        uint age(DateTime date);
        decimal salary(decimal month);
        string[] address(string address);

    }
}
