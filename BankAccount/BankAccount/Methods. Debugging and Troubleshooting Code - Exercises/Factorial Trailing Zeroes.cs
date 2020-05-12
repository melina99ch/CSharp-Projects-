using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14_Trailing_Zeros1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = GetFactoriel(n);
            Console.WriteLine(GetNumberOfZeros(factoriel));

        }

        static BigInteger GetFactoriel(int n)
        {
            BigInteger factoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }

        static int GetNumberOfZeros(BigInteger factoriel)
        {
            int starter = 1;
            int counter = 0;
            string facStr = factoriel.ToString();
            while (starter <= facStr.Length - 1)
            {
                BigInteger lastDigit = factoriel % 10;
                if (lastDigit.IsZero)
                {
                    counter++;
                }
                else
                {
                    break;
                }
                factoriel = factoriel / 10;
                starter++;
            }
        
            return counter;
        }
    }
}
