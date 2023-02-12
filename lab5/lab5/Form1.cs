using lab5.PokemonLists;

namespace lab5
{
    public partial class Form1 : Form
    {
        public List<Pokemon> Pokemons = new List<Pokemon>();
        Pokemon selectPokemon;
        Pokemon selectBoss;
        int selected;
        int heart = 4;

        public Form1()
        {
            InitializeComponent();
            Pokemons.Add(new Arbok());
            Pokemons.Add(new Butterfree());
            Pokemons.Add(new Nidoking());
            Pokemons.Add(new Pidgeot());
            selectBoss = new Charizard();
            this.pictureBox1.Image = selectBoss.getImage();
            this.label6.Text = selectBoss.getName().ToString();
            this.label5.Text = selectBoss.getHp().ToString();
            this.label4.Text = selectBoss.getAtk().ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[0];
            this.CA.Image = selectPokemon.getImage();
            this.label9.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label7.Text = selectPokemon.getAtk().ToString();
            this.selected = 1;

        }

        private void CA_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[1];
            this.CA.Image = selectPokemon.getImage();
            this.label9.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label7.Text = selectPokemon.getAtk().ToString();
            this.selected = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[2];
            this.CA.Image = selectPokemon.getImage();
            this.label9.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label7.Text = selectPokemon.getAtk().ToString();
            this.selected = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectPokemon = Pokemons[3];
            this.CA.Image = selectPokemon.getImage();
            this.label9.Text = selectPokemon.getName();
            this.label8.Text = selectPokemon.getHp().ToString();
            this.label7.Text = selectPokemon.getAtk().ToString();
            this.selected = 4;
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            selectBoss.tqkeDamage(selectPokemon.getAtk());
            this.label5.Text = selectBoss.getHp().ToString();
            await Task.Delay(1500);
            selectPokemon.tqkeDamage(selectBoss.getAtk());
            if (selectPokemon.getHp() <= 0)
            {
                if (selected == 1)
                {
                    this.button1.Hide();
                }
                if (selected == 2)
                {
                    this.button2.Hide();
                }
                if (selected == 3)
                {
                    this.button3.Hide();
                }
                if (selected == 4)
                {
                    this.button4.Hide();
                }
                this.CA.Image = null;
                this.label9.Text = null;
                this.label8.Text = null;
                this.label7.Text = null;
                this.heart -= 1;
                if (heart == 0)
                {
                    MessageBox.Show("You Lose\nGame Over");
                }
                return;
            }
            if (selectBoss.getHp() <= 0)
            {
                MessageBox.Show("You Win");
            }
            this.label8.Text = selectPokemon.getHp().ToString();
        }
    }
}