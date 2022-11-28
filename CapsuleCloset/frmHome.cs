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

        public void shuffle(TextBox day) {

            frmWardrobe.randomize(shirts);

        }

        private void btnEditWardrobe_Click(object sender, EventArgs e)
        {
            frmWardrobe form = new frmWardrobe();
            form.Show();
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {

        }
    }
}
