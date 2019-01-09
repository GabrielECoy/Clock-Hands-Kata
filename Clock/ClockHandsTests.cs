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

        [TestMethod]
        public void hourHandlesHourSix30ShouldReturn180()
        {
            var angle = ClockHands.GetHourAngleHourInDegrees(6);
            angle.Should().Be(180);
        }

        [TestMethod]
        public void hourHandlesMinute30ShouldReturn15()
        {
            var angle = ClockHands.GetHourAngleMinuteInDegrees(30);
            angle.Should().Be(15);
        }

        [TestMethod]
        public void minuteHandles30ShouldReturn180()
        {
            var angle = ClockHands.GetMinuteAngleInDegrees(30);
            angle.Should().Be(180);
        }

        [TestMethod]
        public void angleBetweenHandles195and180Return15()
        {
            var angle = ClockHands.GetAngleBetweenHandlesInDegrees(195,180);
            angle.Should().Be(15);
        }

    }
}