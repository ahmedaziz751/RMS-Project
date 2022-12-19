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
    public partial class TablesAndOrders : Form
    {
        public TablesAndOrders()
        {
            InitializeComponent();
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
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            /*********************************** Control **************************************/

            PictureBox pictureBox = (PictureBox)sender;   

            /*********************************** Control **************************************/

            TableBills tb = new TableBills(pictureBox.Name);
            tb.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen hs = new HomeScreen();
            hs.Show();
        }
    }
}
