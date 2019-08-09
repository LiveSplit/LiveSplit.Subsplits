using System;

namespace LiveSplit.TimeFormatters
{
    public class RegularSubsplitTimeFormatter : ITimeFormatter
    {
        public TimeAccuracy Accuracy { get; set; }

        public RegularSubsplitTimeFormatter(TimeAccuracy accuracy)
        {
            Accuracy = accuracy;
        }
        public string Format(TimeSpan? time)
        {
            var formatter = new RegularTimeFormatter(Accuracy);
            if (time == null)
                return TimeFormatConstants.DASH;

            return formatter.Format(time);
        }
    }
}
