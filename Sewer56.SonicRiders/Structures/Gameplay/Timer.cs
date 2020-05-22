﻿using System;

namespace Sewer56.SonicRiders.Structures.Gameplay
{
    public struct Timer
    {
        public byte Milliseconds { get; set; }
        public byte Seconds { get; set; }
        public byte Minutes { get; set; }

        public Timer(byte milliseconds, byte seconds, byte minutes)
        {
            Milliseconds = milliseconds;
            Seconds = seconds;
            Minutes = minutes;
        }

        public TimeSpan ToTimeSpan() => new TimeSpan(0, 0, Minutes, Seconds, Milliseconds);
        public static Timer FromTimeSpan(TimeSpan span) => new Timer((byte)(span.Milliseconds / 10), (byte)span.Seconds, (byte)span.Minutes);
    }
}
