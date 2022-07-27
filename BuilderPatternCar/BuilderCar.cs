using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar
{
    public interface BuilderCar
    {
        void AddName();
        void AddEngine();
        void AddWheel();
        void AddChassis();
        void AddColor();
        Car GetCar();
    }
}
