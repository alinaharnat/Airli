using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public class Validation
    {
        public static bool ValidateEmail(string email)
        {
            if (email.Length == 0)
            {
                return false;
            }
            try
            {
                var condition = @"^(?!.*\.\.)(?!\.)(?!.*\.$)(?!.*\.@)[^@\s]+@[^@\s]+\.[^@\s]+$";
                var reg = new Regex(condition);
                return reg.IsMatch(email);
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool ValidateLength(int length, string text)
        {
            return text.Length >= length;
        }
    }

}
