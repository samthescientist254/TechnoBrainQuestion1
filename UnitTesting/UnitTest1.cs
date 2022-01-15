using Exercise01;
using System;
using Xunit;

namespace UnitTesting
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("EIGHTEEN THOUSAND", 18000)]
        [InlineData("FIVE HUNDRED  THOUSAND", 500000)]
        [InlineData("THIRTY-EIGHT THOUSAND", 38000)]
        public void CheckWords( string words, long expected)
        {

            string word = Convert.ToInt64(expected).NumberToWords1(Convert.ToInt64(expected)).Trim().ToUpper();
            Assert.Equal(words, word);
        }
    }
}
