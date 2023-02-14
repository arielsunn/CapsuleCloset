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
            //Sync DataTables with appropriate DataGridViews 
            this.dgShirts.DataSource = shirts;
            this.dgPants.DataSource = pants;
            this.dgJackets.DataSource = jac;
            this.dgAccessories.DataSource = acc;
        }


        public void saveWardrobe(DataTable table, DataGridView dg) 
        {
            //Ensures at least one item in DataTable for randomization purposes
            if (table.Rows.Count == 0) {
                DataRow row = table.NewRow();
                row[0] = "no items added";
                table.Rows.Add(row);
                dg.Update();
                dg.Refresh();
            }

            //Accepts changes to DataTable, if any
            table.AcceptChanges();

            //Updates the DataGridView to be synced with edited DataTable
            dg.DataSource = table;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //Updates DataTables in case there are no items, and saves any edits
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