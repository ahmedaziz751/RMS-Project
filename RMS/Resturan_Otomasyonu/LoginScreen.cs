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

namespace Resturan_Otomasyonu
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            
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


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SplashScreen spscr = new SplashScreen();
            spscr.Show();
            this.Hide();
        }
        

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Password_OnValueChanged(object sender, EventArgs e)
        {
                Password.ForeColor = Color.White;
        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "User Name")
            {
                UserName.Text = "";
                
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                UserName.Text = "User Name";
                UserName.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void UserName_OnValueChanged(object sender, EventArgs e)
        {
                UserName.ForeColor = Color.White;
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
