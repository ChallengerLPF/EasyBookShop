using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.utilities
{
    static class DataTypeValidator
    {
        public static bool isOnlyAlphaNumeric(string val)
        {
            return val.All(char.IsLetterOrDigit);
        }

        
    }
}
