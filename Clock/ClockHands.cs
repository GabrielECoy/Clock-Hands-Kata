using System;

namespace Clock
{
    public class ClockHands
    {
        private const double totalDegreesInClock = 360;
        private const int totalHoursInClock = 12;
        private const int totalMinutesInHour = 60;

        public static double GetAngleInDegrees(int hour, int minute)
        {
            var hourHandleAngle = GetHourAngleHourInDegrees(hour) + GetHourAngleMinuteInDegrees((minute));
            var minuteHandleAngle = GetMinuteAngleInDegrees(minute);

            var angleBetweenHandles = GetAngleBetweenHandlesInDegrees(hourHandleAngle , minuteHandleAngle);
            return angleBetweenHandles;
        }

        public static double GetHourAngleHourInDegrees(int hour)
        {
            var hourHandleHourAngle = (totalDegreesInClock / totalHoursInClock) * hour;

            return hourHandleHourAngle;
        }

        public static double GetHourAngleMinuteInDegrees(int minute)
        {
            double minuteAngle = totalDegreesInClock / (double) totalHoursInClock / totalMinutesInHour;
            var hourHandleMinuteAngle = minuteAngle * minute;

            return hourHandleMinuteAngle;
        }

        public static double GetMinuteAngleInDegrees(int minute)
        {
            double minuteAngle = totalDegreesInClock / totalMinutesInHour;
            var minuteHandleAngle = minuteAngle * minute;
            
            return minuteHandleAngle;
        }

        public static double GetAngleBetweenHandlesInDegrees(double hourHandleAngle, double minutesHandleAngle)
        {
            var angleBetweenHandles = Math.Abs(hourHandleAngle - minutesHandleAngle);
            var otherAngleBetweenHandle = totalDegreesInClock - angleBetweenHandles;
            if (angleBetweenHandles < totalDegreesInClock - angleBetweenHandles)
            {
                return angleBetweenHandles;
            }
            else
            {
                return otherAngleBetweenHandle;
            }
        }
    }
}