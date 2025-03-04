namespace BurgerBarnSummer
{
    partial class BurgerBarn
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
            this.rdbPlainBurger = new System.Windows.Forms.RadioButton();
            this.rdbCheeseburger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoBurger = new System.Windows.Forms.RadioButton();
            this.rdbBaconBurger = new System.Windows.Forms.RadioButton();
            this.rdbVeggieBurger = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNoDrink = new System.Windows.Forms.RadioButton();
            this.rdbWater = new System.Windows.Forms.RadioButton();
            this.rdbFruitPunch = new System.Windows.Forms.RadioButton();
            this.rdbCola = new System.Windows.Forms.RadioButton();
            this.rdbTea = new System.Windows.Forms.RadioButton();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbNoSandwich = new System.Windows.Forms.RadioButton();
            this.rdbBLT = new System.Windows.Forms.RadioButton();
            this.rdbItalianSub = new System.Windows.Forms.RadioButton();
            this.rdbChickenSandwich = new System.Windows.Forms.RadioButton();
            this.rdbTurkeyClub = new System.Windows.Forms.RadioButton();
            this.cmb_coupon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPlainBurger
            // 
            this.rdbPlainBurger.AutoSize = true;
            this.rdbPlainBurger.Location = new System.Drawing.Point(33, 52);
            this.rdbPlainBurger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbPlainBurger.Name = "rdbPlainBurger";
            this.rdbPlainBurger.Size = new System.Drawing.Size(164, 33);
            this.rdbPlainBurger.TabIndex = 1;
            this.rdbPlainBurger.Tag = "4.99";
            this.rdbPlainBurger.Text = "Plain Burger";
            this.rdbPlainBurger.UseVisualStyleBackColor = true;
            this.rdbPlainBurger.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbCheeseburger
            // 
            this.rdbCheeseburger.AutoSize = true;
            this.rdbCheeseburger.Location = new System.Drawing.Point(33, 99);
            this.rdbCheeseburger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbCheeseburger.Name = "rdbCheeseburger";
            this.rdbCheeseburger.Size = new System.Drawing.Size(186, 33);
            this.rdbCheeseburger.TabIndex = 2;
            this.rdbCheeseburger.TabStop = true;
            this.rdbCheeseburger.Tag = "5.99";
            this.rdbCheeseburger.Text = "Cheeseburger";
            this.rdbCheeseburger.UseVisualStyleBackColor = true;
            this.rdbCheeseburger.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoBurger);
            this.groupBox1.Controls.Add(this.rdbBaconBurger);
            this.groupBox1.Controls.Add(this.rdbVeggieBurger);
            this.groupBox1.Controls.Add(this.rdbPlainBurger);
            this.groupBox1.Controls.Add(this.rdbCheeseburger);
            this.groupBox1.Location = new System.Drawing.Point(41, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Burgers";
            // 
            // rdbNoBurger
            // 
            this.rdbNoBurger.AutoSize = true;
            this.rdbNoBurger.Checked = true;
            this.rdbNoBurger.Location = new System.Drawing.Point(33, 240);
            this.rdbNoBurger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbNoBurger.Name = "rdbNoBurger";
            this.rdbNoBurger.Size = new System.Drawing.Size(90, 33);
            this.rdbNoBurger.TabIndex = 5;
            this.rdbNoBurger.TabStop = true;
            this.rdbNoBurger.Tag = "0";
            this.rdbNoBurger.Text = "None";
            this.rdbNoBurger.UseVisualStyleBackColor = true;
            this.rdbNoBurger.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbBaconBurger
            // 
            this.rdbBaconBurger.AutoSize = true;
            this.rdbBaconBurger.Location = new System.Drawing.Point(33, 193);
            this.rdbBaconBurger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbBaconBurger.Name = "rdbBaconBurger";
            this.rdbBaconBurger.Size = new System.Drawing.Size(178, 33);
            this.rdbBaconBurger.TabIndex = 4;
            this.rdbBaconBurger.TabStop = true;
            this.rdbBaconBurger.Tag = "7.99";
            this.rdbBaconBurger.Text = "Bacon Burger";
            this.rdbBaconBurger.UseVisualStyleBackColor = true;
            this.rdbBaconBurger.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbVeggieBurger
            // 
            this.rdbVeggieBurger.AutoSize = true;
            this.rdbVeggieBurger.Location = new System.Drawing.Point(33, 146);
            this.rdbVeggieBurger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbVeggieBurger.Name = "rdbVeggieBurger";
            this.rdbVeggieBurger.Size = new System.Drawing.Size(187, 33);
            this.rdbVeggieBurger.TabIndex = 3;
            this.rdbVeggieBurger.TabStop = true;
            this.rdbVeggieBurger.Tag = "6.49";
            this.rdbVeggieBurger.Text = "Veggie Burger";
            this.rdbVeggieBurger.UseVisualStyleBackColor = true;
            this.rdbVeggieBurger.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbNoDrink);
            this.groupBox3.Controls.Add(this.rdbWater);
            this.groupBox3.Controls.Add(this.rdbFruitPunch);
            this.groupBox3.Controls.Add(this.rdbCola);
            this.groupBox3.Controls.Add(this.rdbTea);
            this.groupBox3.Location = new System.Drawing.Point(41, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 291);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drinks";
            // 
            // rdbNoDrink
            // 
            this.rdbNoDrink.AutoSize = true;
            this.rdbNoDrink.Checked = true;
            this.rdbNoDrink.Location = new System.Drawing.Point(33, 226);
            this.rdbNoDrink.Margin = new System.Windows.Forms.Padding(7);
            this.rdbNoDrink.Name = "rdbNoDrink";
            this.rdbNoDrink.Size = new System.Drawing.Size(90, 33);
            this.rdbNoDrink.TabIndex = 15;
            this.rdbNoDrink.TabStop = true;
            this.rdbNoDrink.Tag = "0";
            this.rdbNoDrink.Text = "None";
            this.rdbNoDrink.UseVisualStyleBackColor = true;
            this.rdbNoDrink.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbWater
            // 
            this.rdbWater.AutoSize = true;
            this.rdbWater.Location = new System.Drawing.Point(33, 179);
            this.rdbWater.Margin = new System.Windows.Forms.Padding(7);
            this.rdbWater.Name = "rdbWater";
            this.rdbWater.Size = new System.Drawing.Size(94, 33);
            this.rdbWater.TabIndex = 14;
            this.rdbWater.TabStop = true;
            this.rdbWater.Tag = ".99";
            this.rdbWater.Text = "Water";
            this.rdbWater.UseVisualStyleBackColor = true;
            this.rdbWater.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbFruitPunch
            // 
            this.rdbFruitPunch.AutoSize = true;
            this.rdbFruitPunch.Location = new System.Drawing.Point(33, 132);
            this.rdbFruitPunch.Margin = new System.Windows.Forms.Padding(7);
            this.rdbFruitPunch.Name = "rdbFruitPunch";
            this.rdbFruitPunch.Size = new System.Drawing.Size(152, 33);
            this.rdbFruitPunch.TabIndex = 13;
            this.rdbFruitPunch.TabStop = true;
            this.rdbFruitPunch.Tag = "1.09";
            this.rdbFruitPunch.Text = "Fruit Punch";
            this.rdbFruitPunch.UseVisualStyleBackColor = true;
            this.rdbFruitPunch.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbCola
            // 
            this.rdbCola.AutoSize = true;
            this.rdbCola.Location = new System.Drawing.Point(33, 38);
            this.rdbCola.Margin = new System.Windows.Forms.Padding(7);
            this.rdbCola.Name = "rdbCola";
            this.rdbCola.Size = new System.Drawing.Size(81, 33);
            this.rdbCola.TabIndex = 11;
            this.rdbCola.TabStop = true;
            this.rdbCola.Tag = "1.29";
            this.rdbCola.Text = "Cola";
            this.rdbCola.UseVisualStyleBackColor = true;
            this.rdbCola.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbTea
            // 
            this.rdbTea.AutoSize = true;
            this.rdbTea.Location = new System.Drawing.Point(33, 85);
            this.rdbTea.Margin = new System.Windows.Forms.Padding(7);
            this.rdbTea.Name = "rdbTea";
            this.rdbTea.Size = new System.Drawing.Size(74, 33);
            this.rdbTea.TabIndex = 12;
            this.rdbTea.TabStop = true;
            this.rdbTea.Tag = "1.19";
            this.rdbTea.Text = "Tea";
            this.rdbTea.UseVisualStyleBackColor = true;
            this.rdbTea.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 29;
            this.lstOrder.Location = new System.Drawing.Point(642, 37);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(488, 352);
            this.lstOrder.Sorted = true;
            this.lstOrder.TabIndex = 6;
            this.lstOrder.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(809, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(857, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(940, 501);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 29);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(940, 449);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(71, 29);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "$0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(940, 397);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(71, 29);
            this.lblSubtotal.TabIndex = 9;
            this.lblSubtotal.Text = "$0.00";
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(827, 562);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(125, 40);
            this.btnPurchase.TabIndex = 9;
            this.btnPurchase.TabStop = false;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(994, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbNoSandwich);
            this.groupBox4.Controls.Add(this.rdbBLT);
            this.groupBox4.Controls.Add(this.rdbItalianSub);
            this.groupBox4.Controls.Add(this.rdbChickenSandwich);
            this.groupBox4.Controls.Add(this.rdbTurkeyClub);
            this.groupBox4.Location = new System.Drawing.Point(340, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 291);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sandwiches";
            // 
            // rdbNoSandwich
            // 
            this.rdbNoSandwich.AutoSize = true;
            this.rdbNoSandwich.Checked = true;
            this.rdbNoSandwich.Location = new System.Drawing.Point(24, 226);
            this.rdbNoSandwich.Margin = new System.Windows.Forms.Padding(7);
            this.rdbNoSandwich.Name = "rdbNoSandwich";
            this.rdbNoSandwich.Size = new System.Drawing.Size(90, 33);
            this.rdbNoSandwich.TabIndex = 10;
            this.rdbNoSandwich.TabStop = true;
            this.rdbNoSandwich.Tag = "0";
            this.rdbNoSandwich.Text = "None";
            this.rdbNoSandwich.UseVisualStyleBackColor = true;
            this.rdbNoSandwich.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbBLT
            // 
            this.rdbBLT.AutoSize = true;
            this.rdbBLT.Location = new System.Drawing.Point(24, 179);
            this.rdbBLT.Margin = new System.Windows.Forms.Padding(7);
            this.rdbBLT.Name = "rdbBLT";
            this.rdbBLT.Size = new System.Drawing.Size(76, 33);
            this.rdbBLT.TabIndex = 9;
            this.rdbBLT.Tag = "3.49";
            this.rdbBLT.Text = "BLT";
            this.rdbBLT.UseVisualStyleBackColor = true;
            this.rdbBLT.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbItalianSub
            // 
            this.rdbItalianSub.AutoSize = true;
            this.rdbItalianSub.Location = new System.Drawing.Point(24, 132);
            this.rdbItalianSub.Margin = new System.Windows.Forms.Padding(7);
            this.rdbItalianSub.Name = "rdbItalianSub";
            this.rdbItalianSub.Size = new System.Drawing.Size(143, 33);
            this.rdbItalianSub.TabIndex = 8;
            this.rdbItalianSub.Tag = "7.49";
            this.rdbItalianSub.Text = "Italian Sub";
            this.rdbItalianSub.UseVisualStyleBackColor = true;
            this.rdbItalianSub.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbChickenSandwich
            // 
            this.rdbChickenSandwich.AutoSize = true;
            this.rdbChickenSandwich.Location = new System.Drawing.Point(24, 38);
            this.rdbChickenSandwich.Margin = new System.Windows.Forms.Padding(7);
            this.rdbChickenSandwich.Name = "rdbChickenSandwich";
            this.rdbChickenSandwich.Size = new System.Drawing.Size(229, 33);
            this.rdbChickenSandwich.TabIndex = 6;
            this.rdbChickenSandwich.Tag = "3.99";
            this.rdbChickenSandwich.Text = "Chicken Sandwich";
            this.rdbChickenSandwich.UseVisualStyleBackColor = true;
            this.rdbChickenSandwich.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // rdbTurkeyClub
            // 
            this.rdbTurkeyClub.AutoSize = true;
            this.rdbTurkeyClub.Location = new System.Drawing.Point(24, 85);
            this.rdbTurkeyClub.Margin = new System.Windows.Forms.Padding(7);
            this.rdbTurkeyClub.Name = "rdbTurkeyClub";
            this.rdbTurkeyClub.Size = new System.Drawing.Size(161, 33);
            this.rdbTurkeyClub.TabIndex = 7;
            this.rdbTurkeyClub.Tag = "5.49";
            this.rdbTurkeyClub.Text = "Turkey Club";
            this.rdbTurkeyClub.UseVisualStyleBackColor = true;
            this.rdbTurkeyClub.CheckedChanged += new System.EventHandler(this.btn_selectOrder);
            // 
            // cmb_coupon
            // 
            this.cmb_coupon.FormattingEnabled = true;
            this.cmb_coupon.Items.AddRange(new object[] {
            "0%",
            "10%",
            "25%",
            "40%",
            "50%",
            "100%",
            "110%",
            "200%",
            "-10%",
            "-100%"});
            this.cmb_coupon.Location = new System.Drawing.Point(573, 562);
            this.cmb_coupon.Name = "cmb_coupon";
            this.cmb_coupon.Size = new System.Drawing.Size(233, 37);
            this.cmb_coupon.TabIndex = 17;
            this.cmb_coupon.SelectedIndexChanged += new System.EventHandler(this.cmb_coupon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Coupon";
            // 
            // BurgerBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_coupon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "BurgerBarn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BurgerBarn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPlainBurger;
        private System.Windows.Forms.RadioButton rdbCheeseburger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoBurger;
        private System.Windows.Forms.RadioButton rdbBaconBurger;
        private System.Windows.Forms.RadioButton rdbVeggieBurger;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNoDrink;
        private System.Windows.Forms.RadioButton rdbWater;
        private System.Windows.Forms.RadioButton rdbFruitPunch;
        private System.Windows.Forms.RadioButton rdbCola;
        private System.Windows.Forms.RadioButton rdbTea;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbBLT;
        private System.Windows.Forms.RadioButton rdbItalianSub;
        private System.Windows.Forms.RadioButton rdbChickenSandwich;
        private System.Windows.Forms.RadioButton rdbTurkeyClub;
        private System.Windows.Forms.ComboBox cmb_coupon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbNoSandwich;
    }
}

