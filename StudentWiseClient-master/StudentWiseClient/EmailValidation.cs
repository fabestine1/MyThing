using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWiseClient
{
    class EmailValidation
    {
        /// <summary>
        /// Checks if the given email is valid
        /// </summary>
        /// <param name="email"> the email to check </param>
        /// <returns> if the email is valid </returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
