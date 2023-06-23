using System;

namespace ClockWeek3
{
    class Program
    {
        static void Main(string[] args)
        { // to build the clock
            Clock myClock = new Clock();
            // clock loop
            while (true)
            {

                Console.Clear();

                // calling the main functions

                myClock.Tick();
                Console.WriteLine(myClock.Time);
            }

        }
    }
}
