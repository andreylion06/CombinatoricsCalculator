using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricsCalculator.HelperClasses
{
    public static class TextValidator
    {
        public enum ValidationType
        {
            Amount,
            Integer
        }

        /// <summary>
        /// Validate a textbox on text change.
        /// </summary>
        /// <param name="tbx"></param>
        /// <param name="validationType"></param>
        public static void Validate(this TextBox tbx, ValidationType validationType, int length)
        {
            tbx.PerformValidation(validationType, length);
            tbx.Select(tbx.Text.Length, 0);
        }


        private static void PerformValidation(this TextBox tbx, ValidationType validationType, int length)
        {
            char[] enteredString = tbx.Text.ToCharArray();

            if (enteredString.Length > length)
            {
                tbx.Text = tbx.Text.Substring(0, tbx.Text.Length - 1);
            }
            else
            {
                switch (validationType)
                {
                    case ValidationType.Amount:
                        tbx.Text = AmountValidation(enteredString);
                        break;

                    case ValidationType.Integer:
                        tbx.Text = IntegerValidation(enteredString);
                        break;

                    default:
                        break;
                }
            }
            tbx.SelectionStart = tbx.Text.Length;
        }



        private static string AmountValidation(char[] enteredString)
        {
            string actualString = string.Empty;
            int count = 0;
            foreach (char c in enteredString.AsEnumerable())
            {
                if (count >= 1 && c == '.')
                { actualString.Replace(c, ' '); actualString.Trim(); }
                else
                {
                    if (char.IsDigit(c))
                    {
                        actualString = actualString + c;
                    }

                    if (c == '.')
                    {
                        actualString = actualString + c; count++;
                    }

                    else
                    {
                        actualString.Replace(c, ' ');
                        actualString.Trim();
                    }
                }
            }
            return actualString;
        }


        private static string IntegerValidation(char[] enteredString)
        {
            string actualString = string.Empty;
            foreach (char c in enteredString.AsEnumerable())
            {
                if (char.IsDigit(c))
                {
                    actualString = actualString + c;
                }
                else
                {
                    actualString.Replace(c, ' ');
                    actualString.Trim();
                }
            }
            return actualString;
        }
    }
}
