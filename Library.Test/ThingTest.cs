using System;
using Library;
using Xunit;

namespace Library.Test
{
    public class ThingTest
    {
        [Fact]
        public void ThingGetsObjectValFromNumber()
        {
            Assert.Equal(42, new Thing().Get(42));
        }
    }
}
