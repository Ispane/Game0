using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{  
       internal class Enemy : Unit, A
       {
            private Weapon weapon1;
            private Weapon weapon2;
            private Armor armor;

            internal Weapon Weapon1 { get => weapon1; set => weapon1 = value; }
            internal Weapon Weapon2 { get => weapon2; set => weapon2 = value; }
            internal Armor Armor { get => armor; set => armor = value; }

            public void Buff(int treatment)
            {
                throw new NotImplementedException();
            }

            public void Debuff(int Damage)
            {
                Health -= Damage;
            }

            public ILoot[] Destroy()
            {
                return Loot;
            }
       }
}

