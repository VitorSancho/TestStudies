using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    [Collection("Names Fixture")]
    public class NamesTest
    {
        private readonly NamesFixture _namesFixture;

        public NamesTest(NamesFixture namesFixture)
        {
            _namesFixture = namesFixture;   
        }

        [Fact]
        public void MakeFullNameTest()
        {
            var result = _namesFixture.namesFixture.MakeFullName("Vitor", "Cardoso");
            //Assert.Equal("Vitor Cardoso", result);
            //Assert.Contains("Vitor", result);
            //Assert.Equal("Vitor Cardoso", result, ignoreCase:true);
            //Assert.StartsWith("Vit", result);
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        [Fact]
        public void MakeFullNameTest_AlwaysReturnValue()
        {
            var result = _namesFixture.namesFixture.MakeFullName("Vitor", "Cardoso");
            Assert.NotNull(result);  
            //Assert.True(!string.IsNullOrEmpty(result));
        }
    }
}
