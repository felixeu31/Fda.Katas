using System;
using Xunit;

namespace Fda.Katas.ReverseString
{
    public class UnitTest1
    {
        [Fact]
        public void World()
        {
            Assert.Equal("dlrow", Kata.Solution("world"));
        }
        [Fact]
        public void Word()
        {
            Assert.Equal("drow", Kata.Solution("word"));
        }
        [Fact]
        public void Empty()
        {
            Assert.Equal("", Kata.Solution(null));
        }
    }
}
