using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Sword : Weapon
    {
        private string material;

        public string Material { get => material; set => material = value; }
        public void Debuff(int Damage)
        {
            Durability -= Damage;

        }

        public void Buff(int treatment)
        {
            throw new NotImplementedException();

        }

        public void Destroy(int treatment)
        {
            throw new NotImplementedException();

        }
    }
}
