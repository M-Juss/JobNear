using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JobNear
{
    public class TextBoxValidatorController
    {
        public static void SetPassword(TextBox password_input)
        {
            password_input.UseSystemPasswordChar = true;
        }

        public static void AllowOnlyNumbers(TextBox number_input)
        {
            number_input.KeyPress += (sender, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        public static bool ValidateEmail(TextBox email_input)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email_input.Text, pattern);
        }

        public static bool ValidatePhoneNumber(TextBox number_input)
        {
            string pattern = @"^09\d{9}$";
            return Regex.IsMatch(number_input.Text, pattern);
        }
    }
}
