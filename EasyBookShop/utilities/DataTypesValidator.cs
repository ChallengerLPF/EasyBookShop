using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBookShop.utilities
{
    public static class DataTypesValidator
    {
        public static bool OnlyAlphaNumeric(string val)
        {
            return val.All(char.IsLetterOrDigit);
        }


    }
}
