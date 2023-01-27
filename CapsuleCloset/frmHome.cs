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

        /*readonly DataTable mon = new DataTable();
        readonly DataTable tues = new DataTable();
        readonly DataTable wed = new DataTable();
        readonly DataTable thurs = new DataTable();
        readonly DataTable fri = new DataTable();
        readonly DataTable sat = new DataTable();
        readonly DataTable sun = new DataTable();
        DataTable tues;
        DataTable wed;
        DataTable thurs;
        DataTable fri;
        DataTable sat;
        DataTable sun;*/
        List<string> mon = new List<string>();
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



        public void shuffle(DataTable item)
        {
            //randomize
            //stops program from editing array original values
            List<String> dup = new List<String>();
            List<String> store = new List<String>();
            Random rand = new Random();

            //convert item into list with type string called dup
            for (int i = 0; i < item.Rows.Count; i++) {
                string name = item.Rows[i][0].ToString();                
                int r = rand.Next(0, dup.Count-1);
                dup.Insert(r, name);
            }

            dup = dup.OrderBy(x => rand.Next()).ToList();

            int length = item.Rows.Count;
            string strStore = string.Empty;

            //takes random element from dup (copy of array) and adds to new array for randomization
            for (int i = 0; i < 7; i++)
            {
                store.
                    [i] = dup[r][0].ToString();

                if (length > 7) {
                    dup[r]();
                }
                
            }

            void sync(DataTable day, int i) {
                DataRow row = store.Rows[i];
                day.Rows.Add(row);
            }

            sync(mon, 0);

            /*mon.Rows.Add(store.Rows[0].ToString());
            tues.Rows.Add(store.Rows[1]);
            wed.Rows.Add(store.Rows[2]);
            thurs.Rows.Add(store.Rows[3]);
            fri.Rows.Add(store.Rows[4]);
            sat.Rows.Add(store.Rows[5]);
            sun.Rows.Add(store.Rows[6]);*/
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
            Console.WriteLine(mon.ToString());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            shuffle(shirts);
            shuffle(pants);
            shuffle(jac);
            shuffle(acc);
            Console.WriteLine(mon.ToString());
        }
    }
}
