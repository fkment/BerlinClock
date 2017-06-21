using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class MinuteConverter : TimePartConverterBase, ITimePartConverter
    {
        public MinuteConverter(ILineFormatter lineFormatter)
            : base(lineFormatter)
        { }

        public IEnumerable<string> Convert(int minutes)
        {
            var firstLine = LineFormatter.Format(minutes/5, 11, n => n % 3 == 0 ? (char)TimeConverter.Lamp.Red : (char)TimeConverter.Lamp.Yellow);
            var secondLine = LineFormatter.Format(minutes % 5, 4, n => (char)TimeConverter.Lamp.Yellow);

            return new[] {firstLine, secondLine};
        }
    }
}