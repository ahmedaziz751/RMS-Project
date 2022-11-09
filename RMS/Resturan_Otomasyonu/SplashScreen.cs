using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturan_Otomasyonu
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProgressBar1.Value += 2;
            if(ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                HomeScreen frm = new HomeScreen();
                frm.Show();
                this.Hide();
            }
        }
    }
}
