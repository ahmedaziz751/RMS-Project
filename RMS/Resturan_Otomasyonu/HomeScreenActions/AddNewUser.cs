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
    public partial class AddNewUser : Form
    {
        public AddNewUser()
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


        private void button13_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            hs.Show();
            this.Close();
        }

        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if(bunifuiOSSwitch1.Value == true)
            {
                Password.isPassword = false;
                Password2.isPassword = false;
            }
            else if(bunifuiOSSwitch1.Value == false)
            {
                Password.isPassword = true;
                Password2.isPassword = true;
            }
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

        private void Password2_Enter(object sender, EventArgs e)
        {
            if (Password2.Text == "Password")
            {
                Password2.Text = "";
            }
        }

        private void Password2_Leave(object sender, EventArgs e)
        {
            if (Password2.Text == "")
            {
                Password2.Text = "Password";
                Password2.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Password2_OnValueChanged(object sender, EventArgs e)
        {
            Password2.ForeColor = Color.White;
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

        private void FirstName_Enter(object sender, EventArgs e)
        {
            if (FirstName.Text == "First Name")
            {
                FirstName.Text = "";

            }
        }

        private void FirstName_Leave(object sender, EventArgs e)
        {
            if (FirstName.Text == "")
            {
                FirstName.Text = "First Name";
                FirstName.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void FirstName_OnValueChanged(object sender, EventArgs e)
        {
            FirstName.ForeColor = Color.White;
        }

        private void LastName_Enter(object sender, EventArgs e)
        {
            if (LastName.Text == "Last Name")
            {
                LastName.Text = "";

            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            if (LastName.Text == "")
            {
                LastName.Text = "Last Name";
                LastName.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void LastName_OnValueChanged(object sender, EventArgs e)
        {
            LastName.ForeColor = Color.White;
        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email Aderss")
            {
                Email.Text = "";

            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Email.Text == "")
            {
                Email.Text = "Email Aderss";
                Email.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void Email_OnValueChanged(object sender, EventArgs e)
        {
            Email.ForeColor = Color.White;
        }
    }
}
