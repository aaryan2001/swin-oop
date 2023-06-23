using NUnit.Framework;
using System;
using ClockWeek3;
namespace ClockTest
{
    [TestFixture]
    public class ClockTest
    {
        Clock ap;

        [Test]
        public void ClockMake()
        {
            ap = new Clock();
            string appear = "00:00:00";

            Assert.AreEqual(appear, ap.Time, "00:00:00");

        }

        [Test]
        public void ClockOneSec()
        {
            ap = new Clock();
            ap.Tick();
            string appear = "00:00:01";

            Assert.AreEqual(appear, ap.Time, "00:00:01");

        }

        [Test]
        public void ClockOneMin()
        {
            ap = new Clock();
            for (int i = 0; i < 61; i++)
            {
                ap.Tick();
            }
            string appear = "00:01:01";

            Assert.AreEqual(appear, ap.Time, "00:01:01");
        }


        [Test]
        public void ClockReset()
        {
            ap = new Clock();
            for (int h = 0; h < 86400; h++) //seco3
            {
                
                        ap.Tick();
                    
            }
            string appear = "00:00:00";

            Assert.AreEqual(appear, ap.Time, "RESET");
        }

        [Test]
        public void ClockRandom()
        {
            ap = new Clock();
            for (int i = 0; i < 6001; i++)
            {
                ap.Tick();
            }
            string appear = "01:40:01";

            Assert.AreEqual(appear, ap.Time, "00:01:01");
        }


        public class CounterTest
        {
            Counter app;

            [Test]
            public void TestCounter()
            {
                app = new Counter("x");

                Assert.AreEqual(0, app.Value, "0");
            }

            [Test]
            public void TIncrement()
            {
                app = new Counter("y");

                for (int i = 0; i < 200; i++)
                {
                    app.Increment();
                }

                Assert.AreEqual(200, app.Value, "200");
            }

            [Test]
            public void TReset()
            {
                app = new Counter("z");

                for (int i = 0; i < 200; i++)
                {
                    app.Increment();
                }

                app.Reset();

                Assert.AreEqual(0, app.Value, "0");
            }

        }

    }
}


