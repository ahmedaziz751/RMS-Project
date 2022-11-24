namespace Resturan_Otomasyonu
{
    partial class HomeScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Minimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.TablesAndOrders = new Bunifu.Framework.UI.BunifuTileButton();
            this.AddNewUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.Menu = new Bunifu.Framework.UI.BunifuTileButton();
            this.RemoveUser = new Bunifu.Framework.UI.BunifuTileButton();
            this.StaffList = new Bunifu.Framework.UI.BunifuTileButton();
            this.ExirBtn = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.Minimize);
            this.panel2.Controls.Add(this.TablesAndOrders);
            this.panel2.Controls.Add(this.AddNewUser);
            this.panel2.Controls.Add(this.Menu);
            this.panel2.Controls.Add(this.RemoveUser);
            this.panel2.Controls.Add(this.StaffList);
            this.panel2.Controls.Add(this.ExirBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 576);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageActive = null;
            this.Minimize.Location = new System.Drawing.Point(955, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 18);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 5;
            this.Minimize.TabStop = false;
            this.Minimize.Zoom = 10;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // TablesAndOrders
            // 
            this.TablesAndOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TablesAndOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TablesAndOrders.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.TablesAndOrders.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.TablesAndOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablesAndOrders.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.TablesAndOrders.ForeColor = System.Drawing.Color.White;
            this.TablesAndOrders.Image = ((System.Drawing.Image)(resources.GetObject("TablesAndOrders.Image")));
            this.TablesAndOrders.ImagePosition = 50;
            this.TablesAndOrders.ImageZoom = 40;
            this.TablesAndOrders.LabelPosition = 60;
            this.TablesAndOrders.LabelText = "Tables and Orders";
            this.TablesAndOrders.Location = new System.Drawing.Point(30, 32);
            this.TablesAndOrders.Margin = new System.Windows.Forms.Padding(6);
            this.TablesAndOrders.Name = "TablesAndOrders";
            this.TablesAndOrders.Size = new System.Drawing.Size(289, 249);
            this.TablesAndOrders.TabIndex = 4;
            this.TablesAndOrders.Click += new System.EventHandler(this.TablesAndOreders_Click);
            // 
            // AddNewUser
            // 
            this.AddNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddNewUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddNewUser.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.AddNewUser.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.AddNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewUser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.AddNewUser.ForeColor = System.Drawing.Color.White;
            this.AddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("AddNewUser.Image")));
            this.AddNewUser.ImagePosition = 50;
            this.AddNewUser.ImageZoom = 40;
            this.AddNewUser.LabelPosition = 60;
            this.AddNewUser.LabelText = "Add New User";
            this.AddNewUser.Location = new System.Drawing.Point(30, 304);
            this.AddNewUser.Margin = new System.Windows.Forms.Padding(6);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(289, 249);
            this.AddNewUser.TabIndex = 4;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Menu.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.ImagePosition = -30;
            this.Menu.ImageZoom = 100;
            this.Menu.LabelPosition = 60;
            this.Menu.LabelText = "Menu";
            this.Menu.Location = new System.Drawing.Point(347, 32);
            this.Menu.Margin = new System.Windows.Forms.Padding(6);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(289, 249);
            this.Menu.TabIndex = 4;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // RemoveUser
            // 
            this.RemoveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.RemoveUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RemoveUser.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.RemoveUser.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.RemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveUser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.RemoveUser.ForeColor = System.Drawing.Color.White;
            this.RemoveUser.Image = ((System.Drawing.Image)(resources.GetObject("RemoveUser.Image")));
            this.RemoveUser.ImagePosition = 50;
            this.RemoveUser.ImageZoom = 40;
            this.RemoveUser.LabelPosition = 60;
            this.RemoveUser.LabelText = "Remove User";
            this.RemoveUser.Location = new System.Drawing.Point(347, 304);
            this.RemoveUser.Margin = new System.Windows.Forms.Padding(6);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(289, 249);
            this.RemoveUser.TabIndex = 4;
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // StaffList
            // 
            this.StaffList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.StaffList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StaffList.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.StaffList.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.StaffList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffList.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StaffList.ForeColor = System.Drawing.Color.White;
            this.StaffList.Image = ((System.Drawing.Image)(resources.GetObject("StaffList.Image")));
            this.StaffList.ImagePosition = 50;
            this.StaffList.ImageZoom = 45;
            this.StaffList.LabelPosition = 60;
            this.StaffList.LabelText = "Staff List";
            this.StaffList.Location = new System.Drawing.Point(663, 32);
            this.StaffList.Margin = new System.Windows.Forms.Padding(6);
            this.StaffList.Name = "StaffList";
            this.StaffList.Size = new System.Drawing.Size(289, 249);
            this.StaffList.TabIndex = 4;
            this.StaffList.Click += new System.EventHandler(this.StaffList_Click);
            // 
            // ExirBtn
            // 
            this.ExirBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ExirBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExirBtn.color = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ExirBtn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(31)))));
            this.ExirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExirBtn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ExirBtn.ForeColor = System.Drawing.Color.White;
            this.ExirBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExirBtn.Image")));
            this.ExirBtn.ImagePosition = 50;
            this.ExirBtn.ImageZoom = 40;
            this.ExirBtn.LabelPosition = 60;
            this.ExirBtn.LabelText = "Exit";
            this.ExirBtn.Location = new System.Drawing.Point(663, 304);
            this.ExirBtn.Margin = new System.Windows.Forms.Padding(6);
            this.ExirBtn.Name = "ExirBtn";
            this.ExirBtn.Size = new System.Drawing.Size(289, 249);
            this.ExirBtn.TabIndex = 4;
            this.ExirBtn.Click += new System.EventHandler(this.EXitBtn_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 576);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton ExirBtn;
        private Bunifu.Framework.UI.BunifuTileButton TablesAndOrders;
        private Bunifu.Framework.UI.BunifuTileButton AddNewUser;
        private Bunifu.Framework.UI.BunifuTileButton Menu;
        private Bunifu.Framework.UI.BunifuTileButton RemoveUser;
        private Bunifu.Framework.UI.BunifuTileButton StaffList;
        private Bunifu.Framework.UI.BunifuImageButton Minimize;
    }
}

