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
        DataTable shirts = WardrobeObject.GetWardrobe("Shirts");
        DataTable pants = WardrobeObject.GetWardrobe("Pants"); 
        DataTable jac = WardrobeObject.GetWardrobe("Jackets"); 
        DataTable acc = WardrobeObject.GetWardrobe("Accessories");

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
            List<String> dup = new List<String>(item.Rows.Count);
            Random rand = new Random();

            //convert item into list with type string called dup
            for (int i = 0; i < item.Rows.Count; i++) {
                string name = item.Rows[i][0].ToString();                
                //int r = rand.Next(0, item.Rows.Count - 1);
                dup.Insert(i, name);
            }

            //randomizes the order of dup
            dup = dup.OrderBy(x => rand.Next()).ToList();

            //puts contents of shuffled list (dup) in day lists 
            void sync(List<string> day, int i) {
                //syncs 'i' element of dup with specified day
                if (dup.Count() >= 7) {
                    day.Add(dup.ElementAt(i));
                }
                //program will randomly reuse items for categories with less than 7 items
                else if (item.Rows.Count > 1)
                {
                    day.Add(dup.ElementAt(rand.Next(0, dup.Count())));
                }
                //program will not go out of bounds for categories containing a single item
                else if (item.Rows.Count == 1)
                {
                    day.Add(dup.ElementAt(0));
                }
            }

            sync(mon, 0);
            sync(tues, 1);
            sync(wed, 2);
            sync(thurs, 3);
            sync(fri, 4);
            sync(sat, 5);
            sync(sun, 6);
        }

        public void updateText(TextBox txtDay, List<string> listDay) {
            //prints contents of listDay in readable format
            string combinedString = string.Join("\r\n", listDay);
            txtDay.Text = combinedString;
        }

        public void clearText(TextBox txtDay, List<string> listDay) {
            //prevents textboxes from keeping multiple shuffles after new week
            txtDay.Clear();
            listDay.Clear();
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
            shuffle(shirts);
            shuffle(pants);
            shuffle(jac);
            shuffle(acc);
            updateText(txtMon, mon);
            updateText(txtTues, tues);
            updateText(txtWed, wed);
            updateText(txtThurs, thurs);
            updateText(txtFri, fri);
            updateText(txtSat, sat);
            updateText(txtSun, sun);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearText(txtMon, mon);
            clearText(txtTues, tues);
            clearText(txtWed, wed);
            clearText(txtThurs, thurs);
            clearText(txtFri, fri);
            clearText(txtSat, sat);
            clearText(txtSun, sun);
        }
    }
}