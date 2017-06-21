using System;
using BerlinClock.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BerlinClock.BDD
{
    [Binding]
    public class TheBerlinClockSteps
    {
        private readonly ITimeConverter _berlinClock;
        private String _theTime;

        public TheBerlinClockSteps()
        {
            var lineFormatter = new LineFormatter((char) TimeConverter.Lamp.Off);

            var hourConverter = new HourConverter(lineFormatter);
            var minuteConverter = new MinuteConverter(lineFormatter);
            var secondConverter = new SecondConverter(lineFormatter);

            _berlinClock = new TimeConverter(hourConverter, minuteConverter, secondConverter);
        }

        [When(@"the time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            _theTime = time;
        }
        
        [Then(@"the clock should look like")]
        public void ThenTheClockShouldLookLike(string theExpectedBerlinClockOutput)
        {
            Assert.AreEqual(theExpectedBerlinClockOutput, _berlinClock.ConvertTime(_theTime));
        }

    }
}
