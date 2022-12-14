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

namespace Resturan_Otomasyonu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            /*********************************** Control **************************************/

            SQLiteConnection con = new SQLiteConnection("Data source=.\\main.db;version=3");
            DataTable dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("SELECT * FROM menu ;", con);
            adtr.Fill(dt);

            DataView dv = new DataView(dt);

            MenuDataGrid.DataSource = dv;
            con.Close();

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

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeScreen hs = new HomeScreen();
            hs.Show();

        }
    }
}
