using System;
using Xunit;
using System.Collections.Generic;
using csharp;

namespace csharp_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Assert.Equal(true, numbers.TwoElementsAddUpToK(5));
        }

        [Fact]
        public void Test2()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Assert.Equal(false, numbers.TwoElementsAddUpToK(25));
        }
    }
}
