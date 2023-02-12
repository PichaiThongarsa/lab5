using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.PokemonLists
{
    internal class Butterfree :Pokemon
    {
        public Butterfree()
        {
            Random random = new Random();
            this.name = "Butterfree";
            this.hp = random.Next(230 ,  324);
            this.atk = random.Next(85 ,  207);
            this.image = Properties.Resources.Butterfree;
        }
    }
}
