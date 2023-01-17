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

        public static void shuffle(DataTable item, int x)
        {
            //randomize
            List<string> list = new List<string>();
            string store;

            for (int i = 0; i < item.Rows.Count; i++)
            {
                item.ToString("\n");
                list.Add(item.ToString(" \n " + item.Rows[i]));
                list.StudentId = Convert.ToInt32(dt.Rows[i]["StudentId"]);
                student.StudentName = dt.Rows[i]["StudentName"].ToString();
                student.Address = dt.Rows[i]["Address"].ToString();
                student.MobileNo = dt.Rows[i]["MobileNo"].ToString();
                studentList.Add(student);
            }

            //stops program from editing array original values
            List<string> dup = new List<string>(item); ;
            int length = item.Count;
            List<string> store = new List<string>(length - 1);
            Random rand = new Random();
            string strStore = string.Empty;

            //takes random element from dup (copy of array) and adds to new array for randomization
            for (int i = 0; i < length; i++)
            {
                int r = rand.Next(0, dup.Count - 1);
                store.Add(dup[r]);
                dup.RemoveAt(r);
            }

            mon.Add(store[0]);
            tues.Add(store[1]);
            wed.Add(store[2]);
            thurs.Add(store[3]);
            fri.Add(store[4]);
            sat.Add(store[5]);
            sun.Add(store[6]);

            //prints the new randomized array into new textbox
            foreach (string strName in store)
            {
                strStore += strName + "\r\n";
            }
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
    }
}
