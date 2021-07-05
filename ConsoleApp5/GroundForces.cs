using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class GroundForces : Army
    {
        public GroundForces(int count, double speed, int damageGun) : base(count, speed, damageGun)
        {
            
        }

        public void DamageGroundForces()
        {
            double allDamageGroundForces = Count * DamageGun;
            Console.WriteLine("Это сообщение только для наземных войск! Одновременный урон всех наземных войск равен: " + allDamageGroundForces + " единиц урона.");
        }
        public override void DisplayCount()
        {
            Console.WriteLine("Численность наземных войск: " + Count + " человек.");
        }
        public override void Move()
        {
            Console.WriteLine("Мы наземные войска и передвигаемся по суше со скоростью - " + Speed + " км/ч.");
        }
    }
}
