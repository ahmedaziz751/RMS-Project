namespace Resturan_Otomasyonu
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.UserName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.UserName.Location = new System.Drawing.Point(46, 130);
            this.UserName.Margin = new System.Windows.Forms.Padding(4);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(230, 44);
            this.UserName.TabIndex = 1;
            this.UserName.Text = "User Name";
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserName.OnValueChanged += new System.EventHandler(this.UserName_OnValueChanged);
            this.UserName.Enter += new System.EventHandler(this.UserName_Enter);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
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
            this.Password.Location = new System.Drawing.Point(46, 182);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(230, 44);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Password.OnValueChanged += new System.EventHandler(this.Password_OnValueChanged);
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.White;
            this.LoginLbl.Location = new System.Drawing.Point(119, 75);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(92, 36);
            this.LoginLbl.TabIndex = 3;
            this.LoginLbl.Text = "Login";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LoginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginBtn.BorderRadius = 0;
            this.LoginBtn.ButtonText = "Login";
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.DisabledColor = System.Drawing.Color.Gray;
            this.LoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.LoginBtn.Iconimage = null;
            this.LoginBtn.Iconimage_right = null;
            this.LoginBtn.Iconimage_right_Selected = null;
            this.LoginBtn.Iconimage_Selected = null;
            this.LoginBtn.IconMarginLeft = 0;
            this.LoginBtn.IconMarginRight = 0;
            this.LoginBtn.IconRightVisible = false;
            this.LoginBtn.IconRightZoom = 0D;
            this.LoginBtn.IconVisible = false;
            this.LoginBtn.IconZoom = 90D;
            this.LoginBtn.IsTab = false;
            this.LoginBtn.Location = new System.Drawing.Point(46, 235);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LoginBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.LoginBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.LoginBtn.selected = false;
            this.LoginBtn.Size = new System.Drawing.Size(230, 40);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBtn.Textcolor = System.Drawing.Color.White;
            this.LoginBtn.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button13);
            this.panel2.Controls.Add(this.LoginLbl);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 365);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(297, 10);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 6;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(341, 370);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox UserName;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password;
        private System.Windows.Forms.Label LoginLbl;
        private Bunifu.Framework.UI.BunifuFlatButton LoginBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button13;
    }
}