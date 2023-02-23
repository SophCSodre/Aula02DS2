using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAula02
{
    public partial class FormPokemon : Form
    {
        public FormPokemon()
        {
            InitializeComponent();
        }

        private void rbtCharmander_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.charmander;
        }

        private void rbtSquirtle_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.squirtle;
        }

        private void rbtBulbasaur_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.bulbasaur;
        }

        private void rbtPikachu_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.Pikachu;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rbtAbra_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.abra;
        }

        private void rbtDratini_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.dratini;
        }

        private void rbtEevee_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.eevee;
        }

        private void rbtGrowlithe_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.growlithe;
        }

        private void rbtLapras_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.lapras;
        }

        private void rbtMew_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.mew;
        }

        private void rbtPonyta_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.ponyta;
        }

        private void rbtVulpix_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.vulpix;
        }

        private void rbtJigglypuff_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxPokemon.Image = Properties.Resources.jigglypuff;
        }
    }
}
