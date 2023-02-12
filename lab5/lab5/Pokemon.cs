using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class Pokemon
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int atk { get; set; }
        public Bitmap image { get; set; }
        public string getName () { return name; }
        public int getHp () { return hp; }
        public int getAtk () { return atk; }
        public Bitmap getImage () { return image; }

        public void tqkeDamage (int damage)
        {
            this.hp = this.hp - damage;
        }
    }
}
