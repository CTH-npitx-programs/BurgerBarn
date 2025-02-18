﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BurgerBarn
{
    public partial class Form1 : Form
    {
        float subtotal = 0;
        const float tax_rate = 0.0825f;


        public Form1()
        {
            InitializeComponent();
        }

        private void rdb_selectBurg(object sender, EventArgs e)
        {
            RadioButton burgers = (RadioButton)sender; //radio button is burgers all together
            rdbSelect (burgers); //method call
        }

        private void rdb_selectSide(object sender, EventArgs e)
        {
            RadioButton sides = (RadioButton)sender; //radio button is all sides together
            rdbSelect(sides); //method call
        }

        private void rdb_selectDrink(object sender, EventArgs e)
        {
            RadioButton drinks = (RadioButton)sender; // radio button is drinks all together
            rdbSelect(drinks); //method call
        }

        private void Form1_Load(object sender, EventArgs e)
        {

       
        }
        //Method for Radio Buttons 
        private void rdbSelect(RadioButton rdb)
        {
            if (rdb.Checked) //rdb selected
            {
                if(rdb.Text != "None") // If none is ever selected it doesn't add to receipt
                    lstOrder.Items.Add(rdb.Text); //Adds items to receipt


                subtotal += float.Parse(rdb.Tag.ToString()); //adds price to receipt
            }
            else
            {
                lstOrder.Items.Remove(rdb.Text); //removes Items from order

                subtotal -= float.Parse(rdb.Tag.ToString()); // removes price from receipt
            }
            //calculate totals
            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            //display totals
            lblSubtoal.Text = subtotal.ToString("c2");
            lblTax.Text = tax.ToString("c2");
            lblTotal.Text = total.ToString("c2");
        }

        #region UI
        private void btnExit_Click(object sender, EventArgs e) //exit program
        {
            Application.Exit();
        }
        private void btnPurchase_Click(object sender, EventArgs e) //purchase
        {
            MessageBox.Show("Thank you for your purchase!");
            rdbNoBurger.Checked = true;
            rdbNoDrink.Checked = true;
            rdbNoSide.Checked = true;
        }
        #endregion UI
    }
}
