using System;

namespace ClassRecipes.Web
{
    public static class Extensions
    {
        public static string ToReadableTimeSpan(this TimeSpan span)
        {
            string formatted = string.Format("{0}{1}{2}",
                span.Duration().Days > 0 ? string.Format("{0:0}d ", span.Days) : string.Empty,
                span.Duration().Hours > 0 ? string.Format("{0:0}h ", span.Hours) : string.Empty,
                span.Duration().Minutes > 0 ? string.Format("{0:0}m", span.Minutes) : string.Empty);
            
            return formatted.Trim();
        }
    }
}