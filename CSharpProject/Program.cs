using System;
using System.Globalization;
using System.Linq;
using MathAnalytics;

namespace DotNetVersusR
{
    class Program
    {
        static void Main(string[] args)
        {
            var number_vector = ReadFile();

            Console.WriteLine($"Standard Deviation: {number_vector.StandardDeviation( x=> x)}");
            Console.WriteLine($"Variance: {number_vector.Variance( x=> x)}");
            Console.WriteLine($"Accumulate Compound Interest: {number_vector.AccumulateCompoundInterest( x=> x)}");
        }

        private static double[] ReadFile()
        {
            var lines = System.IO.File.ReadAllLines(@"DoubleNumbers.txt");

            return lines.Select(x => Convert.ToDouble(x, CultureInfo.InvariantCulture)).ToArray();
        }
    }
}
