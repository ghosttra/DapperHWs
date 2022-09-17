using System;

namespace bflib {
    public class BasicFunctions {
        public static string DateFormatToStringSQL(DateTime date) {
            return $"{date.Year}-{date.Month}-{date.Day}";
        }
        public static string DateTimeFormatToStringSQL(DateTime date) {
            return $"{DateFormatToStringSQL(date)} {date.Hour}:{date.Minute}:{date.Second}:{date.Millisecond}";
        }
    }
}
