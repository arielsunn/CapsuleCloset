using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsuleCloset
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        public void shuffleButton(TextBox day) {

            frmWardrobe.randomize(frmWardrobe.shirts());
            frmWardrobe.shuffle(frmWardrobe.callTues());
            frmWardrobe.shuffle(frmWardrobe.callWed());
            frmWardrobe.shuffle(frmWardrobe.callThurs());
            frmWardrobe.shuffle(frmWardrobe.callFri());
            frmWardrobe.shuffle(frmWardrobe.callSat());
            frmWardrobe.shuffle(frmWardrobe.callSun());

        }

        private void btnEditWardrobe_Click(object sender, EventArgs e)
        {
            frmWardrobe form = new frmWardrobe();
            form.Show();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

        }

        private void txtMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTues_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWed_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThurs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFri_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSun_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
