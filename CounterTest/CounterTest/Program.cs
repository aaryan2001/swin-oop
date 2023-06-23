using System;

namespace CounterTest
{
    class MainClass
    {
        public static void PrintCounters(Counter[] counters)
        {
            foreach (Counter c in counters)
            {
                Console.WriteLine("hello {0}{1}", );
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
                Console.WriteLine("value of i {0}", myCounters[0]);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("value of i {0}", myCounters[1]);
            }

            for (int i = 0; i < 156; i++)
            {
                Console.WriteLine("value of i is = {0}", i);
            }

        }

    }

}