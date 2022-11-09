namespace Resturan_Otomasyonu
{
    partial class AddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewUser));
            this.FirstName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.button13 = new System.Windows.Forms.Button();
            this.AddNewUserLbl = new System.Windows.Forms.Label();
            this.AddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Password2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LastName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.FirstName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.FirstName.BorderThickness = 3;
            this.FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FirstName.isPassword = false;
            this.FirstName.Location = new System.Drawing.Point(20, 110);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(270, 44);
            this.FirstName.TabIndex = 1;
            this.FirstName.Text = "First Name";
            this.FirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FirstName.OnValueChanged += new System.EventHandler(this.FirstName_OnValueChanged);
            this.FirstName.Enter += new System.EventHandler(this.FirstName_Enter);
            this.FirstName.Leave += new System.EventHandler(this.FirstName_Leave);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(555, 10);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 11;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // AddNewUserLbl
            // 
            this.AddNewUserLbl.AutoSize = true;
            this.AddNewUserLbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewUserLbl.ForeColor = System.Drawing.Color.White;
            this.AddNewUserLbl.Location = new System.Drawing.Point(192, 51);
            this.AddNewUserLbl.Name = "AddNewUserLbl";
            this.AddNewUserLbl.Size = new System.Drawing.Size(215, 36);
            this.AddNewUserLbl.TabIndex = 9;
            this.AddNewUserLbl.Text = "Add New User";
            // 
            // AddUser
            // 
            this.AddUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddUser.BorderRadius = 0;
            this.AddUser.ButtonText = "Add User";
            this.AddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddUser.DisabledColor = System.Drawing.Color.Gray;
            this.AddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.AddUser.Iconimage = null;
            this.AddUser.Iconimage_right = null;
            this.AddUser.Iconimage_right_Selected = null;
            this.AddUser.Iconimage_Selected = null;
            this.AddUser.IconMarginLeft = 0;
            this.AddUser.IconMarginRight = 0;
            this.AddUser.IconRightVisible = false;
            this.AddUser.IconRightZoom = 0D;
            this.AddUser.IconVisible = false;
            this.AddUser.IconZoom = 90D;
            this.AddUser.IsTab = false;
            this.AddUser.Location = new System.Drawing.Point(186, 334);
            this.AddUser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddUser.Name = "AddUser";
            this.AddUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.AddUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.AddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.AddUser.selected = false;
            this.AddUser.Size = new System.Drawing.Size(230, 40);
            this.AddUser.TabIndex = 8;
            this.AddUser.Text = "Add User";
            this.AddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddUser.Textcolor = System.Drawing.Color.White;
            this.AddUser.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Password
            // 
            this.Password.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Password.BorderThickness = 3;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password.isPassword = true;
            this.Password.Location = new System.Drawing.Point(20, 214);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(270, 44);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.Password_OnValueChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Password2
            // 
            this.Password2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Password2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Password2.BorderThickness = 3;
            this.Password2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password2.isPassword = true;
            this.Password2.Location = new System.Drawing.Point(307, 214);
            this.Password2.Margin = new System.Windows.Forms.Padding(4);
            this.Password2.Name = "Password2";
            this.Password2.Size = new System.Drawing.Size(270, 44);
            this.Password2.TabIndex = 6;
            this.Password2.Text = "Password";
            this.Password2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password2.OnValueChanged += new System.EventHandler(this.Password2_OnValueChanged);
            this.Password2.Enter += new System.EventHandler(this.Password2_Enter);
            this.Password2.Leave += new System.EventHandler(this.Password2_Leave);
            // 
            // LastName
            // 
            this.LastName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LastName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LastName.BorderThickness = 3;
            this.LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LastName.isPassword = false;
            this.LastName.Location = new System.Drawing.Point(307, 110);
            this.LastName.Margin = new System.Windows.Forms.Padding(4);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(270, 44);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Last Name";
            this.LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LastName.OnValueChanged += new System.EventHandler(this.LastName_OnValueChanged);
            this.LastName.Enter += new System.EventHandler(this.LastName_Enter);
            this.LastName.Leave += new System.EventHandler(this.LastName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Show Password";
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(20, 265);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(43, 25);
            this.bunifuiOSSwitch1.TabIndex = 0;
            this.bunifuiOSSwitch1.Value = false;
            this.bunifuiOSSwitch1.OnValueChange += new System.EventHandler(this.bunifuiOSSwitch1_OnValueChange);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Gender);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuiOSSwitch1);
            this.panel2.Controls.Add(this.Email);
            this.panel2.Controls.Add(this.UserName);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.FirstName);
            this.panel2.Controls.Add(this.LastName);
            this.panel2.Controls.Add(this.Password2);
            this.panel2.Controls.Add(this.AddNewUserLbl);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.AddUser);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 399);
            this.panel2.TabIndex = 15;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Gender
            // 
            this.Gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.White;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(309, 267);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(266, 29);
            this.Gender.TabIndex = 7;
            this.Gender.Tag = "";
            this.Gender.Text = "Gender";
            // 
            // Email
            // 
            this.Email.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Email.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Email.BorderThickness = 3;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.isPassword = false;
            this.Email.Location = new System.Drawing.Point(307, 162);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(270, 44);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email Aderss";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Email.OnValueChanged += new System.EventHandler(this.Email_OnValueChanged);
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // UserName
            // 
            this.UserName.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.UserName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.UserName.BorderThickness = 3;
            this.UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.isPassword = false;
            this.UserName.Location = new System.Drawing.Point(20, 162);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(270, 44);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "User Name";
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.OnValueChanged += new System.EventHandler(this.UserName_OnValueChanged);
            this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox FirstName;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label AddNewUserLbl;
        private Bunifu.Framework.UI.BunifuFlatButton AddUser;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password2;
        private Bunifu.Framework.UI.BunifuMetroTextbox LastName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox UserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox Email;
        private System.Windows.Forms.ComboBox Gender;
    }
}