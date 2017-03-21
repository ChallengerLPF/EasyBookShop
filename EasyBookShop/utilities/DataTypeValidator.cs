using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyBookShop.models;

namespace EasyBookShop.utilities
{
    public static class DataTypeValidator
    {
        public static bool isOnlyAlphaNumeric(string val)
        {
            return val.All(char.IsLetterOrDigit);
        }

        public static bool isEmpty(string val)
        {
            return string.IsNullOrWhiteSpace(val);
        }
                
        public static bool decimalTypeValidated(string value)
        {
            decimal n;
            return decimal.TryParse(value, out n);
        }

        public static bool intTypeValidated(string value)
        {
            int n;
            return int.TryParse(value, out n);
        }

        public static bool dateTypeValidated(string value)
        {
            DateTime n;
            return DateTime.TryParse(value, out n);
        }

        //models validation
        //public void validateItem(item item)
        //{
        //    if(isEmpty(item.barcode)) 
        //}
    }
}
