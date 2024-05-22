using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

                var newEmail = new System.Net.Mail.MailAddress(email);
                return newEmail.Address == email;
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
