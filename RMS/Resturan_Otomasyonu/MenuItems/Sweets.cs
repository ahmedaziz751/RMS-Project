using Bunifu.Framework.UI;
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

namespace Resturan_Otomasyonu.MenuItems
{
    public partial class Sweets : Form
    {
        String table;
        public Sweets(string table)
        {
            InitializeComponent();
            this.table = table;
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

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /*********************************** Control **************************************/
        private void Done_Click(object sender, EventArgs e)
        {


            float totalPrice = 0f;

            SQLiteConnection con = new SQLiteConnection("Data source=.\\main.db;version=3");
            DataTable dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("SELECT bill FROM tables WHERE name = '" + table + "';", con);
            adtr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                totalPrice += float.Parse(dt.Rows[0][0].ToString());
            }

            foreach (var dropDown in this.Controls.OfType<BunifuDropdown>())
            {
                if (dropDown.selectedIndex >= 0)
                {

                    dt = new DataTable();
                    adtr = new SQLiteDataAdapter("SELECT price FROM menu WHERE name = '" + dropDown.Name + "';", con);
                    adtr.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        totalPrice += float.Parse(dt.Rows[0][0].ToString()) * float.Parse(dropDown.selectedValue);
                    }
                    else { MessageBox.Show("NO ROW FOR " + dropDown.Name); }


                }

            }
            con.Open();
            SQLiteCommand cmnd = new SQLiteCommand();
            cmnd = con.CreateCommand();
            cmnd.CommandText = "UPDATE tables SET bill = " + totalPrice + " WHERE name = '" + table + "' ;";
            cmnd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(table + "'s Bill is = " + totalPrice, "Bill Has Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /*********************************** Control **************************************/
    }
}
