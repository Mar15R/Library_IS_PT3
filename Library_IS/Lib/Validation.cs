using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS.Lib
{
    public class Validation
    {
        public bool IsYearValid(int year)
        {
            try
            {
                return year > 1500 && year <= DateTime.Now.Year;
            }
            catch
            {
                throw;
            }
        }
    }
}
