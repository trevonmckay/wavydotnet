using System;

namespace Wavy.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts the current datetime value to unix time in seconds.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static long ToUnixTimeSeconds(this DateTime instance)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var utcDate = instance.ToUniversalTime();
            var ticks = utcDate.Ticks - unixEpoch.Ticks;
            var timeSpan = ticks / TimeSpan.TicksPerSecond;

            return timeSpan;
        }

        /// <summary>
        /// Converts the current datetime value to unix time in milliseconds.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public static long ToUnixTimeMilliseconds(this DateTime instance)
        {
            var unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var utcDate = instance.ToUniversalTime();
            var ticks = utcDate.Ticks - unixEpoch.Ticks;
            var timeSpan = ticks / TimeSpan.TicksPerMillisecond;

            return timeSpan;
        }
    }
}