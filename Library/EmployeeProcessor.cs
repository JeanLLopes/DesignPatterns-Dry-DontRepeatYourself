using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class EmployeeProcessor
    {
        public string GenerateEmployeeID(string firstName, string lasteName)
        {
            return $"{ firstName.Substring(0, 4) }{ lasteName.Substring(0, 4) }{ DateTime.Now.Millisecond }";
        }

    }
}
