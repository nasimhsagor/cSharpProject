using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShopManagementSystem.Framework
{
    public static class Validation
    {
        public static bool IsStringValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                return false;
            else
                return true;
        }
        public static bool IsIntValid(string value)
        {
            try
            {
                if (Int32.Parse(value) < 0)
                    return false;
                return true;
            }
            catch { return false; }
            
        }
        public static bool IsDoubleValid(string value)
        {
            try
            {
                if (double.Parse(value) < 0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool IsPhoneNumberValid(string number)
        {
            try
            {
                if (number.Length ==11)
                {
                    return IsIntValid(number);
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
