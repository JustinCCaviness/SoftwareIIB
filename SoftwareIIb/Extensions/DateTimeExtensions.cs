using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareIIb.Extensions
{
    public static class DateTimeExtensions
    {
        internal static bool Between(this DateTime instant, DateTime dtFrom, DateTime dtThru)
        {
            if (dtFrom > dtThru) throw new ArgumentException("dtFrom may not be after dtThru", "dtFrom");
            bool isBetween = (instant >= dtFrom && instant <= dtThru);
            return isBetween;
        }
        internal static DateTime SaveDateAsUtc(this DateTime date)
        {
            switch(date.Kind)
            {
                case DateTimeKind.Unspecified:
                    date = DateTime.SpecifyKind(date, DateTimeKind.Local);
                    break;
                default:
                    date = date.ToUniversalTime();
                    break;
            }
            return date.ToUniversalTime();
        }
    }
}
