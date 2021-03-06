﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowframes.MiscUtils
{
    class Benchmarker
    {
        static Stopwatch sw = new Stopwatch();

        public static void Start ()
        {
            sw.Restart();
        }

        public static string GetTimeStr (bool stop)
        {
            if (stop)
                sw.Stop();

            return FormatUtils.TimeSw(sw);
        }

        public static TimeSpan GetTime(bool stop)
        {
            if (stop)
                sw.Stop();

            return sw.Elapsed;
        }

        public static long GetTimeMs(bool stop)
        {
            if (stop)
                sw.Stop();

            return sw.ElapsedMilliseconds;
        }
    }
}
