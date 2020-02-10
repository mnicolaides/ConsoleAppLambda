using System;
using System.Linq;

namespace ConsoleAppLambda
{
    /// <summary>
    /// https://www.youtube.com/watch?v=kYeKFMf2mO8
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "bot", "apple", "apricot" };
            int minimalLength = words
              .Where(w => w.StartsWith("a"))
              .Min(w => w.Length);
            Console.WriteLine(minimalLength);   // output: 5

            int[] numbers = { 1, 4, 7, 10 };
            int product = numbers
                .Aggregate(1, (interim, next) => interim * next);
            Console.WriteLine(product);   // output: 280
        }
    }

    class Person
    {
        public string Fname { set; get; }
        public string Lname { set; get; }
        public override string ToString() => $"{Fname} {Lname}".Trim();
    }
}
