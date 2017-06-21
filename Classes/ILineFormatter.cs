using System;

namespace BerlinClock.Classes
{
    public interface ILineFormatter
    {
        string Format(int position, int length, Func<int, char> coloringFunc);
    }
}
