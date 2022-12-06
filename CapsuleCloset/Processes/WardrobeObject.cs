using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapsuleCloset.Processes
{
    public static class WardrobeObject
    {
        public static DataTable GetWardrobe(string s)
        {
            string tablename = s + "Data";

            //New DataTable
            DataTable table = new DataTable(tablename);

            //Create Column
            table.Columns.Add(s);

            return table;
        }
    }
}
