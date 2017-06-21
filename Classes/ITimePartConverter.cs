using System.Collections.Generic;

namespace BerlinClock.Classes
{
    public interface ITimePartConverter
    {
        IEnumerable<string> Convert(int timePart);
    }
}