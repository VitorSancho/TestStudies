using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Calculations.Tests
{
    public class isOddOrEvenDataAttribute : DataAttribute
    {
        public override IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            yield return new object[] { 1 , true};
            yield return new object[] { 200, false};
        }
    }
}
