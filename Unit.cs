using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal abstract class Unit
    {
        /// <summary>
        /// Имя персонажа
        /// </summary>
        private string _name;

        /// <summary>
        /// Колличество здоровья
        /// </summary>
        private int _health;


        /// <summary>
        /// 
        /// </summary>
        private ILoot[] _loot;

        public string Name { get => _name; set => _name = value; }
        public int Health { get => _health; set => _health = value; }
        internal ILoot[] Loot { get => _loot; set => _loot = value; }


    }
}
