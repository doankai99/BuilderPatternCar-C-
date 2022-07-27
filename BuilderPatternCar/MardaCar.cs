using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    public class MardaCar : BuilderCar
    {
        Car m = new Car();

        public void AddName()
        {
            Console.WriteLine("Enter Name");
            m.Name = Console.ReadLine();
        }

        public void AddEngine()
        {
            Console.WriteLine("Enter Engine");
            m.Engine = Console.ReadLine();
        }

        public void AddWheel()
        {
            Console.WriteLine("Enter Wheel");
            m.Wheel = int.Parse(Console.ReadLine()) ;
        }

        public void AddChassis()
        {
            Console.WriteLine("Enter Chassis");
            m.Chassis = Console.ReadLine();
        }

        public void AddColor()
        {
            Console.WriteLine("Enter Color");
            m.Color = Console.ReadLine();
        }

        public Car GetCar()
        {
            return m;
        }
    }
}
