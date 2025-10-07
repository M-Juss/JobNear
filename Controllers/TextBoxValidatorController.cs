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

        public static void ValidateEmail(TextBox email_input)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool result = Regex.IsMatch(email_input.Text, pattern);
            
            if (result)
            {
                return;
            }
            else
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_input.Focus();
            }

        }

        public static void ValidatePhoneNumber(TextBox number_input)
        {
            string pattern = @"^09\d{9}$";
            bool result = Regex.IsMatch(number_input.Text, pattern);

            if (result)
            {
                return;
            }
            else
            {
                MessageBox.Show("Invalid phone number. It should start with '09' and be 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                number_input.Focus();
            }
        }
    }
}
