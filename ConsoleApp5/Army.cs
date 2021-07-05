using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Army : ICharacteristics
    {
        public double Speed { get; set; }
        public int Count { get; set; }
        public int DamageGun { get; set; }
        public Army(int count, double speed, int damageGun)
        {
            DamageGun = damageGun;
            Speed = speed;
            Count = count;
        }
        public virtual void DisplayCount()
        {
            Console.WriteLine("Информация по численности армии.");
        }
        public virtual void Move()
        {
            Console.WriteLine("Информация по способу передвижения войска.");
        }

    }
}
