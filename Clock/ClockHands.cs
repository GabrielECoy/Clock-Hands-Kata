using System;

namespace Clock
{
    public class ClockHands
    {
        public static decimal GetAngleInDegrees(int hour, int minute)
        {
            var hourHandleAngle = (360 / 12) * hour;
            hourHandleAngle += (360 / 12 / 60) * minute;

            var minuteHandleAngle = (360 / 60) * minute;

            var angleBetweenHandles = hourHandleAngle - minuteHandleAngle;
            return angleBetweenHandles;
        }
    }
}