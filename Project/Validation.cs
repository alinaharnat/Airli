using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
        public static bool ValidateName(string text, int length)
        {
            if(text.Length == 0 || text.Length < length)
            {
                return false;
            }
            try
            {
                var condition = @"^[А-ЯҐЄІЇ][а-яґєії]*$";
                var reg = new Regex(condition);
                return reg.IsMatch(text);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool ValidateNumber(string text)
        {
            try
            {
                var value = Convert.ToInt32(text);
                var condition = @"^\d+$";
                var reg = new Regex(condition);
                return reg.IsMatch(text);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }

}
