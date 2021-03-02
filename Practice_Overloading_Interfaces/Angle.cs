using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Overloading_Interfaces
{
    class Angle
    {
        public int Degrees
        {
            get;
            set;
        }
        public int Minutes
        {
            get;
            set;
        }
        public int Seconds
        {
            get;
            set;
        }
        public static Angle operator + (Angle a, Angle b)
        {
            var d = 0;
            var m = 0;
            var s = a.Seconds + b.Seconds;
            if (s >= 60)
            {
                m++;
                s -= 60;
            }
            m += a.Minutes + b.Minutes;
            if(m >= 60)
            {
                d++;
                m -= 60;
            }
            d += a.Degrees + b.Degrees;
            return new Angle{Degrees = d, Minutes = m, Seconds = s};            
        }
        public static Angle operator +(Angle a, int angle)
        {
            return new Angle { Degrees = a.Degrees + angle, Minutes = a.Minutes, Seconds = a.Seconds };
        }        
        public static Angle operator -(Angle a, Angle b)
        {
            var d = 0;
            var m = 0;
            var s = a.Seconds - b.Seconds;
            if (s < 0)
            {
                m--;
                s += 60;
            }
            m = a.Minutes - b.Minutes + m;
            if (m < 0)
            {
                d--;
                m += 60;
            }
            d = a.Degrees - b.Degrees + d;
            return new Angle { Degrees = d, Minutes = m, Seconds = s };
        }
        public static Angle operator -(Angle a, int angle)
        {
            return new Angle { Degrees = a.Degrees - angle, Minutes = a.Minutes, Seconds = a.Seconds };
        }
        public static Angle operator /(Angle a, int b)
        {
            int s = (a.Degrees * 60 + a.Minutes * 60 + a.Seconds * 60) / b;
            int d = s / 60;
            int m = (int)(s % 60 * 0.6 / 60);
            s = s % 60;
            
        }
    }
}
