using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopCar shopcar = new ShopCar(new MardaCar());
            shopcar = new ShopCar(new ToyotaCar());
            shopcar.Run();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("End Program");
            Console.WriteLine("Click Enter...");
            Console.ReadKey();
        }
    }
}
