using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Tests
{
    [CollectionDefinition("Names Fixture")]
    public class NamesFixtureCollection : ICollectionFixture<NamesFixture>
    {
    }
}
