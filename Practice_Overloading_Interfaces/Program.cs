using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Overloading_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a = new Angle{ Degrees = 42, Minutes = 16, Seconds = 34 };
            Angle b = new Angle { Degrees = 56, Minutes = 22, Seconds = 59 };
            Angle c = a - b;
            Console.WriteLine($"Angle is: {c.Degrees}, {c.Minutes}, {c.Seconds}");

            Angle d = new Angle { Degrees = 48, Minutes = 41, Seconds = 54 };
            Angle e = new Angle { Degrees = 126, Minutes = 32, Seconds = 31 };
            Angle f = d + e;
            Console.WriteLine($"Angle is: {f.Degrees}, {f.Minutes}, {f.Seconds}");
        }
    }
}
