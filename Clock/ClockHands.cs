using System;

namespace Clock
{
    public class ClockHands
    {
        public static decimal GetAngleInDegrees(int hour, int minute)
        {
            var hourHandleAngle = GetHourAngleHourInDegrees(hour) + GetHourAngleMinuteInDegrees((minute));
            var minuteHandleAngle = (360 / 60) * minute;

            var angleBetweenHandles = hourHandleAngle - minuteHandleAngle;
            return angleBetweenHandles;
        }

        public static decimal GetHourAngleHourInDegrees(int hour)
        {
            var hourHandleHourAngle = (360 / 12) * hour;

            return hourHandleHourAngle;
        }

        public static decimal GetHourAngleMinuteInDegrees(int minute)
        {
            double minuteAngle = (double) 360 / (double) 12 / 60;
            var hourHandleMinuteAngle = (int) Math.Ceiling(minuteAngle * minute);

            return hourHandleMinuteAngle;
        }
    }
}