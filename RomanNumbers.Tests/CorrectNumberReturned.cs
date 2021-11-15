using RomanNumberConverter;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RomanNumbers.Tests
{
    public class CorrectNumberReturned
    {
        [Fact]
        public void CorrectNumberIsReturned()
        {
            RomanConverter sut = new RomanConverter();

            int res = sut.GetArabicNumber("I");

            Assert.Equal(1, res);
        }

        [Theory]
        [InlineData("I",1)]
        [InlineData("V", 5)]
        [InlineData("X", 10)]
        [InlineData("L", 50)]
        [InlineData("C", 100)]
        [InlineData("D", 500)]
        [InlineData("M", 1000)]
        public void CorrectRomanMainIsReturned(string testValue,int expectedValue)
        {
            RomanConverter sut = new RomanConverter();

            int res = sut.GetArabicNumber(testValue);

            Assert.Equal(expectedValue, res);
        }

        [Theory]
        [MemberData(nameof(RomanCombinationData))]
        public void CorrectRomanCombinationIsReturned(string testValue, int expectedValue)
        {
            RomanConverter sut = new RomanConverter();

            int res = sut.GetArabicNumber(testValue);

            Assert.Equal(expectedValue, res);
        }


        public static IEnumerable<object[]> RomanCombinationData =>
        new List<object[]>
        {
            new object[] { "IX", 9},
            new object[] { "XI", 11},
            new object[] { "XX",20 },
            new object[] { "XL",40 },
            new object[] { "XLIX",49},
            new object[] { "XCIX", 99},
            new object[] { "CDXCIX", 499},
            new object[] { "CMXCIX", 999},
             new object[] { "DCCL", 750},
        };

    }
}
