namespace Manage_CoffeeShop
{
    partial class TableManageGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_table = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_remote = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_discount = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nmr_quantity = new System.Windows.Forms.NumericUpDown();
            this.btn_addDrink = new System.Windows.Forms.Button();
            this.cb_drink = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpnTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(995, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.profileToolStripMenuItem1});
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.profileToolStripMenuItem.Text = "Account Information";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem1
            // 
            this.profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
            this.profileToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.profileToolStripMenuItem1.Text = "Profile";
            this.profileToolStripMenuItem1.Click += new System.EventHandler(this.profileToolStripMenuItem1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(598, 94);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 326);
            this.panel2.TabIndex = 1;
            // 
            // lsvBill
            // 
            this.lsvBill.Location = new System.Drawing.Point(3, 2);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(378, 321);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_table);
            this.panel3.Controls.Add(this.btn_refresh);
            this.panel3.Controls.Add(this.btn_remote);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.btn_discount);
            this.panel3.Controls.Add(this.btn_checkout);
            this.panel3.Location = new System.Drawing.Point(601, 424);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 60);
            this.panel3.TabIndex = 2;
            // 
            // cb_table
            // 
            this.cb_table.FormattingEnabled = true;
            this.cb_table.Location = new System.Drawing.Point(102, 28);
            this.cb_table.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_table.Name = "cb_table";
            this.cb_table.Size = new System.Drawing.Size(92, 23);
            this.cb_table.TabIndex = 8;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(4, 2);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(92, 46);
            this.btn_refresh.TabIndex = 7;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_remote
            // 
            this.btn_remote.Location = new System.Drawing.Point(102, 2);
            this.btn_remote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_remote.Name = "btn_remote";
            this.btn_remote.Size = new System.Drawing.Size(92, 22);
            this.btn_remote.TabIndex = 6;
            this.btn_remote.Text = "Table";
            this.btn_remote.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(199, 28);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 23);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_discount
            // 
            this.btn_discount.Location = new System.Drawing.Point(199, 2);
            this.btn_discount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_discount.Name = "btn_discount";
            this.btn_discount.Size = new System.Drawing.Size(82, 22);
            this.btn_discount.TabIndex = 5;
            this.btn_discount.Text = "Discount";
            this.btn_discount.UseVisualStyleBackColor = true;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(286, 2);
            this.btn_checkout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(92, 46);
            this.btn_checkout.TabIndex = 4;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmr_quantity);
            this.panel4.Controls.Add(this.btn_addDrink);
            this.panel4.Controls.Add(this.cb_drink);
            this.panel4.Controls.Add(this.cb_category);
            this.panel4.Location = new System.Drawing.Point(598, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(383, 56);
            this.panel4.TabIndex = 3;
            // 
            // nmr_quantity
            // 
            this.nmr_quantity.Location = new System.Drawing.Point(201, 28);
            this.nmr_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmr_quantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmr_quantity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nmr_quantity.Name = "nmr_quantity";
            this.nmr_quantity.Size = new System.Drawing.Size(82, 23);
            this.nmr_quantity.TabIndex = 3;
            // 
            // btn_addDrink
            // 
            this.btn_addDrink.Location = new System.Drawing.Point(289, 2);
            this.btn_addDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addDrink.Name = "btn_addDrink";
            this.btn_addDrink.Size = new System.Drawing.Size(92, 46);
            this.btn_addDrink.TabIndex = 2;
            this.btn_addDrink.Text = "Add Drink";
            this.btn_addDrink.UseVisualStyleBackColor = true;
            // 
            // cb_drink
            // 
            this.cb_drink.FormattingEnabled = true;
            this.cb_drink.Location = new System.Drawing.Point(3, 28);
            this.cb_drink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_drink.Name = "cb_drink";
            this.cb_drink.Size = new System.Drawing.Size(194, 23);
            this.cb_drink.TabIndex = 1;
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(3, 2);
            this.cb_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(281, 23);
            this.cb_category.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpnTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 457);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // flpnTable
            // 
            this.flpnTable.Location = new System.Drawing.Point(6, 22);
            this.flpnTable.Name = "flpnTable";
            this.flpnTable.Size = new System.Drawing.Size(568, 429);
            this.flpnTable.TabIndex = 0;
            // 
            // TableManageGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TableManageGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cofee Shop Management App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_quantity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem profileToolStripMenuItem1;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown nmr_quantity;
        private Button btn_addDrink;
        private ComboBox cb_drink;
        private ComboBox cb_category;
        private ComboBox cb_table;
        private Button btn_refresh;
        private Button btn_remote;
        private NumericUpDown numericUpDown1;
        private Button btn_discount;
        private Button btn_checkout;
        private GroupBox groupBox1;
        private FlowLayoutPanel flpnTable;
    }
}