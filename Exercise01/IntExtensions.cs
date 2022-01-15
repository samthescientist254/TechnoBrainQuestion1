using System;

namespace Exercise01
{

    public static class IntExtensions
    {
        public static bool IsGreaterThan(this Int64 i, Int64 value)
        {
            return i > value;
        }

        public static string NumberToWords1(this long i, long num)
        {
            var beforeFloatingPoint = (Int64)Math.Floor(Convert.ToDouble(num));
            var beforeFloatingPointWord = $"{NumberToWords(beforeFloatingPoint)}";
            var afterFloatingPointWord =
                $"{SmallNumberToWord((int)((num - beforeFloatingPoint) * 100), "")} ";
            return $"{beforeFloatingPointWord}  {afterFloatingPointWord}";
        }

        private static string NumberToWords(long number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            var words = "";

            if (number / 1000000000000000000 > 0)
            {
                words += NumberToWords(number / 1000000000000000000) + " quintillion ";
                number %= 1000000000000000000;
            }

            if (number / 1000000000000000 > 0)
            {
                words += NumberToWords(number / 1000000000000000) + " quadrillion ";
                number %= 1000000000000000;
            }
            if (number / 1000000000000 > 0)
            {
                words += NumberToWords(number / 1000000000000) + " Trillion ";
                number %= 1000000000000;
            }
            if (number / 1000000000 > 0)
            {
                words += NumberToWords(number / 1000000000) + " billion ";
                number %= 1000000000;
            }

            if (number / 1000000 > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if (number / 1000 > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            words = SmallNumberToWord(number, words);

            return words;
        }

        private static string SmallNumberToWord(long number, string words)
        {
            if (number <= 0) return words;
            if (words != "")
                words += " ";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += unitsMap[number];
            else
            {
                words += tensMap[number / 10];
                if ((number % 10) > 0)
                    words += "-" + unitsMap[number % 10];
            }
            return words;
        }





    }
}
