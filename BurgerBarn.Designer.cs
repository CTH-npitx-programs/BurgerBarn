namespace BurgerBarn
{
    partial class frmBurgerBarn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBurgerBarn));
            this.gbxBurgers = new System.Windows.Forms.GroupBox();
            this.rdb_noBurg = new System.Windows.Forms.RadioButton();
            this.rdb_baconBurg = new System.Windows.Forms.RadioButton();
            this.rdb_vegBurg = new System.Windows.Forms.RadioButton();
            this.rdb_cheeBurg = new System.Windows.Forms.RadioButton();
            this.rdb_plainBurg = new System.Windows.Forms.RadioButton();
            this.gbxDrinks = new System.Windows.Forms.GroupBox();
            this.rdb_noDrink = new System.Windows.Forms.RadioButton();
            this.rdb_drinkWater = new System.Windows.Forms.RadioButton();
            this.rdb_drinkPunch = new System.Windows.Forms.RadioButton();
            this.rdb_drinkCoala = new System.Windows.Forms.RadioButton();
            this.rdb_drinkTea = new System.Windows.Forms.RadioButton();
            this.gbxSides = new System.Windows.Forms.GroupBox();
            this.rdb_noSide = new System.Windows.Forms.RadioButton();
            this.rdb_sideChip = new System.Windows.Forms.RadioButton();
            this.rdb_sideOnioRing = new System.Windows.Forms.RadioButton();
            this.rdb_sideTatTot = new System.Windows.Forms.RadioButton();
            this.rdb_sidesFries = new System.Windows.Forms.RadioButton();
            this.lst_order = new System.Windows.Forms.ListBox();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.bttn_purchase = new System.Windows.Forms.Button();
            this.bttn_close = new System.Windows.Forms.Button();
            this.gbxBurgers.SuspendLayout();
            this.gbxDrinks.SuspendLayout();
            this.gbxSides.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBurgers
            // 
            this.gbxBurgers.Controls.Add(this.rdb_noBurg);
            this.gbxBurgers.Controls.Add(this.rdb_baconBurg);
            this.gbxBurgers.Controls.Add(this.rdb_vegBurg);
            this.gbxBurgers.Controls.Add(this.rdb_cheeBurg);
            this.gbxBurgers.Controls.Add(this.rdb_plainBurg);
            this.gbxBurgers.Location = new System.Drawing.Point(12, 171);
            this.gbxBurgers.Name = "gbxBurgers";
            this.gbxBurgers.Size = new System.Drawing.Size(200, 134);
            this.gbxBurgers.TabIndex = 0;
            this.gbxBurgers.TabStop = false;
            this.gbxBurgers.Text = "Burgers";
            // 
            // rdb_noBurg
            // 
            this.rdb_noBurg.AutoSize = true;
            this.rdb_noBurg.Checked = true;
            this.rdb_noBurg.Location = new System.Drawing.Point(7, 107);
            this.rdb_noBurg.Name = "rdb_noBurg";
            this.rdb_noBurg.Size = new System.Drawing.Size(51, 17);
            this.rdb_noBurg.TabIndex = 5;
            this.rdb_noBurg.TabStop = true;
            this.rdb_noBurg.Tag = "0";
            this.rdb_noBurg.Text = "None";
            this.rdb_noBurg.UseVisualStyleBackColor = true;
            this.rdb_noBurg.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_baconBurg
            // 
            this.rdb_baconBurg.AutoSize = true;
            this.rdb_baconBurg.Location = new System.Drawing.Point(6, 85);
            this.rdb_baconBurg.Name = "rdb_baconBurg";
            this.rdb_baconBurg.Size = new System.Drawing.Size(123, 17);
            this.rdb_baconBurg.TabIndex = 4;
            this.rdb_baconBurg.Tag = "7.49";
            this.rdb_baconBurg.Text = "Bacon Burger: $7.49";
            this.rdb_baconBurg.UseVisualStyleBackColor = true;
            this.rdb_baconBurg.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_vegBurg
            // 
            this.rdb_vegBurg.AutoSize = true;
            this.rdb_vegBurg.Location = new System.Drawing.Point(6, 63);
            this.rdb_vegBurg.Name = "rdb_vegBurg";
            this.rdb_vegBurg.Size = new System.Drawing.Size(119, 17);
            this.rdb_vegBurg.TabIndex = 3;
            this.rdb_vegBurg.Tag = "6.49";
            this.rdb_vegBurg.Text = "Vegie Burger: $6.49";
            this.rdb_vegBurg.UseVisualStyleBackColor = true;
            this.rdb_vegBurg.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_cheeBurg
            // 
            this.rdb_cheeBurg.AutoSize = true;
            this.rdb_cheeBurg.Location = new System.Drawing.Point(6, 41);
            this.rdb_cheeBurg.Name = "rdb_cheeBurg";
            this.rdb_cheeBurg.Size = new System.Drawing.Size(124, 17);
            this.rdb_cheeBurg.TabIndex = 2;
            this.rdb_cheeBurg.Tag = "5.99";
            this.rdb_cheeBurg.Text = "Cheeseburger: $5.99";
            this.rdb_cheeBurg.UseVisualStyleBackColor = true;
            this.rdb_cheeBurg.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_plainBurg
            // 
            this.rdb_plainBurg.AutoSize = true;
            this.rdb_plainBurg.Location = new System.Drawing.Point(6, 19);
            this.rdb_plainBurg.Name = "rdb_plainBurg";
            this.rdb_plainBurg.Size = new System.Drawing.Size(115, 17);
            this.rdb_plainBurg.TabIndex = 1;
            this.rdb_plainBurg.Tag = "4.99";
            this.rdb_plainBurg.Text = "Plain Burger: $4.99";
            this.rdb_plainBurg.UseVisualStyleBackColor = true;
            this.rdb_plainBurg.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // gbxDrinks
            // 
            this.gbxDrinks.Controls.Add(this.rdb_noDrink);
            this.gbxDrinks.Controls.Add(this.rdb_drinkWater);
            this.gbxDrinks.Controls.Add(this.rdb_drinkPunch);
            this.gbxDrinks.Controls.Add(this.rdb_drinkCoala);
            this.gbxDrinks.Controls.Add(this.rdb_drinkTea);
            this.gbxDrinks.Location = new System.Drawing.Point(252, 317);
            this.gbxDrinks.Name = "gbxDrinks";
            this.gbxDrinks.Size = new System.Drawing.Size(200, 127);
            this.gbxDrinks.TabIndex = 1;
            this.gbxDrinks.TabStop = false;
            this.gbxDrinks.Text = "Drinks";
            // 
            // rdb_noDrink
            // 
            this.rdb_noDrink.AutoSize = true;
            this.rdb_noDrink.Checked = true;
            this.rdb_noDrink.Location = new System.Drawing.Point(6, 103);
            this.rdb_noDrink.Name = "rdb_noDrink";
            this.rdb_noDrink.Size = new System.Drawing.Size(51, 17);
            this.rdb_noDrink.TabIndex = 15;
            this.rdb_noDrink.TabStop = true;
            this.rdb_noDrink.Tag = "0";
            this.rdb_noDrink.Text = "None";
            this.rdb_noDrink.UseVisualStyleBackColor = true;
            this.rdb_noDrink.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_drinkWater
            // 
            this.rdb_drinkWater.AutoSize = true;
            this.rdb_drinkWater.Location = new System.Drawing.Point(6, 82);
            this.rdb_drinkWater.Name = "rdb_drinkWater";
            this.rdb_drinkWater.Size = new System.Drawing.Size(87, 17);
            this.rdb_drinkWater.TabIndex = 14;
            this.rdb_drinkWater.Tag = "0.99";
            this.rdb_drinkWater.Text = "Water: $0.99";
            this.rdb_drinkWater.UseVisualStyleBackColor = true;
            this.rdb_drinkWater.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_drinkPunch
            // 
            this.rdb_drinkPunch.AutoSize = true;
            this.rdb_drinkPunch.Location = new System.Drawing.Point(6, 61);
            this.rdb_drinkPunch.Name = "rdb_drinkPunch";
            this.rdb_drinkPunch.Size = new System.Drawing.Size(112, 17);
            this.rdb_drinkPunch.TabIndex = 13;
            this.rdb_drinkPunch.Tag = "1.09";
            this.rdb_drinkPunch.Text = "Fruit Punch: $1.09";
            this.rdb_drinkPunch.UseVisualStyleBackColor = true;
            this.rdb_drinkPunch.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_drinkCoala
            // 
            this.rdb_drinkCoala.AutoSize = true;
            this.rdb_drinkCoala.Location = new System.Drawing.Point(6, 19);
            this.rdb_drinkCoala.Name = "rdb_drinkCoala";
            this.rdb_drinkCoala.Size = new System.Drawing.Size(85, 17);
            this.rdb_drinkCoala.TabIndex = 11;
            this.rdb_drinkCoala.Tag = "1.29";
            this.rdb_drinkCoala.Text = "Coala: $1.29";
            this.rdb_drinkCoala.UseVisualStyleBackColor = true;
            this.rdb_drinkCoala.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_drinkTea
            // 
            this.rdb_drinkTea.AutoSize = true;
            this.rdb_drinkTea.Location = new System.Drawing.Point(6, 40);
            this.rdb_drinkTea.Name = "rdb_drinkTea";
            this.rdb_drinkTea.Size = new System.Drawing.Size(77, 17);
            this.rdb_drinkTea.TabIndex = 12;
            this.rdb_drinkTea.Tag = "1.99";
            this.rdb_drinkTea.Text = "Tea: $1.99";
            this.rdb_drinkTea.UseVisualStyleBackColor = true;
            this.rdb_drinkTea.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // gbxSides
            // 
            this.gbxSides.Controls.Add(this.rdb_noSide);
            this.gbxSides.Controls.Add(this.rdb_sideChip);
            this.gbxSides.Controls.Add(this.rdb_sideOnioRing);
            this.gbxSides.Controls.Add(this.rdb_sideTatTot);
            this.gbxSides.Controls.Add(this.rdb_sidesFries);
            this.gbxSides.Location = new System.Drawing.Point(12, 311);
            this.gbxSides.Name = "gbxSides";
            this.gbxSides.Size = new System.Drawing.Size(200, 134);
            this.gbxSides.TabIndex = 2;
            this.gbxSides.TabStop = false;
            this.gbxSides.Text = "Sides";
            // 
            // rdb_noSide
            // 
            this.rdb_noSide.AutoSize = true;
            this.rdb_noSide.Checked = true;
            this.rdb_noSide.Location = new System.Drawing.Point(7, 116);
            this.rdb_noSide.Name = "rdb_noSide";
            this.rdb_noSide.Size = new System.Drawing.Size(51, 17);
            this.rdb_noSide.TabIndex = 10;
            this.rdb_noSide.TabStop = true;
            this.rdb_noSide.Tag = "0";
            this.rdb_noSide.Text = "None";
            this.rdb_noSide.UseVisualStyleBackColor = true;
            this.rdb_noSide.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_sideChip
            // 
            this.rdb_sideChip.AutoSize = true;
            this.rdb_sideChip.Location = new System.Drawing.Point(6, 92);
            this.rdb_sideChip.Name = "rdb_sideChip";
            this.rdb_sideChip.Size = new System.Drawing.Size(84, 17);
            this.rdb_sideChip.TabIndex = 9;
            this.rdb_sideChip.Tag = "0.99";
            this.rdb_sideChip.Text = "Chips: $0.99";
            this.rdb_sideChip.UseVisualStyleBackColor = true;
            this.rdb_sideChip.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_sideOnioRing
            // 
            this.rdb_sideOnioRing.AutoSize = true;
            this.rdb_sideOnioRing.Location = new System.Drawing.Point(6, 68);
            this.rdb_sideOnioRing.Name = "rdb_sideOnioRing";
            this.rdb_sideOnioRing.Size = new System.Drawing.Size(116, 17);
            this.rdb_sideOnioRing.TabIndex = 8;
            this.rdb_sideOnioRing.Tag = "0.99";
            this.rdb_sideOnioRing.Text = "Onion Rings: $0.99";
            this.rdb_sideOnioRing.UseVisualStyleBackColor = true;
            this.rdb_sideOnioRing.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_sideTatTot
            // 
            this.rdb_sideTatTot.AutoSize = true;
            this.rdb_sideTatTot.Location = new System.Drawing.Point(6, 44);
            this.rdb_sideTatTot.Name = "rdb_sideTatTot";
            this.rdb_sideTatTot.Size = new System.Drawing.Size(107, 17);
            this.rdb_sideTatTot.TabIndex = 7;
            this.rdb_sideTatTot.Tag = "0.75";
            this.rdb_sideTatTot.Text = "Tater Tots: $0.75";
            this.rdb_sideTatTot.UseVisualStyleBackColor = true;
            this.rdb_sideTatTot.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // rdb_sidesFries
            // 
            this.rdb_sidesFries.AutoSize = true;
            this.rdb_sidesFries.Location = new System.Drawing.Point(7, 20);
            this.rdb_sidesFries.Name = "rdb_sidesFries";
            this.rdb_sidesFries.Size = new System.Drawing.Size(80, 17);
            this.rdb_sidesFries.TabIndex = 6;
            this.rdb_sidesFries.Tag = "0.50";
            this.rdb_sidesFries.Text = "Fries: $0.50";
            this.rdb_sidesFries.UseVisualStyleBackColor = true;
            this.rdb_sidesFries.CheckedChanged += new System.EventHandler(this.rdb_Selection);
            // 
            // lst_order
            // 
            this.lst_order.FormattingEnabled = true;
            this.lst_order.Location = new System.Drawing.Point(664, 13);
            this.lst_order.Name = "lst_order";
            this.lst_order.Size = new System.Drawing.Size(120, 95);
            this.lst_order.Sorted = true;
            this.lst_order.TabIndex = 0;
            this.lst_order.TabStop = false;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(476, 96);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(79, 13);
            this.lbl_subtotal.TabIndex = 0;
            this.lbl_subtotal.Text = "Subtotal: $0.00";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(476, 118);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(58, 13);
            this.lbl_tax.TabIndex = 0;
            this.lbl_tax.Text = "Tax: $0.00";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(476, 142);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(64, 13);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total: $0.00";
            // 
            // bttn_purchase
            // 
            this.bttn_purchase.Location = new System.Drawing.Point(479, 331);
            this.bttn_purchase.Name = "bttn_purchase";
            this.bttn_purchase.Size = new System.Drawing.Size(112, 46);
            this.bttn_purchase.TabIndex = 3;
            this.bttn_purchase.Text = "Purchase";
            this.bttn_purchase.UseVisualStyleBackColor = true;
            this.bttn_purchase.Click += new System.EventHandler(this.bttn_purchase_Click);
            // 
            // bttn_close
            // 
            this.bttn_close.Location = new System.Drawing.Point(622, 331);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(110, 46);
            this.bttn_close.TabIndex = 4;
            this.bttn_close.Text = "Exit";
            this.bttn_close.UseVisualStyleBackColor = true;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // frmBurgerBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_close);
            this.Controls.Add(this.bttn_purchase);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.lst_order);
            this.Controls.Add(this.gbxSides);
            this.Controls.Add(this.gbxDrinks);
            this.Controls.Add(this.gbxBurgers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBurgerBarn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burger Barn";
            this.gbxBurgers.ResumeLayout(false);
            this.gbxBurgers.PerformLayout();
            this.gbxDrinks.ResumeLayout(false);
            this.gbxDrinks.PerformLayout();
            this.gbxSides.ResumeLayout(false);
            this.gbxSides.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBurgers;
        private System.Windows.Forms.GroupBox gbxDrinks;
        private System.Windows.Forms.GroupBox gbxSides;
        private System.Windows.Forms.RadioButton rdb_baconBurg;
        private System.Windows.Forms.RadioButton rdb_vegBurg;
        private System.Windows.Forms.RadioButton rdb_cheeBurg;
        private System.Windows.Forms.RadioButton rdb_plainBurg;
        private System.Windows.Forms.RadioButton rdb_drinkWater;
        private System.Windows.Forms.RadioButton rdb_drinkPunch;
        private System.Windows.Forms.RadioButton rdb_drinkCoala;
        private System.Windows.Forms.RadioButton rdb_drinkTea;
        private System.Windows.Forms.RadioButton rdb_sideChip;
        private System.Windows.Forms.RadioButton rdb_sideOnioRing;
        private System.Windows.Forms.RadioButton rdb_sideTatTot;
        private System.Windows.Forms.RadioButton rdb_sidesFries;
        private System.Windows.Forms.RadioButton rdb_noBurg;
        private System.Windows.Forms.RadioButton rdb_noSide;
        private System.Windows.Forms.RadioButton rdb_noDrink;
        private System.Windows.Forms.ListBox lst_order;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button bttn_purchase;
        private System.Windows.Forms.Button bttn_close;
    }
}

