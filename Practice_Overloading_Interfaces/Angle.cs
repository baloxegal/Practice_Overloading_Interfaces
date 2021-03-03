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
            int s = (a.Degrees * 3600 + a.Minutes * 60 + a.Seconds) / b;
            Console.WriteLine(s);
            int degrees = s / 3600;
            Console.WriteLine(degrees);
            int s1 = (int)(s / 3.6) % 1000;            
            Console.WriteLine(s1);            
            var s2 = (float)60 / 100 * s1 / 10;
            Console.WriteLine(s2);
            int minutes = (int)s2;
            Console.WriteLine(minutes);
            int seconds = (int)((float)60 / 100 * (int)(s2 % 1));
            Console.WriteLine(seconds);

            return new Angle { Degrees = degrees, Minutes = minutes, Seconds = seconds };
        }
    }
}
