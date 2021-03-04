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
            Angle x = a - 22;
            Console.WriteLine($"Angle is: {x.Degrees}, {x.Minutes}, {x.Seconds}");


            Angle d = new Angle { Degrees = 48, Minutes = 42, Seconds = 54 };
            Angle e = new Angle { Degrees = 126, Minutes = 32, Seconds = 31 };

            Angle f = d + e;
            Console.WriteLine($"Angle is: {f.Degrees}, {f.Minutes}, {f.Seconds}");
            Angle y = e + 12;
            Console.WriteLine($"Angle is: {y.Degrees}, {y.Minutes}, {y.Seconds}");

            Angle g = d / 2;
            Console.WriteLine($"Angle is: {g.Degrees}, {g.Minutes}, {g.Seconds}");
            
            Console.WriteLine(b / a);

            Angle j = g * 2;
            Console.WriteLine($"Angle is: {j.Degrees}, {j.Minutes}, {j.Seconds}");

            Console.WriteLine(a > b);
            Console.WriteLine(e > d);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(j == d);

            //Car Array
            Car[] cars1 = { new Car { Name = "Volvo", Owner = "Vasea", MaxSpeed = 250 },
                            new Car { Name = "VW", Owner = "Petea", MaxSpeed = 230 },
                            new Car { Name = "BMW", Owner = "Sergiu", MaxSpeed = 290 },
                            new Car { Name = "Viper", Owner = "John", MaxSpeed = 390 },
                            new Car { Name = "Mercedes", Owner = "Andrei", MaxSpeed = 320 },};
            Car[] cars2 = { new Car ( "Seat", "Igor", 280 ),
                            new Car ( "Kamaz", "Marcel", 130 ),
                            new Car ( "Opel", "Alex", 190 ),
                            new Car ( "Omega", "Ion", 590 ),
                            new Car ( "Zaparojets", "Colea", 690 ),};

            foreach (var cx in cars1){
                Console.WriteLine(cx);
            }
            Console.WriteLine("=================================================");
            foreach (var cx in cars2)
            {
                Console.WriteLine(cx);
            }
            Console.WriteLine("=================================================");            
            foreach (var cx in Car.carArray)
            {
                if(cx != null)
                    Console.WriteLine(cx);
            }
            Console.WriteLine("=================================================");
            var sortedCars1 = cars1.OrderBy(cv => cv.MaxSpeed);
            foreach (var cy in sortedCars1)
            {
                Console.WriteLine(cy);
            }
            Console.WriteLine("=================================================");
            var sortedCars2 = cars2.OrderBy(cv => cv.MaxSpeed);
            foreach (var cy in sortedCars2)
            {
                Console.WriteLine(cy);
            }
            Console.WriteLine("=================================================");
            var sortedCars3 = Car.carArray.Where(cv => cv != null).OrderBy(cv => cv.MaxSpeed);
            foreach (var cy in sortedCars3)
            {
                Console.WriteLine(cy);
            }
            Console.WriteLine("=================================================");
        }
    }
}
