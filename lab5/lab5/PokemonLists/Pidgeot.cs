using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.PokemonLists
{
    internal class Pidgeot :Pokemon
    {
        public Pidgeot()
        {
            Random random = new Random();
            this.name = "Pidgeot";
            this.hp = random.Next(276 ,  370);
            this.atk = random.Next(148 , 284);
            this.image = Properties.Resources.Pidgeot;
        }
    }
}
