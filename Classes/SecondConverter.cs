using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public class SecondConverter : TimePartConverterBase, ITimePartConverter
    {
        public SecondConverter(ILineFormatter lineFormatter)
            : base(lineFormatter)
        { }

        public IEnumerable<string> Convert(int seconds)
        {
            var line = LineFormatter.Format(1, 1, n => seconds % 2 == 0 ? (char)TimeConverter.Lamp.Yellow : (char)TimeConverter.Lamp.Off);
            return new[] { line };
        }
    }
}