using NUnit.Framework;
using Shouldly;

namespace LeetCode.Stack.Tests
{
    [TestFixture()]
    public class ClumsyClass_Tests
    {
        [Test()]
        public void Clumsy_Test()
        {
            new ClumsyClass().Clumsy(10).ShouldBe(12);
            new ClumsyClass().Clumsy(4).ShouldBe(7);
            new ClumsyClass().Clumsy(1).ShouldBe(1);
            new ClumsyClass().Clumsy(2).ShouldBe(2);
            new ClumsyClass().Clumsy(3).ShouldBe(6);
        }
    }
}