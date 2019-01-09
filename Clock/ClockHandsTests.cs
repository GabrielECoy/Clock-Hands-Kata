using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Clock
{
    [TestClass]
    public class ClockHandsTests
    {
        [TestMethod]
        public void MidnightShouldReturn0()
        {
            var angle = ClockHands.GetAngleInDegrees(0, 0);
            angle.Should().Be(0);
        }

        [TestMethod]
        public void sixShouldReturn180()
        {
            var angle = ClockHands.GetAngleInDegrees(6, 0);
            angle.Should().Be(180);
        }

        [TestMethod]
        public void six30ShouldReturn15()
        {
            var angle = ClockHands.GetAngleInDegrees(6, 30);
            angle.Should().Be(15);
        }

    }
}