using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }        
        float GetSelectedSizePrice()
        {
            if (RBsmall.Checked)
            {
                return Convert.ToSingle(RBsmall.Tag);
            }
            else if (RBmedium.Checked)
            {
                return Convert.ToSingle(RBmedium.Tag);
            }
            else
            {
                return Convert.ToSingle(RBlarge.Tag);
            }
        }
        float CalculateToppingsPrice()
        {
            float toppingsPrice = 0;
            if (chkBoxcheese.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkBoxcheese.Tag);
            }
            if (chkBoxtomato.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkBoxtomato.Tag);
            }
            if (chkBoxPeps.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkBoxPeps.Tag);
            }
            if (chkBoxonin.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkBoxonin.Tag);
            }
            if (chkBoxoliv.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkBoxoliv.Tag);
            }
            if (chkBoxMush.Checked)
            {
                toppingsPrice += Convert.ToSingle(chkBoxMush.Tag);
            }

            return toppingsPrice;
        }
        float GetSelectedCrustPrice()
        {
            if (RBstuffed.Checked)
            {
                return Convert.ToSingle(RBstuffed.Tag);
            }
            else if (RBthikcrust.Checked)
            {
                return Convert.ToSingle(RBthikcrust.Tag);
            }
            else
            {
                return Convert.ToSingle(Rbthincrust.Tag);
            }
        }
        float CalculateTotalPrice()
        {
            return GetSelectedCrustPrice()+GetSelectedSizePrice()+CalculateToppingsPrice();
        }
        void updateSize()
        {
            updateTotalPrice();
            if (RBsmall.Checked)
            {
                SizeValueLable.Text = RBsmall.Text;
                return;
            }
            if (RBmedium.Checked)
            {
                SizeValueLable.Text = RBmedium.Text;
                return;
            }
            if (RBlarge.Checked)
            {
                SizeValueLable.Text = RBlarge.Text;
                return;
            }
        }
        void updateTotalPrice()
        {
            TotalpriceValue.Text = "$"+CalculateTotalPrice().ToString();
        }
        void updateCrust()
        {
            updateTotalPrice();
            if (RBstuffed.Checked)
            {
                CrustTypeValue.Text = RBstuffed.Text;
                return;
            }
            if (RBthikcrust.Checked)
            {
                CrustTypeValue.Text = RBthikcrust.Text;
                return;
            }
            if (Rbthincrust.Checked)
            {
                CrustTypeValue.Text = Rbthincrust.Text;
                return;
            }
        }
        void updateToppings()
        {
            updateTotalPrice();
            string Topping = "";
            if (chkBoxcheese.Checked)
            {
                Topping = chkBoxcheese.Text;
            }
            if (chkBoxtomato.Checked)
            {
               Topping += ", " + chkBoxtomato.Text;

            }
            if (chkBoxPeps.Checked)
            {
                Topping += ", " + chkBoxPeps.Text;

            }
            if (chkBoxMush.Checked)
            {
                Topping += ", " + chkBoxMush.Text;
            }
            if (chkBoxonin.Checked)
            {
                Topping += ", " + chkBoxonin.Text;
            }
            if (chkBoxoliv.Checked)
            {
                Topping += ", " + chkBoxoliv.Text;
            }

            if (Topping.StartsWith(","))
            {
                Topping = Topping.Substring(1, Topping.Length - 1).Trim();
            }

            if (Topping == "")             
                Topping = "No Toppings";
                
            
            ToppingsValuelabel.Text = Topping;

        }
        void updateWhereToEat()
        {
            if (RBEatin.Checked)
            {
                WhereToEatValue.Text = RBEatin.Text;
                return;
            }
            if (RBtakeaway.Checked)
            {
                WhereToEatValue.Text = RBtakeaway.Text;
                return;
            }

        }

        private void RBsmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }
        private void RBmedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();    
        }
        private void RBlarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void RBstuffed_CheckedChanged(object sender, EventArgs e)
        {
           updateCrust();
        }
        private void RBthikcrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }
        private void Rbthincrust_CheckedChanged(object sender, EventArgs e)
        {
           updateCrust();
        }

        private void chkBoxcheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkBoxtomato_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkBoxPeps_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkBoxMush_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkBoxonin_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void chkBoxoliv_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void RBEatin_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }
        private void RBtakeaway_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }      

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("confirm Order ?","confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                
                    GBCrust.Enabled = false ;
                    GBtoppins.Enabled = false ;
                    GBwheretoeat.Enabled = false ;
                    GBsize.Enabled = false ;
                    Orderbtn.Enabled = false;               
            }
            else
            {
                MessageBox.Show("Update your order","Update",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Restbtn_Click(object sender, EventArgs e)
        {
            GBCrust.Enabled = true;
            GBtoppins.Enabled = true;
            GBwheretoeat.Enabled = true;
            GBsize.Enabled = true;
            Orderbtn.Enabled = true;

            chkBoxcheese.Checked = false;
            chkBoxMush.Checked = false;
            chkBoxoliv.Checked = false; 
            chkBoxonin.Checked = false;
            chkBoxtomato.Checked = false;
            chkBoxPeps.Checked = false;

            RBsmall.Checked = true;
            RBEatin.Checked = true;
            Rbthincrust.Checked = true;
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            updateSize();
            updateCrust();
            updateToppings();
            updateWhereToEat();
            updateTotalPrice();            
        }
    }    
}
