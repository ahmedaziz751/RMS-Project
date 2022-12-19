using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturan_Otomasyonu.HomeScreenActions
{
    public partial class TableBills : Form
    {
        /*********************************** Control **************************************/
        String table;
        /*********************************** Control **************************************/
        public TableBills(String table)
        {
            InitializeComponent();
            /*********************************** Control **************************************/
            this.table = table;

            SQLiteConnection con = new SQLiteConnection("Data source=.\\main.db;version=3");
            DataTable dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("SELECT bill FROM tables WHERE name = '"+this.table+"';", con);
            adtr.Fill(dt);
            con.Close();

            Bill.Text = dt.Rows[0][0].ToString();

            /*********************************** Control **************************************/
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AddTable_Click(object sender, EventArgs e)
        {
            AddOrder ao = new AddOrder(this.table);
            ao.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        /*********************************** Control **************************************/
        private void Reset_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data source=.\\main.db;version=3");
            con.Open();
            SQLiteCommand cmnd = new SQLiteCommand();
            cmnd = con.CreateCommand();
            cmnd.CommandText = "UPDATE tables SET bill = 0 WHERE name = '" + table + "' ;";
            cmnd.ExecuteNonQuery();
            con.Close();
            Bill.Text = "0";
            MessageBox.Show(table + "'s Bill is now 0", "Table Reseted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        /*********************************** Control **************************************/
    }
}
