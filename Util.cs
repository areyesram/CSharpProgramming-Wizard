using System;
using System.Windows.Forms;

namespace areyesram
{
    class Util
    {
        internal static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal static void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static bool Confirm(string message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                   DialogResult.Yes;
        }

        internal static int CalculateAge(DateTime dob)
        {
            var age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age--;
            return age;
        }
    }
}
