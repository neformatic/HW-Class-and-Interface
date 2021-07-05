using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface ICharacteristics
    {
        int Count { get; set; }
        double Speed { get; set; }
        int DamageGun { get; set; } 
        void DisplayCount();
        void Move();
      
    }
}
