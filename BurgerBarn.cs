using System;
using System.Windows.Forms;

namespace BurgerBarnSummer
{

    public partial class BurgerBarn : Form
    {
        float subtotal = 0;
        float tax_rate = 0.0825f;
        float discount = 1;
        const string noCouponText = "No Coupon"; //the text for no coupon, allowing you to change the "no coupon" phrase!
        public BurgerBarn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

#region select
        private void btn_selectOrder(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton; //burgers selected
            rdbSelect(rdb); //call method
        }
#endregion
        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if(lstOrder.Items.Count == 0)
            {
                MessageBox.Show("You must have an item in your order to purchase."); //Show message
            }
            else
            {
                string message = "";

                foreach(var item in lstOrder.Items)
                {
                    message += item.ToString() + "\n";
                }

                message += "---------------------------\n";

                message += string.Format("Subtotal: \t{0:C}\n", lblSubtotal.Text); //displays subtotal
                message += string.Format("Tax:      \t\t{0:C}\n", lblTax.Text); //displays Tax
                message += string.Format("Total:    \t\t{0:C}\n", lblTotal.Text); //displays total
                
                MessageBox.Show(message);

                rdbNoBurger.Checked = true; //selects no burger
                rdbNoDrink.Checked = true; //selects no drink
                rdbNoSandwich.Checked = true; //selects no sandwich

                cmb_coupon.SelectedIndex = 0; //reset selected coupon
            }
        }
        private void CalcTotal()
        {
   
            //calculate subtotal
            float tax = (subtotal * discount) * tax_rate;
            float total = (subtotal * discount) + tax;

            //display subtotal 
            lblSubtotal.Text = (subtotal * discount).ToString("c2");
            lblTax.Text = tax.ToString("c2");
            lblTotal.Text = total.ToString("c2");

            if (discount < 0) {
                lblSubtotal.Text = "-" + lblSubtotal.Text;
                lblTax.Text = "-" + lblTax.Text;
                lblTotal.Text = "-" + lblTotal.Text;
            } //checks that the discount is more than zero. If it isn't, then it is a negative discount, and thus the calculated value must be multiplied by -1
        }


        private void rdbSelect(RadioButton rdb)
        {
            if (rdb.Checked)  //if selected 
            {
                if (rdb.Text != "None")
                    lstOrder.Items.Add(rdb.Text);      //add plain burger to receipt

                subtotal += float.Parse(rdb.Tag.ToString());   //update subtotal
            }
            else //if plain burger is deselected
            {
                lstOrder.Items.Remove(rdb.Text); //remove plain burger from receipt

                subtotal -= float.Parse(rdb.Tag.ToString()); //update subtotal 
            }
           CalcTotal(); //Call method
        }

        private void cmb_coupon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_coupon.Text == noCouponText)
            {
                discount = 1; //no discount is 1
            } else
            {
                string discString = cmb_coupon.Text;
                discString = discString.Substring(0, discString.Length - 1); //remove percent sign
                float discVal = float.Parse(discString); //convert that text to number
                discVal = discVal / 100; //convert the number to percent by divideing by 100
                discVal = 1 - discVal; //subtract one to make it into a "percent off"
                discount = discVal; //set discount
            }
            CalcTotal(); //run calculation
        }

        private void BurgerBarn_Load(object sender, EventArgs e)
        {
            cmb_coupon.Items.Insert(0, noCouponText); //add the text for no coupon (as that's not hard-coded)
            cmb_coupon.SelectedIndex = 0; //reset coupon (as a new "0" is added, it needs to be set to 0)
        }
    }
}
