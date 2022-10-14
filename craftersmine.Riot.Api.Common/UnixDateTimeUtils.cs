using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace craftersmine.Riot.Api.Common
{
    internal static class UnixTimeHelper
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1);

        public static DateTime FromUnixTime(this long val)
        {
            return UnixEpoch.AddMilliseconds(val);
        }

        public static long ToUnixTime(this DateTime val)
        {
            if (val == DateTime.MinValue)
                return 0;

            var delta = val - UnixEpoch;

            if (delta.TotalSeconds < 0)
                throw new ArgumentOutOfRangeException(nameof(val), val, "Invalid datetime!");

            return (long) delta.TotalSeconds;
        }
    }
}
