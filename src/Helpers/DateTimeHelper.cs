using System;

namespace Wavy.Helpers
{
    public static class DateTimeHelper
    {
        /// <summary>
        /// Converts the given unix time in seconds to a <see cref="DateTime"/> with <see cref="DateTimeKind.Utc"/> kind.
        /// </summary>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static DateTime CreateDateTimeFromUnixSeconds(long seconds)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var timeInTicks = seconds * TimeSpan.TicksPerSecond;
            return unixEpoch.AddTicks(timeInTicks);
        }

        /// <summary>
        /// Converts the given unix time in milliseconds to a <see cref="DateTime"/> with <see cref="DateTimeKind.Utc"/> kind.
        /// </summary>
        /// <param name="milliseconds"></param>
        /// <returns></returns>
        public static DateTime CreateDateTimeFromUnixMilliseconds(long milliseconds)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var timeInTicks = milliseconds * TimeSpan.TicksPerMillisecond;
            return unixEpoch.AddTicks(timeInTicks);
        }
    }
}