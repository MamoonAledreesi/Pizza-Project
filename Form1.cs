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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        

        void UpdateSize()
        {
            UpdateTotalPrice();

            if(rbSamll.Checked)
            {
                lbSize2.Text = "Small";
                return;
            }

            if(rbMeduim.Checked)
            {
                lbSize2.Text = "Meduim";
                return;
            }

            if(rbLarg.Checked)
            {
                lbSize2.Text = "Larg";
                return;
            }



        }
        void UpdateTopping()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (cbExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }
            if (cbOinion.Checked)
            {
                sToppings += ", Onion";
            }

            if (cbOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (cbTomatoes.Checked)

            {
                sToppings += ", Tomatoes";
            }
            if (cbMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (cbGrrenPepper.Checked)
            {
                sToppings += ", Green Peppars";
            }
            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";
            lbToppings2.Text = sToppings;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThin.Checked)
            {
                lbCurstType2.Text = "Thin Crust";
                return;
            }

            if (rbThink.Checked)
            {
                lbCurstType2.Text = "Think Crust";
                return;
            }
        }

        float GetSelectedSizePrice()
        {
            if (rbSamll.Checked)
                return Convert.ToSingle(rbSamll.Tag);
           else if (rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);
            else
                 return Convert.ToSingle(rbLarg.Tag);
        }

       float CalculateToppingPrice()
        {
            float ToppingTotalPrice=0;

            if(cbExtraChees.Checked)
            {
                ToppingTotalPrice+=Convert.ToSingle(cbExtraChees.Tag);  
            }

            if(cbOinion.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(cbOinion.Tag);
            }
            if(cbOlives.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(cbOlives.Tag);  
            }

            if(cbTomatoes.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(cbTomatoes.Tag);
            }

            if(cbGrrenPepper.Checked)
            {
                ToppingTotalPrice += Convert.ToSingle(cbGrrenPepper.Tag);
            }

            if(cbMushrooms.Checked)
            {
                ToppingTotalPrice+=Convert.ToSingle(cbMushrooms.Tag);
            }
            return ToppingTotalPrice;

        }

        float CalcualteSelectedCrustPrice()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThink.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice()+CalculateToppingPrice()+CalcualteSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lbtotalprice2.Text="$"+ CalculateTotalPrice().ToString();
        }

        void UpdaeOrderSummary()
        {
            UpdateSize();
            UpdateTopping();
            UpdateCrust();
            UpdateTotalPrice();
        }

        

        
        private void rbSamll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
          

        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();  
               
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbeaten_CheckedChanged(object sender, EventArgs e)
        {
            lbWhrertoeat2.Text = rbeaten.Text;
        }

        private void rbeatout_CheckedChanged(object sender, EventArgs e)
        {
            lbWhrertoeat2.Text=rbeatout.Text;
        }

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void cbOinion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

        private void cbGrrenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTopping();
        }

       
        
        void ResetForm()
        {
            gbSize.Enabled = true;
            gbTopping.Enabled = true;
            gbwhrertoeat.Enabled = true;
            gbcrusttype.Enabled = true;

            //size
            rbMeduim.Checked = true;

            //toppings
            cbExtraChees.Checked = false;
            cbOinion.Checked = false;
            cbTomatoes.Checked = false;
            cbOlives.Checked= false;
            cbMushrooms.Checked = false;    
            cbGrrenPepper.Checked = false;


            rbThin.Checked = true;

            rbeaten.Checked = true;


            btnorderpizza.Enabled = true;
        }

        private void btnorderpizza_Click(object sender, EventArgs e)
        {
          if(  MessageBox.Show("Confirm Odrder?","Confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.OK)

            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled=false;
                gbTopping.Enabled=false;
                gbwhrertoeat.Enabled=false;
                gbcrusttype.Enabled=false;
                btnorderpizza.Enabled=false;
                numericUpDown1.Value += 1;
            }
        }

        private void btnresetform_Click(object sender, EventArgs e)
        {
            
            ResetForm();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            UpdaeOrderSummary();
        }

       
    }
    
    
    
    
}
