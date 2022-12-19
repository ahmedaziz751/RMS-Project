using Resturan_Otomasyonu.MenuItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturan_Otomasyonu.HomeScreenActions
{
    public partial class AddOrder : Form
    {
        String table;
        public AddOrder(string table)
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

        private void Drinks_Click(object sender, EventArgs e)
        {
            Drinks d = new Drinks(this.table);
            d.Show();

        }

        private void Food_Click(object sender, EventArgs e)
        {
            Food food = new Food(this.table);
            food.Show();

        }

        private void Sweets_Click(object sender, EventArgs e)
        {
            Sweets sweets = new Sweets(this.table);
            sweets.Show();

        }
    }
}
