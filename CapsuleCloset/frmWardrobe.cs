using System;
using System.Collections;
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
    public partial class frmWardrobe : Form
    {
        public frmWardrobe()
        {
            InitializeComponent();
        }

        public static List<string> shirts { get; set; }
       // ArrayList shirts = new ArrayList();
        string strShirts = string.Empty;

        public static List<string> pants { get; set; }
        //ArrayList pants = new ArrayList();
        string strPants = string.Empty;

        public static List<string> jac { get; set; }
        //ArrayList jac = new ArrayList();
        string strJac = string.Empty;

        public static List<string> acc { get; set; }
        //ArrayList acc = new ArrayList();
        string strAcc = string.Empty;

        public static List<string> mon { get; set; }
        public static List<string> tues { get; set; }
        public static List<string> wed { get; set; }
        public static List<string> thurs { get; set; }
        public static List<string> fri { get; set; }
        public static List<string> sat { get; set; }
        public static List<string> sun { get; set; }

        private void frmWardrobe_Load(object sender, EventArgs e)
        {
            //initial 7 shirts
            /*for (int i = 0; i < 7; i++)
            {
                shirts.Add("shirt" + i);
                shirts[i] = "Shirt " + i;
            }*/

            //Iterating through items - Using foreach loop, then print within respective textbox
            foreach (string strName in shirts)
            {
                strShirts += strName + "\r\n";
            }

            txtShirts.Text = strShirts;
            Console.WriteLine(strShirts);
        }

        public static List<string> callMon() {
            return mon;
        }

        public static List<string> callTues()
        {
            return tues;
        }

        public static List<string> callWed()
        {
            return wed;
        }

        public static List<string> callThurs()
        {
            return thurs;
        }
        public static List<string> callFri()
        {
            return fri;
        }
        public static List<string> callSat()
        {
            return sat;
        }
        public static List<string> callSun()
        {
            return sun;
        }



        //creates new array with shuffled contents of shirts/pants/jackets/accessories array 
        public static void randomize(List<string> item, List<string>day)
        {
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
                day.Add(store[i]);
            }

            //prints the new randomized array into new textbox
            foreach (string strName in store)
            {
                strStore += strName + "\r\n";
            }
        }

        public static void shuffle(List<string> day) {
            randomize(shirts, day);
            randomize(pants, day);
            randomize(jac, day);
            randomize(acc, day);
        }

        public void saveWardrobe(string str, TextBox txt, List<string> list) {
            //saves edits in textbox to shirts array 
            //covers edit, add, and delete functionalities 
            str = txt.Text;
            list.Clear();
            string[] words = txt.Text.Split(new string[] { Environment.NewLine },
                StringSplitOptions.None);

            foreach (var word in words)
            {
                list.Add(word);
            }
        }
        private void txtShirts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPants_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveWardrobe(strShirts, txtShirts, shirts);
            saveWardrobe(strPants, txtPants, pants);
            saveWardrobe(strJac, txtJac, jac);
            saveWardrobe(strAcc, txtAcc, acc);
        }
    }
}
