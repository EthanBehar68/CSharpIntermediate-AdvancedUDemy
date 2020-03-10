using System;
using System.Collections.Generic;
using System.Text;

namespace UDemyCSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _stopwatchRunning;

        public Stopwatch()
        {
            _startTime = DateTime.Now;
            _stopTime = DateTime.Now;
        }

        public void Start()
        {
            if(_stopwatchRunning)
            {
                throw new InvalidOperationException("The stopwatch must stop before starting.");
            }

            _stopwatchRunning = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!_stopwatchRunning)
            {
                throw new InvalidOperationException("The stopwatch must start before stopping.");
            }

            _stopTime = DateTime.Now;
            _stopwatchRunning = false;
        }

        public TimeSpan GetDuration()
        {
            return _startTime - _stopTime;
        }
    }
}
