﻿using System;
using System.Windows.Forms;

namespace BurgerBarn
{
    public partial class frmBurgerBarn : Form
    {
        float subtotal = 0;
        const float tax_rate = 0.0825f;
        float total = 0;

        public frmBurgerBarn()
        {
            InitializeComponent();
        }
        //shared variables
        //put shared variables here
        //functions
            //put functions here
        private void frmBurgerBarn_Load(object sender, EventArgs e)
        {

        }
        //functions
        #region functions
        private string getCost(Control inputBox )
        {
            return inputBox.Text;
        }
        #endregion

        #region grop boxes
        // group boxes


        //burgers
        private void gbxBurgers_Enter(object sender, EventArgs e)
        {
            
        }

        //sides
        private void gbxSides_Enter(object sender, EventArgs e)
        {

        }

        //drinks
        private void gbxDrinks_Enter(object sender, EventArgs e)
        {

        }
        #endregion


        #region misc
        //if I add in information about percent completed, remember
        //it already exists
        //the name is prg_totalItems
        ///it's a progress bar

        #endregion


        #region burgers

        //all buttons related to the burgers
        private void rdb_plainBurg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_plainBurg.Checked == true)
            {
                lst_order.Items.Add(rdb_plainBurg.Text);
                subtotal += float.Parse(rdb_plainBurg.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_plainBurg.Text);
            }
        }

        private void rdb_cheeBurg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_vegBurg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_baconBurg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_noBurg_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region sides
        //all buttons related to the sides
        private void rdb_sidesFries_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_sideTatTot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_sideOnioRing_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_sideChip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_noSide_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region drinks
        // all buttons related to the drinks

        private void rdb_drinkCoala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_drinkTea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_drinkPunch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_drinkWater_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdb_noDrink_CheckedChanged(object sender, EventArgs e)
        {

        }


        //inside here are things that aren't needed yet, or possibly ever if ever, will look into how to remove
        #endregion

        private void lst_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region costs
        private void lbl_subtotal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tax_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}