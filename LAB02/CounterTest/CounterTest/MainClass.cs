using System;

namespace CounterTest
{
    public class MainClass
    {
        public static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("{1} is {0}", c.Value, c.Name);
            }

        }
            public static void Main(string[] args)
            {
                Counter[] myCounters = new Counter[3];
                myCounters[0] = new Counter("Counter 1");
                myCounters[1] = new Counter("Counter 2");
                myCounters[2] = myCounters[0];

                for (int i = 0; i < 5; i++)
                {
                    myCounters[0].Increment();
                }

                for (int i = 0; i < 10; i++)
                {
                    myCounters[1].Increment();
                }

                PrintCounters(myCounters);
                myCounters[2].Reset();
                Console.WriteLine("after reset.");
                PrintCounters(myCounters);

            }

    }

}
