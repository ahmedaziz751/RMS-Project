namespace Resturan_Otomasyonu.HomeScreenActions
{
    partial class TableBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableBills));
            this.Order = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Reset = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Order
            // 
            this.Order.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Order.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Order.BorderRadius = 0;
            this.Order.ButtonText = "Order";
            this.Order.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Order.DisabledColor = System.Drawing.Color.Gray;
            this.Order.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Iconcolor = System.Drawing.Color.Transparent;
            this.Order.Iconimage = null;
            this.Order.Iconimage_right = null;
            this.Order.Iconimage_right_Selected = null;
            this.Order.Iconimage_Selected = null;
            this.Order.IconMarginLeft = 0;
            this.Order.IconMarginRight = 0;
            this.Order.IconRightVisible = false;
            this.Order.IconRightZoom = 0D;
            this.Order.IconVisible = false;
            this.Order.IconZoom = 90D;
            this.Order.IsTab = false;
            this.Order.Location = new System.Drawing.Point(59, 211);
            this.Order.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Order.Name = "Order";
            this.Order.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Order.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(22)))));
            this.Order.OnHoverTextColor = System.Drawing.Color.White;
            this.Order.selected = false;
            this.Order.Size = new System.Drawing.Size(283, 55);
            this.Order.TabIndex = 5;
            this.Order.Text = "Order";
            this.Order.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Order.Textcolor = System.Drawing.Color.White;
            this.Order.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Order.Click += new System.EventHandler(this.AddTable_Click);
            // 
            // button13
            // 
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(362, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(32, 35);
            this.button13.TabIndex = 12;
            this.button13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Bill);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 283);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reset.Location = new System.Drawing.Point(135, 36);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(116, 45);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Bill
            // 
            this.Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bill.AutoSize = true;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bill.ForeColor = System.Drawing.Color.White;
            this.Bill.Location = new System.Drawing.Point(144, 107);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(95, 39);
            this.Bill.TabIndex = 1;
            this.Bill.Text = "Erorr";
            // 
            // TableBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(406, 280);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableBills";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton Order;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label Bill;
    }
}