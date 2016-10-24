using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabianRomanNumericalTranslator
{
    public static class RomanToArabian
    {
        public static int Translate(string input)
        {
            char[] inputChars = input.ToUpper().ToCharArray();

            List<int> inputAsInt = new List<int>();

            foreach (var character in inputChars)
            {
                int next;
                switch (character)
                {
                    case 'I':
                        next = 1;
                        break;
                    case 'V':
                        next = 5;
                        break;
                    case 'X':
                        next = 10;
                        break;
                    case 'L':
                        next = 50;
                        break;
                    case 'C':
                        next = 100;
                        break;
                    case 'D':
                        next = 500;
                        break;
                    case 'M':
                        next = 1000;
                        break;
                    default:
                        next = 0;
                        break;
                }
                inputAsInt.Add(next);
            }

            int sum = 0;
            int elementsCount = inputAsInt.Count;

            for (int i = 0; i < elementsCount; i++)
            {
                if (i < elementsCount - 1)
                {
                    if (inputAsInt[i] < inputAsInt[i + 1])
                    {
                        sum -= inputAsInt[i];
                    }
                    else
                    {
                        sum += inputAsInt[i];
                    }
                }

                else
                {
                    sum += inputAsInt[i];
                }
            }
            return sum;
        }
    }
}
