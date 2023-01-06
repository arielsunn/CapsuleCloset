using System;
using System.Collections;
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
    public partial class frmWardrobe : Form
    {
        DataTable shirts;
        DataTable pants;
        DataTable jac;
        DataTable acc;

        string strShirts = string.Empty;
        string strPants = string.Empty;
        string strJac = string.Empty;
        string strAcc = string.Empty;

        public frmWardrobe()
        {
            InitializeComponent();
        }

        public frmWardrobe(DataTable s, DataTable p, DataTable j, DataTable a)
        {
            InitializeComponent();
            shirts = s;
            pants = p;
            jac = j;
            acc = a;
        }

        private void frmWardrobe_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.SetControls();
        }

        private void SetControls()
        {
            this.dgShirts.DataSource = shirts;
            this.dgPants.DataSource = pants;
            this.dgJackets.DataSource = jac;
            this.dgAccessories.DataSource = acc;
        }


        public void saveWardrobe(DataTable table, DataGridView dg) 
        {
            for (int i = table.Rows.Count; i < 7; i++)
            {
                DataRow row = new DataRow("no more items");
                table.Rows.Add(row);
            }
            /*while (table.Rows.Count < 7) {

                table.NewRow();
                table.Rows.Add("No more items");
            }*/
            table.AcceptChanges();

            dg.DataSource = table;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            saveWardrobe(shirts, dgShirts);
            saveWardrobe(pants, dgPants);
            saveWardrobe(jac, dgJackets);
            saveWardrobe(acc, dgAccessories);
            //Close current form
            this.Close();
            //Create a thread to RUN a NEW application with the desired form
            Thread t = new Thread(new ThreadStart(OpenHomePage));
            t.Start();
        }

        private void OpenHomePage()
        {
            //RUNs a NEW application with the desired form
            //Application.Run(new frmHome(shirts));
            Application.Run(new frmHome(shirts, pants, jac, acc));
        }
    }
}


/*
public static List<string> mon { get; set; }
public static List<string> tues { get; set; }
public static List<string> wed { get; set; }
public static List<string> thurs { get; set; }
public static List<string> fri { get; set; }
public static List<string> sat { get; set; }
public static List<string> sun { get; set; }

public static List<string> callShirts()
{
    return shirts;
}
public static List<string> callPants()
{
    return pants;
}
public static List<string> callJac()
{
    return jac;
}
public static List<string> callAcc()
{
    return acc;
}
*/

//initial 7 shirts
/*for (int i = 0; i < 7; i++)
{
    shirts.Add("Shirt" + i);
    //shirts[i] = "Shirt " + i;
}

//Iterating through items - Using foreach loop, then print within respective textbox
foreach (string strName in shirts)
{
    strShirts += strName + "\r\n";
}*/

/*
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
*/

//creates new array with shuffled contents of shirts/pants/jackets/accessories array 
/*
public static void randomize(List<string> item)
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
*/

