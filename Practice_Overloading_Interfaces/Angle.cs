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
            int degrees = s / 3600;            
            var s1 = (s / 0.36 % 10000) / 100 * 0.6;                       
            int minutes = (int)s1;                        
            int seconds = (int)Math.Round(s1 % 1 * 100 * 0.6);            
            return new Angle { Degrees = degrees, Minutes = minutes, Seconds = seconds };
        }
        public static double operator /(Angle a, Angle b)
        {
            int s1 = (a.Degrees * 3600 + a.Minutes * 60 + a.Seconds);
            int s2 = (b.Degrees * 3600 + b.Minutes * 60 + b.Seconds);                    
            return (double)((int)((double) s1 / s2 * 100)) / 100;
        }
        public static Angle operator *(Angle a, int b)
        {
            int s = (a.Degrees * 3600 + a.Minutes * 60 + a.Seconds) * b;
            int degrees = s / 3600;
            var s1 = (s / 0.36 % 10000) / 100 * 0.6;
            int minutes = (int)s1;
            int seconds = (int)Math.Round(s1 % 1 * 100 * 0.6);
            return new Angle { Degrees = degrees, Minutes = minutes, Seconds = seconds };
        }
        public static bool operator <(Angle a, Angle b)
        {
            if (a.Degrees < b.Degrees)
                return true;
            else if (a.Degrees > b.Degrees)
                return false;
            else if (a.Minutes < b.Minutes)
                return true;
            else if (a.Minutes > b.Minutes)
                return false;
            else if (a.Seconds < b.Seconds)
                return true;
            else
                return false;
        }
        public static bool operator >(Angle a, Angle b)
        {
            if (a.Degrees > b.Degrees)
                return true;
            else if (a.Degrees < b.Degrees)
                return false;
            else if (a.Minutes > b.Minutes)
                return true;
            else if (a.Minutes < b.Minutes)
                return false;
            else if (a.Seconds > b.Seconds)
                return true;
            else
                return false;            
        }
        public static bool operator ==(Angle a, Angle b)
        {
            if (a.Degrees == b.Degrees && a.Minutes == b.Minutes && a.Seconds == b.Seconds)
                return true;
            else
                return false;            
        }
        public static bool operator !=(Angle a, Angle b)
        {
            if (a.Degrees != b.Degrees || a.Minutes == b.Minutes || a.Seconds == b.Seconds)
                return true;
            else
                return false;
        }
        public static bool operator >=(Angle a, Angle b)
        {
            if (a.Degrees > b.Degrees)
                return true;
            else if (a.Degrees < b.Degrees)
                return false;
            else if (a.Minutes > b.Minutes)
                return true;
            else if (a.Minutes < b.Minutes)
                return false;
            else if (a.Seconds > b.Seconds)
                return true;
            else if (a.Seconds < b.Seconds)
                return false;
            else
                return true;
        }
        public static bool operator <=(Angle a, Angle b)
        {
            if (a.Degrees < b.Degrees)
                return true;
            else if (a.Degrees > b.Degrees)
                return false;
            else if (a.Minutes < b.Minutes)
                return true;
            else if (a.Minutes > b.Minutes)
                return false;
            else if (a.Seconds < b.Seconds)
                return true;
            else if (a.Seconds > b.Seconds)
                return false;
            else
                return true;
        }
    }
}
