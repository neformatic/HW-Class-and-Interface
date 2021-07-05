using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GroundForces groundFroces = new GroundForces(50, 20, 10);
            WaterForces waterForces = new WaterForces(20, 120, 150);

            groundFroces.DisplayCount();
            waterForces.DisplayCount();
            groundFroces.Move();
            waterForces.Move();
            groundFroces.DamageGroundForces();
            waterForces.DamageWaterForces();

            Console.ReadKey();

        }
    }
}
