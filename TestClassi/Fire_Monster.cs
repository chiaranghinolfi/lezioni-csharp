using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassi
{
    class Fire_Monster : Monster
    {
        public int fireDamage { get; set; }

        public Fire_Monster(string name, int maxHp, int damage, int fireDamage) : base(name, maxHp, damage, 0)
        {
            this.fireDamage = fireDamage;
        }
    }
}
