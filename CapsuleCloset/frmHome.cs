using CapsuleCloset.Processes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapsuleCloset
{
    public partial class frmHome : Form
    {
        DataTable shirts = WardrobeObject.GetWardrobe("Shirts"); //new List<string>();
        DataTable pants = WardrobeObject.GetWardrobe("Pants"); 
        DataTable jac = WardrobeObject.GetWardrobe("Jackets"); 
        DataTable acc = WardrobeObject.GetWardrobe("Accessories"); 

        public frmHome()
        {
            InitializeComponent();
        }

        public frmHome(DataTable s, DataTable p, DataTable j, DataTable a)
        {
            InitializeComponent();
            shirts = s;
            pants = p;
            jac = j;
            acc = a;
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        public void shuffleButton(TextBox day) {

            //frmWardrobe.randomize(frmWardrobe.callShirts());
            //frmWardrobe.randomize(frmWardrobe.callPants());
            //frmWardrobe.randomize(frmWardrobe.callJac());
            //frmWardrobe.randomize(frmWardrobe.callAcc());
        }

        private void btnEditWardrobe_Click(object sender, EventArgs e)
        {
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenWardrobeForm));
            t.Start();
        }

        private void OpenWardrobeForm()
        {
            //RUNs a NEW application with the desired form
            Application.Run(new frmWardrobe(shirts, pants, jac, acc));
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
