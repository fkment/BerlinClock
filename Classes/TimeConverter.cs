using System;
using System.Linq;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        public enum Lamp { Red = 'R', Yellow = 'Y', Off = 'O' }

        private readonly ITimePartConverter _hourConverter;
        private readonly ITimePartConverter _minuteConverter;
        private readonly ITimePartConverter _secondConverter;

        public TimeConverter(
            ITimePartConverter hourConverter,
            ITimePartConverter minuteConverter,
            ITimePartConverter secondConverter)
        {
            _hourConverter = hourConverter;
            _minuteConverter = minuteConverter;
            _secondConverter = secondConverter;
        }

        public string ConvertTime(string aTime)
        {
            var dateParts = aTime.Split(':').Select(n => Convert.ToInt32(n)).ToArray();

            var hours = dateParts[0];
            var minutes = dateParts[1];
            var seconds = dateParts[2];

            var results = new[]
            {
                _secondConverter.Convert(seconds),
                _hourConverter.Convert(hours),
                _minuteConverter.Convert(minutes)
            };

            var ret = results.SelectMany(n => n);
            return string.Join("\r\n", ret);
        }
    }
}
