using System;
using System.Collections.Generic;
using System.Text;

namespace ADClock
{
    public class DigitalClock{
        public void Subscribe(Clock theClock)
        {
            theClock.OnSecondChange += new Clock.SecondChangeHandler(Show);
        }
        public void Show(object obj, EventArgs args)
        {
            DateTime date = DateTime.Now; 
            Console.WriteLine("Digital Clock: {0}:{1}:{2}", date.Hour, date.Minute, date.Second);
        }
    }
}
