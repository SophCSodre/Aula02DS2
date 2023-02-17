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
    }
}
