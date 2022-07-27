using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    class ShopCar : MenuProgram
    {
        private BuilderCar buildercar;

        public ShopCar(BuilderCar builder)
        {
            buildercar = builder;
        }

        public void CreateCar()
        {
            buildercar.AddName();
            buildercar.AddEngine();
            buildercar.AddWheel();
            buildercar.AddChassis();
            buildercar.AddColor();
        }

        public Car GetCar()
        {
            return buildercar.GetCar();
        }
    }
}
