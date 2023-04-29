using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests
{
    public class ColletionFixture
    {
        public Collections collec { get; } = new Collections();
    }

    public class CollectionsTest: IClassFixture<ColletionFixture>
    {
        private readonly ColletionFixture _collectionsFixture;
        private readonly ITestOutputHelper _testOutpotHelper;

        public CollectionsTest(ColletionFixture collectionsFixture, ITestOutputHelper testOutpotHelper)
        {
            _collectionsFixture = collectionsFixture;
            _testOutpotHelper = testOutpotHelper;
            _testOutpotHelper.WriteLine("Executing Constructor");
        }

        [Fact]
        [Trait("Category","Collections")]
        public void FiboDoesNotIncludeZero()
        {
            _testOutpotHelper.WriteLine("Executing FiboDoesNotIncludeZero");
            Assert.DoesNotContain(0, _collectionsFixture.collec.FiboNumbes);

            //Assert.All(collection.FiboNumbes, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Collections")]
        public void FiboDoesIncludeOne()
        {
            _testOutpotHelper.WriteLine("Executing FiboDoesIncludeOne");
            Assert.Contains(1, _collectionsFixture.collec.FiboNumbes);
        }

        [Fact]
        [Trait("Category", "Collections")]
        public void CompareCollections()
        {
            _testOutpotHelper.WriteLine("Executing CompareCollections");
            var FiboNumbes = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };

            Assert.Equal(FiboNumbes, _collectionsFixture.collec.FiboNumbes);

        }
        

    }
}
