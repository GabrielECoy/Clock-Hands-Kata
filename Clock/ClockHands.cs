using System;

namespace Clock
{
    public class ClockHands
    {
        public static double GetAngleInDegrees(int hour, int minute)
        {
            var hourHandleAngle = GetHourAngleHourInDegrees(hour) + GetHourAngleMinuteInDegrees((minute));
            var minuteHandleAngle = GetMinuteAngleInDegrees(minute);

            var angleBetweenHandles = GetAngleBetweenHandlesInDegrees(hourHandleAngle , minuteHandleAngle);
            return angleBetweenHandles;
        }

        public static int GetHourAngleHourInDegrees(int hour)
        {
            var hourHandleHourAngle = (360 / 12) * hour;

            return hourHandleHourAngle;
        }

        public static double GetHourAngleMinuteInDegrees(int minute)
        {
            double minuteAngle = (double) 360 / (double) 12 / 60;
            var hourHandleMinuteAngle = minuteAngle * minute;

            return hourHandleMinuteAngle;
        }

        public static double GetMinuteAngleInDegrees(int minute)
        {
            double minuteAngle = (double)360 / 60;
            var minuteHandleAngle = minuteAngle * minute;
            
            return minuteHandleAngle;
        }

        public static double GetAngleBetweenHandlesInDegrees(double hourHandleAngle, double minutesHandleAngle)
        {
            var angleBetweenHandles = Math.Abs(hourHandleAngle - minutesHandleAngle);
            if (angleBetweenHandles > 180)
            {
                angleBetweenHandles = 360 - angleBetweenHandles;
            }

            return angleBetweenHandles;
        }
    }
}