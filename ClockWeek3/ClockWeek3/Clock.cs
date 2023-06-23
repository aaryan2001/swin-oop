using System;
using System.Collections.Generic;
namespace ClockWeek3
{
    public class Clock
    {
        
        // to store the time variables ie. sec hour min
        private readonly List<Counter> _counters;

        public Clock()
        {
            _counters = new List<Counter>();

            for (int sec = 0; sec <= 2; sec++)
            {
                _counters.Add(new Counter("Time" + sec.ToString()));
            }

        }
        // ticker for clock gives it idea when 1 minute is over
        public void Tick()
        {
            _counters[0].Increment();
            // for sec
            if (_counters[0].Value >= 60)
            {
                _counters[0].Reset();
                _counters[1].Increment();
            }
            //for min
            if (_counters[1].Value >= 60)
            {
                _counters[1].Reset();
                _counters[2].Increment();
            }
            // for hour
            if (_counters[2].Value >= 24)
            {
                _counters[2].Reset();         //resets the clock as one day passes
            }

        }

        // to access the time in tests <<readonly>>
        public string Time
        {
            get
            {
                string time = _counters[2].Value.ToString("00") + ":" + _counters[1].Value.ToString("00") + ":" + _counters[0].Value.ToString("00");
                return time;
            }
        }
    }
}
