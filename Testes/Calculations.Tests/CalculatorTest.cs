using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TesteAdd()
        {
            Assert.True(true);
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.3, 1.5);
            Assert.Equal(2.8, result,2);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(200, false)]
        public void IdOdd_TestIsOddOrEven(int value, bool expected )
        {
            var calc = new Calculator();
            var result = calc.IdOdd(value);
            Assert.Equal(expected,result);
        }

        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData),MemberType = typeof(TestDataShare))]
        public void IdOdd_TestIsOddOrEven_withSharedData(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IdOdd(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [isOddOrEvenData]
        public void IdOdd_TestIsOddOrEven_withDataAttribute(int value, bool expected)
        {
            var calc = new Calculator();
            var result = calc.IdOdd(value);
            Assert.Equal(expected, result);
        }
    }
}
