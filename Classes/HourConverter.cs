using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class HourConverter : TimePartConverterBase, ITimePartConverter
    {
        public HourConverter(ILineFormatter lineFormatter)
            : base(lineFormatter)
        { }

        public IEnumerable<string> Convert(int hours)
        {
            var firstLine = LineFormatter.Format(hours/5, 4, n => (char) TimeConverter.Lamp.Red);
            var secondLine = LineFormatter.Format(hours%5, 4, n => (char) TimeConverter.Lamp.Red);

            return new[] {firstLine, secondLine};
        }
    }
}