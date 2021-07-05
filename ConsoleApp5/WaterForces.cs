using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class WaterForces : Army
    {
        public WaterForces(int count, double speed, int damageGun) : base (count, speed, damageGun)
        {

        }
        public void DamageWaterForces()
        {
            double allDamageWaterForces = Count * DamageGun;
            Console.WriteLine("Это сообщение только для водных войск! Одновременный урон всех водных войск равен: " + allDamageWaterForces + " единиц урона.");
        }
        public override void DisplayCount()
        {
            Console.WriteLine("Численность водных войск: " + Count + " единиц.");
        }
        public override void Move()
        {
            Console.WriteLine("А мы водные войска и передвигаемся по воде со скоростью - " + Speed + " км/ч.");
        }

    }
}
