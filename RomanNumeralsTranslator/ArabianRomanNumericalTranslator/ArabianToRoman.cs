using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabianRomanNumericalTranslator
{
    public static class ArabianToRoman
    {
        public static string Translate(int input)
        {
            StringBuilder builder = new StringBuilder();
            int pointer = 0;
            int valueToRead = input;
            while (valueToRead > 0)
            {
                if (valueToRead >= 1000)
                {
                    builder.Append("M");
                    valueToRead -= 1000;
                }
                else if (valueToRead < 1000 && valueToRead >= 900)
                {
                    builder.Append("CM");
                    valueToRead -= 900;
                }
                else if (valueToRead < 900 && valueToRead >= 500)
                {
                    builder.Append("D");
                    valueToRead -= 500;
                }
                else if (valueToRead < 500 && valueToRead >= 400)
                {
                    builder.Append("CD");
                    valueToRead -= 400;
                }
                else if (valueToRead < 400 && valueToRead >= 100)
                {
                    builder.Append("C");
                    valueToRead -= 100;
                }
                else if (valueToRead < 100 && valueToRead >= 90)
                {
                    builder.Append("XC");
                    valueToRead -= 90;
                }
                else if (valueToRead < 90 && valueToRead >= 50)
                {
                    builder.Append("L");
                    valueToRead -= 50;
                }
                else if (valueToRead < 50 && valueToRead >= 40)
                {
                    builder.Append("XL");
                    valueToRead -= 40;
                }
                else if (valueToRead < 40 && valueToRead >= 10)
                {
                    builder.Append("X");
                    valueToRead -= 10;
                }
                else if (valueToRead < 10 && valueToRead >= 9)
                {
                    builder.Append("IX");
                    valueToRead -= 9;
                }
                else if (valueToRead < 9 && valueToRead >= 5)
                {
                    builder.Append("V");
                    valueToRead -= 5;
                }
                else if (valueToRead < 5 && valueToRead >= 4)
                {
                    builder.Append("IV");
                    valueToRead -= 4;
                }
                else if (valueToRead < 4 && valueToRead >= 1)
                {
                    builder.Append("I");
                    valueToRead -= 1;
                }
            }
            return builder.ToString();
        }
    }
}
