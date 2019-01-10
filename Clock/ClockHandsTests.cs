using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace Clock
{
    [TestClass]
    public class ClockHandsTests
    {
        [TestMethod]
        public void GetAngleInDegrees_MidnightShouldReturn0()
        {
            var angle = ClockHands.GetAngleInDegrees(0, 0);
            angle.Should().Be(0);
        }

        [TestMethod]
        public void GetAngleInDegrees_Zero1ShouldReturn5Point5()
        {
            var angle = ClockHands.GetAngleInDegrees(0, 1);
            angle.Should().Be(5.5);
        }

        [TestMethod]
        public void GetAngleInDegrees_One45ShouldReturn142Point5()
        {
            var angle = ClockHands.GetAngleInDegrees(1, 45);
            angle.Should().Be(142.5);
        }

        [TestMethod]
        public void GetAngleInDegrees_SixOClockShouldReturn180()
        {
            var angle = ClockHands.GetAngleInDegrees(6, 0);
            angle.Should().Be(180);
        }

        [TestMethod]
        public void GetAngleInDegrees_Six30ShouldReturn15()
        {
            var angle = ClockHands.GetAngleInDegrees(6, 30);
            angle.Should().Be(15);
        }

        [TestMethod]
        public void GetAngleInDegrees_Three30ShouldReturn75()
        {
            var angle = ClockHands.GetAngleInDegrees(3, 30);
            angle.Should().Be(75);
        }
        
        [TestMethod]
        public void GetHourAngleHourInDegrees_SixShouldReturn180()
        {
            var angle = ClockHands.GetHourAngleHourInDegrees(6);
            angle.Should().Be(180);
        }

        [TestMethod]
        public void GetHourAngleMinuteInDegrees_30ShouldReturn15()
        {
            var angle = ClockHands.GetHourAngleMinuteInDegrees(30);
            angle.Should().Be(15);
        }

        [TestMethod]
        public void GetMinuteAngleInDegrees_30ShouldReturn180()
        {
            var angle = ClockHands.GetMinuteAngleInDegrees(30);
            angle.Should().Be(180);
        }

        [TestMethod]
        public void GetAngleBetweenHandlesInDegrees_195and180ShouldReturn15()
        {
            var angle = ClockHands.GetAngleBetweenHandlesInDegrees(195, 180);
            angle.Should().Be(15);
        }

        [TestMethod]
        public void GetHourAngleHourInDegrees_OneShouldReturn30()
        {
            var angle = ClockHands.GetHourAngleHourInDegrees(1);
            angle.Should().Be(30);
        }

        [TestMethod]
        public void GetHourAngleMinuteInDegrees_45ShouldReturn22point5()
        {
            var angle = ClockHands.GetHourAngleMinuteInDegrees(45);
            angle.Should().Be(22.5);
        }

        [TestMethod]
        public void GetMinuteAngleInDegrees_45ShouldReturn270()
        {
            var angle = ClockHands.GetMinuteAngleInDegrees(45);
            angle.Should().Be(270);
        }

        [TestMethod]
        public void GetAngleBetweenHandlesInDegrees_52Point5and270ShouldReturn142Point5()
        {
            var angle = ClockHands.GetAngleBetweenHandlesInDegrees(52.5, 270);
            angle.Should().Be(142.5);
        }

    }
}