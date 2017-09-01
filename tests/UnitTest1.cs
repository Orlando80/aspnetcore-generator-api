using System;
using Xunit;
using System.Linq;
using api.Controllers;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void CountShouldControlNumberOfResults()
        {
		var range = new Range { Count =3 };
		var generated = range.Of(() => "");
		Assert.Equal(3, generated.Count());
        }
    }
}
