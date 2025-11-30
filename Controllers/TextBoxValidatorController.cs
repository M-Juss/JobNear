using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace JobNear
{
    public class TextBoxValidatorController
    {


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
            bool result = Regex.IsMatch(email_input.Text, pattern);

            if (!result)
            {
                MessageBox.Show("Invalid email format.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email_input.Focus();
            }

            return result;
        }

        public static bool ValidatePhoneNumber(TextBox number_input)
        {
            string pattern = @"^09\d{9}$";
            bool result = Regex.IsMatch(number_input.Text, pattern);

            if (!result)
            {
                MessageBox.Show("Invalid phone number. It should start with '09' and be 11 digits long.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                number_input.Focus();
            }

            return result;
        }
    }
}