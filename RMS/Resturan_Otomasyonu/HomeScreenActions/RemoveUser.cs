using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resturan_Otomasyonu.HomeScreenActions
{
    public partial class RemoveUser : Form
    {
        public RemoveUser()
        {
            InitializeComponent();

            /*********************************** Control **************************************/

            SQLiteConnection con = new SQLiteConnection("Data source=.\\main.db;version=3");
            DataTable dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter("SELECT user_name FROM admin ORDER BY id;", con);
            adtr.Fill(dt);
            con.Close();

            String[] Users = new String[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Users[i] = dt.Rows[i][0].ToString();
            }
            UserDropdown.Items = Users;

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

        private void Back_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            hs.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeScreen hs = new HomeScreen();
            hs.Show();
        }

        /*********************************** Control **************************************/
        private void KullaniciSilBtn_Click(object sender, EventArgs e)
        {
            if (UserDropdown.selectedIndex >= 0)
            {
                String toDelete = UserDropdown.selectedValue.ToString();
                SQLiteConnection con = new SQLiteConnection("Data source=.\\main.db;version=3");
                con.Open();
                SQLiteCommand cmnd = new SQLiteCommand();
                cmnd = con.CreateCommand();
                cmnd.CommandText = "DELETE FROM admin WHERE user_name = '" + toDelete + "';";
                cmnd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter adtr = new SQLiteDataAdapter("SELECT user_name FROM admin ;", con);
                adtr.Fill(dt);
                con.Close();

                String[] Users = new String[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Users[i] = dt.Rows[i][0].ToString();
                }
                UserDropdown.Items = Users;
                UserDropdown.selectedIndex = 0;
                MessageBox.Show("User \" " + toDelete + " \" was Deleted successfully", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*********************************** Control **************************************/
    }
}
