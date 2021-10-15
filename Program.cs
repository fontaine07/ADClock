using System;

namespace ADClock
{
    class Program
    {
        public static void Main() { 
            Clock myClock = new Clock(); 
            AnalogClock c1 = new AnalogClock(); 
            DigitalClock c2 = new DigitalClock(); 
            myClock.OnSecondChange += new Clock.SecondChangeHandler(c1.Show); 
            myClock.OnSecondChange += new Clock.SecondChangeHandler(c2.Show); 
            myClock.Run(); }
    }
}
