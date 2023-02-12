using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.PokemonLists
{
    internal class Charizard :Pokemon
    {
        public Charizard() 
        { 
            Random random= new Random();
            this.name = "Charizaed";
            this.hp = random.Next(266, 360) ;
            this.atk= random.Next(155, 293);
            this.image = Properties.Resources.Charizard;
        }
    }
}
