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

        DataTable mon = new DataTable();
        List<string> tues = new List<string>();
        List<string> wed = new List<string>();
        List<string> thurs = new List<string>();
        List<string> fri = new List<string>();
        List<string> sat = new List<string>();
        List<string> sun = new List<string>();


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
       
        public static void shuffle(DataTable item)
        {
            //randomize
            //stops program from editing array original values
            DataTable dup = new DataTable();
            dup = item;
            int length = item.Rows.Count;
            DataTable store = new DataTable();
            Random rand = new Random();
            string strStore = string.Empty;

            //takes random element from dup (copy of array) and adds to new array for randomization
            for (int i = 0; i < length; i++)
            {
                int r = rand.Next(0, dup.Rows.Count - 1);
                store.Rows.Add(dup.Rows[r]);

                if (length < 7) { 
                    dup.Rows[r].Delete();
                }
            }

            mon.Rows.Add(store.Rows[0]);
            tues.Add(store[1]);
            wed.Add(store[2]);
            thurs.Add(store[3]);
            fri.Add(store[4]);
            sat.Add(store[5]);
            sun.Add(store[6]);
        }
        
        public void shuffleButton(TextBox day) {
            shuffle(shirts);
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

        private void txtMon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
