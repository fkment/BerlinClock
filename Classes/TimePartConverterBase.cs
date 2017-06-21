namespace BerlinClock.Classes
{
    public abstract class TimePartConverterBase
    {
        protected readonly ILineFormatter LineFormatter;
        
        protected TimePartConverterBase(ILineFormatter lineFormatter)
        {
            LineFormatter = lineFormatter;
        }
    }
}