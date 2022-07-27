using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    public class Car
    {
        private string name;
        private string engine;
        private int wheel;
        private string chassis;
        private string color;

        public string Name { get; set; }
        public string Engine { get; set; }
        public int Wheel { get; set; }
        public string Chassis { get; set; }
        public string Color { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Infomation Car");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Engine: " + Engine);
            Console.WriteLine("Wheel: " + Wheel);
            Console.WriteLine("Chassis: " + Chassis);
            Console.WriteLine("Color: " + Color);
        }

    }
}
