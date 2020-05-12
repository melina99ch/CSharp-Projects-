using System;

namespace _12_Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrom(i) && IsDivisible(i) && IsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool IsPalindrom(int num)
        {
            string numberAsStr = num.ToString();
            bool result = true;
            for (int i = 0; i < numberAsStr.Length / 2; i++)
            {
                if (numberAsStr[i] != numberAsStr[numberAsStr.Length - 1 - i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        static bool IsDivisible(int num)
        {
            int lastDigit = 0;
            int sum = 0;
            bool result = false;

            while (num > 0)
            {
                lastDigit = num % 10;
                num = num / 10;
                sum += lastDigit;
            }
            if (sum % 7 == 0)
            {
                result = true;
            }
            return result;
        }

        static bool IsEvenDigit(int num)
        {
            int digit = 0;
            bool result = false;
            while (num > 0)
            {
                digit = num % 10;
                num = num / 10;

                if (digit % 2 == 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
    }
}
