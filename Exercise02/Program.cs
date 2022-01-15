using Exercise01;
using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ulong xy = 38000;
            string words = Convert.ToInt64(xy).NumberToWords1(Convert.ToInt64(xy)).Trim().ToUpper();
            Console.WriteLine("Words");
            Console.WriteLine(words);
        }
    }
}
