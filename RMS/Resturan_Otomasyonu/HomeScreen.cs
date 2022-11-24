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
using Resturan_Otomasyonu.HomeScreenActions;

namespace Resturan_Otomasyonu
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
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

        private void EXitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            AddNewUser newUser = new AddNewUser();
            newUser.Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            RemoveUser ru = new RemoveUser();
            ru.Show();
            this.Hide();

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void StaffList_Click(object sender, EventArgs e)
        {
            StaffList sl = new StaffList();
            sl.Show();
            this.Hide();
        }

        private void TablesAndOreders_Click(object sender, EventArgs e)
        {
            TablesAndOrders tbAor = new TablesAndOrders();
            tbAor.Show();
            this.Hide();
        }
    }
}
