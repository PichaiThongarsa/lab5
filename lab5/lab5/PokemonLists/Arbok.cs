using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.PokemonLists
{
    internal class Arbok : Pokemon
    {
        public Arbok()
        {
            Random random = new Random();
            this.name = "Arbok";
            this.hp = random.Next(230  , 324);
            this.atk = random.Next(175 , 317);
            this.image = Properties.Resources.Arbok;
        }
    }
}
