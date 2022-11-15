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

        ArrayList shirt = new ArrayList();
        string strShirts = string.Empty;

        private void frmWardrobe_Load(object sender, EventArgs e)
        {
            //initial 7 shirts
            for (int i = 0; i < 7; i++)
            {
                shirt.Add(i);
                shirt[i] = "Shirt " + i;
            }

            //Iterating through items - Using foreach loop, then print within respective textbox
            foreach (string strName in shirt)
            {
                strShirts += strName + "\r\n";
            }

            txtShirts.Text = strShirts;
            Console.WriteLine(strShirts);
        }

        //creates new array with shuffled contents of shirts/pants/jackets/accessories array 
        public void shuffle(ArrayList array)
        {

            //stops program from editing array original values
            ArrayList dup = new ArrayList(array); ;
            int length = array.Count;
            ArrayList store = new ArrayList(length - 1);
            Random rand = new Random();
            string strStore = string.Empty;

            //takes random element from dup (copy of array) and adds to new array for randomization
            for (int i = 0; i < length; i++)
            {
                int r = rand.Next(0, dup.Count - 1);
                store.Add(dup[r]);
                dup.RemoveAt(r);
            }

            //prints the new randomized array into new textbox
            foreach (string strName in store)
            {
                strStore += strName + "\r\n";
            }

           // textBox2.Text = strStore;
           // Console.WriteLine(strStore);
        }

        private void txtShirts_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShirts_Click(object sender, EventArgs e)
        {
            //saves edits in textbox to shirts array 
            //covers edit, add, and delete functionalities 
            strShirts = txtShirts.Text;
            shirt.Clear();
            string[] words = txtShirts.Text.Split(new string[] { Environment.NewLine },
                StringSplitOptions.None);

            foreach (var word in words)
            {
                shirt.Add(word);
            }

        }
    }
}
