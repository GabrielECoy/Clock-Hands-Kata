using System;

namespace Clock
{
    public class ClockHands
    {
        public static decimal GetAngleInDegrees(int hour, int minute)
        {
            var hourHandleAngle = GetHourAngleHourInDegrees(hour) + GetHourAngleMinuteInDegrees((minute));
            var minuteHandleAngle = GetMinuteAngleInDegrees(minute);

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

        public static decimal GetMinuteAngleInDegrees(int minute)
        {
            double minuteAngle = (double)360 / 60;
            var minuteHandleAngle = (int)Math.Ceiling(minuteAngle * minute);
            
            return minuteHandleAngle;
        }
    }
}