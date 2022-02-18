using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal interface A
    {
        /// <summary>
        /// Метод для описания поломки, смерти, разрущения обьекта
        /// </summary>
        ILoot[] Destroy();

        /// Метод для описания уменьшения здоровья обьекта, в последствии взаимодействия с чем-то 
        void Debuff(int Damage);

        /// Метод для описания увелечения здоровья обьекта, в последствии взаимодействия с чем-то
        void Buff(int treatment);
    }
}
