using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.PokemonLists
{
    internal class Nidoking : Pokemon
    {
        public Nidoking()
        {
            Random random = new Random();
            this.name = "Nidoking";
            this.hp = random.Next(272 ,  366);
            this.atk = random.Next(188 , 333);
            this.image = Properties.Resources.Nidoking;
        }
    }
}
