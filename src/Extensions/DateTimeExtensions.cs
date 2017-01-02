using System;

namespace Wavy.Extensions
{
    public static class DateTimeExtensions
    {
        public static long ToUnixTime(this DateTime instance)
        {
            var timeSpan = (instance.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0));
			return (long)timeSpan.TotalSeconds;
        }
    }
}