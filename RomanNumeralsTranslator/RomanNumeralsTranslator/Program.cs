using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArabianRomanNumericalTranslator;

namespace RomanNumeralsTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while(true)
            {
                
                Console.WriteLine("Podaje rzymską liczbę:");
                input = Console.ReadLine();
                Console.WriteLine(ArabianToRoman.Translate(20));
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.Escape)
                    Environment.Exit(0);
            }

        }

        public static int RomanToArabianTranslate(string input)
        {
            string output = "";
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
                if(i<elementsCount-1)
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

        public static string ArabianToRomanTranslate(int input)
        {
            StringBuilder builder = new StringBuilder();
            int pointer=0;
            int valueToRead = input;
            while(valueToRead>0)
            {
                if (valueToRead >= 1000)
                {
                    builder.Append("M");
                    valueToRead -= 1000;
                }     
                else if(valueToRead<1000 && valueToRead>=900)
                {
                    builder.Append("CM");
                    valueToRead -= 900;
                }
                else if(valueToRead<900 && valueToRead>=500)
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
