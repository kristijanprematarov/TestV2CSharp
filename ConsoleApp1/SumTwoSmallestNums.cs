using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class SumTwoSmallestNums : ISumTwoSmallestNums
    {
        public void ReturnSum(string numbers)
        {
            double[] numbersDoubleArray = Array.ConvertAll(numbers.Split(","), double.Parse);
            Array.Sort(numbersDoubleArray);
            List<double> posIntegers = new List<double>();
            for (int i = 0; i < numbersDoubleArray.Length; i++)
            {
                if (numbersDoubleArray[i] >= 0)
                    posIntegers.Add(numbersDoubleArray[i]);
            }
            double sumMin = posIntegers[0] + posIntegers[1];
            Console.WriteLine("\n");
            Console.WriteLine("The two smallest numbers are: {0} and {1}", posIntegers[0], posIntegers[1]);
            Console.WriteLine("Their sum is:{0}", sumMin);
        }
    }
}
