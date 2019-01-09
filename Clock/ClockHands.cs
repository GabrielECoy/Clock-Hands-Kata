using System;

namespace Clock
{
    public class ClockHands
    {
        public static decimal GetAngleInDegrees(int hour, int minute)
        {
            int hourHandleAngle;
            hourHandleAngle = (360 / 12) * hour;

            return hourHandleAngle;
        }
    }
}