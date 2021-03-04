using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Overloading_Interfaces
{
    class Car
    {
        public static Car[] carArray = new Car[100];
        public static int count = 0;
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
        public Car()
        {
            ++count;
            this[count] = this;
        }
        public Car(string name, string owner, int maxSpeed)
        {
            Name = name;
            Owner = owner;
            MaxSpeed = maxSpeed;
            ++count;
            this[count] = this;            
        }        
        public Car this[int x]
        {
            get
            {
                return carArray[x];
            }
            set
            {
                carArray[x] = value;
            }
        }
        public Car[] this[char x]
        {
            get
            {
                return carArray;
            }
            set
            {
                carArray = value;
            }
        }
        public override string ToString()
        {
            return ($"Car: name - {Name}, owner - {Owner}, max speed km/h - {MaxSpeed}");
        }
    }    
}
