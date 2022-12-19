namespace Resturan_Otomasyonu.HomeScreenActions
{
    partial class RemoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUser));
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.Back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.KullaniciSilBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(391, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 7;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remove User";
            // 
            // UserDropdown
            // 
            this.UserDropdown.BackColor = System.Drawing.Color.Transparent;
            this.UserDropdown.BorderRadius = 3;
            this.UserDropdown.ForeColor = System.Drawing.Color.White;
            this.UserDropdown.Items = new string[0];
            this.UserDropdown.Location = new System.Drawing.Point(146, 105);
            this.UserDropdown.Name = "UserDropdown";
            this.UserDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.UserDropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.UserDropdown.selectedIndex = -1;
            this.UserDropdown.Size = new System.Drawing.Size(270, 29);
            this.UserDropdown.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pick a user";
            // 
            // Back
            // 
            this.Back.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Back.BorderRadius = 0;
            this.Back.ButtonText = "Back to Home Screen";
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.DisabledColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Iconcolor = System.Drawing.Color.Transparent;
            this.Back.Iconimage = null;
            this.Back.Iconimage_right = null;
            this.Back.Iconimage_right_Selected = null;
            this.Back.Iconimage_Selected = null;
            this.Back.IconMarginLeft = 0;
            this.Back.IconMarginRight = 0;
            this.Back.IconRightVisible = false;
            this.Back.IconRightZoom = 0D;
            this.Back.IconVisible = false;
            this.Back.IconZoom = 90D;
            this.Back.IsTab = false;
            this.Back.Location = new System.Drawing.Point(24, 166);
            this.Back.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Back.Name = "Back";
            this.Back.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Back.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.Back.OnHoverTextColor = System.Drawing.Color.White;
            this.Back.selected = false;
            this.Back.Size = new System.Drawing.Size(191, 58);
            this.Back.TabIndex = 10;
            this.Back.Text = "Back to Home Screen";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Textcolor = System.Drawing.Color.White;
            this.Back.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // KullaniciSilBtn
            // 
            this.KullaniciSilBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.KullaniciSilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.KullaniciSilBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KullaniciSilBtn.BorderRadius = 0;
            this.KullaniciSilBtn.ButtonText = "Remove User";
            this.KullaniciSilBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KullaniciSilBtn.DisabledColor = System.Drawing.Color.Gray;
            this.KullaniciSilBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciSilBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.KullaniciSilBtn.Iconimage = null;
            this.KullaniciSilBtn.Iconimage_right = null;
            this.KullaniciSilBtn.Iconimage_right_Selected = null;
            this.KullaniciSilBtn.Iconimage_Selected = null;
            this.KullaniciSilBtn.IconMarginLeft = 0;
            this.KullaniciSilBtn.IconMarginRight = 0;
            this.KullaniciSilBtn.IconRightVisible = false;
            this.KullaniciSilBtn.IconRightZoom = 0D;
            this.KullaniciSilBtn.IconVisible = false;
            this.KullaniciSilBtn.IconZoom = 90D;
            this.KullaniciSilBtn.IsTab = false;
            this.KullaniciSilBtn.Location = new System.Drawing.Point(225, 166);
            this.KullaniciSilBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.KullaniciSilBtn.Name = "KullaniciSilBtn";
            this.KullaniciSilBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.KullaniciSilBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.KullaniciSilBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.KullaniciSilBtn.selected = false;
            this.KullaniciSilBtn.Size = new System.Drawing.Size(191, 58);
            this.KullaniciSilBtn.TabIndex = 10;
            this.KullaniciSilBtn.Text = "Remove User";
            this.KullaniciSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KullaniciSilBtn.Textcolor = System.Drawing.Color.White;
            this.KullaniciSilBtn.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciSilBtn.Click += new System.EventHandler(this.KullaniciSilBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 262);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(444, 259);
            this.Controls.Add(this.KullaniciSilBtn);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.UserDropdown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown UserDropdown;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton Back;
        private Bunifu.Framework.UI.BunifuFlatButton KullaniciSilBtn;
        private System.Windows.Forms.Panel panel1;
    }
}