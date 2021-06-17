using System;

namespace Dotnet.Core.Camerapi.Enums
{
    public enum eOutputPattern
    {
        Increment,
        
        ///
        /// Replace output pattern (%d) with DateTime (MonthDayHourMinSec)
        ///
        Datetime,

        ///
        /// Replace output pattern (%d) with unix timestamp (seconds since 1970)
        ///
        Timestamp,
    } 
}
