using System;
using System.Linq;

namespace BerlinClock.Classes
{
    public class LineFormatter : ILineFormatter
    {
        private readonly char _emptyChar;

        public LineFormatter(char emptyChar)
        {
            _emptyChar = emptyChar;
        }

        public string Format(int position, int length, Func<int, char> coloringFunc)
        {
            var chars = Enumerable.Range(1, length).Select(n => n > position ? _emptyChar : coloringFunc(n));
            return string.Join(string.Empty, chars);
        }
    }
}
