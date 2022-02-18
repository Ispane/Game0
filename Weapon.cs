using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    
        /// <summary>
        /// Абстрактный класс Оружие
        /// </summary>
        internal abstract class Weapon : ILoot
        {
            private string name;
            private int damage;
            private int durability;

            public string Name { get => name; set => name = value; }
            public int Damage { get => damage; set => damage = value; }
            public int Durability { get => durability; set => durability = value; }

            public ILoot Use()
            {
                return this;
            }

            public void Debuff(int Damage)
            {
                Durability -= Damage;
            }
        }
}

