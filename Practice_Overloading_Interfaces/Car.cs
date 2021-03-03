using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Overloading_Interfaces
{
    class Car
    {
        public string Name
        {
            get;
            set;
        }
        public string Owner
        {
            get;
            set;
        }
        public int MaxSpeed
        {
            get;
            set;
        }
        public override string ToString()
        {
            return ($"Car: name - {Name}, owner - {Owner}, max speed km/h - {MaxSpeed}");
        }
    }    
}
