﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}