using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    public class ToyotaCar : BuilderCar
    {
        Car t = new Car();

        public void AddName()
        {
            Console.WriteLine("Enter Name");
            t.Name = Console.ReadLine();
        }

        public void AddEngine()
        {
            Console.WriteLine("Enter Engine");
            t.Engine = Console.ReadLine();
        }

        public void AddWheel()
        {
            Console.WriteLine("Enter Wheel");
            t.Wheel = int.Parse(Console.ReadLine());
        }

        public void AddChassis()
        {
            Console.WriteLine("Enter Chassis");
            t.Chassis = Console.ReadLine();
        }

        public void AddColor()
        {
            Console.WriteLine("Enter Color");
            t.Color = Console.ReadLine();
        }

        public Car GetCar()
        {
            return t;
        }
    }
}
