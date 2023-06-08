using Employees.Validators;
using System.Windows.Forms;

namespace Employees.Helper
{
    public static class TextBoxValidateAndChangeInput
    {
        public static void TextBoxValidator(TextBox textBox)
        {
            while (!NameValidator.IsValidName(textBox.Text) && !string.IsNullOrEmpty(textBox.Text))
            {

                MessageBox.Show("Every symbol of name should be a letter");
                textBox.Text = textBox.Text.Remove(textBox.SelectionStart - 1, 1);
                textBox.SelectionStart = textBox.Text.Length;
                return;
            }
        }
    }
}
