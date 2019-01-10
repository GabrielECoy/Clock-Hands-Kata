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
        public void three30ShouldReturn75()
        {
            var angle = ClockHands.GetAngleInDegrees(3, 30);
            angle.Should().Be(75);
        }


        [TestMethod]
        public void one45ShouldReturn142point5()
        {
            var angle = ClockHands.GetAngleInDegrees(1, 45);
            angle.Should().Be(142.5);
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
        public void hourHandlesHourOneShouldReturn30()
        {
            var angle = ClockHands.GetHourAngleHourInDegrees(1);
            angle.Should().Be(30);
        }

        [TestMethod]
        public void hourHandlesMinuteOne45ShouldReturn22point5()
        {
            var angle = ClockHands.GetHourAngleMinuteInDegrees(45);
            angle.Should().Be(22.5);
        }

        [TestMethod]
        public void minuteHandles45ShouldReturn270()
        {
            var angle = ClockHands.GetMinuteAngleInDegrees(45);
            angle.Should().Be(270);
        }

        [TestMethod]
        public void angleBetweenHandles195and180Return15()
        {
            var angle = ClockHands.GetAngleBetweenHandlesInDegrees(195,180);
            angle.Should().Be(15);
        }

        [TestMethod]
        public void angleBetweenHandles52point5and270Return142point5()
        {
            var angle = ClockHands.GetAngleBetweenHandlesInDegrees(52.5, 270);
            angle.Should().Be();
        }

    }
}