using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPizza
{
    public partial class Form1 : Form
    {
        private float _TotalPrice;
        public Form1()
        {
            _TotalPrice = 0;
            InitializeComponent();
        }

        private void _ResetPizzaSize()
        {
            gbSize.Enabled = true;
            rbSmall.Checked = true;
        }
        private void _ResetCrustType()
        {
            gbCrustType.Enabled = true;
            rbThinCrust.Checked = true;
        }
        private void _ResetToppings()
        {
            gbToppings.Enabled = true;

            chkExtraCheese.Checked = false;
            chkGreenPeppers.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkTomato.Checked = false;
        }
        private void _ResetWhereToEat()
        {
            gbWhereToEat.Enabled = true;

            rbEatIn.Checked = true;
        }

        private void _UpdateSizeLabel()
        {
            lblSize.Text = (rbSmall.Checked ? rbSmall:rbMedium.Checked? rbMedium:rbLarge).Text;
        }

        private void _UpdateToppingsLabel()
        {
            string sToppings = "";
            if (chkExtraCheese.Checked)
                sToppings += chkExtraCheese.Text + ",";
            if (chkGreenPeppers.Checked)
                sToppings += chkGreenPeppers.Text + ",";
            if (chkMushrooms.Checked)
                sToppings += chkMushrooms.Text + ",";
            if (chkOlives.Checked)
                sToppings += chkOlives.Text + ",";
            if (chkOnion.Checked)
                sToppings += chkOnion.Text + ",";
            if (chkTomato.Checked)
                sToppings += chkTomato.Text + ",";

            sToppings = ((sToppings.EndsWith(",")? sToppings.Substring(0, sToppings.Length - 1) : sToppings)).Trim();
            lblToppings.Text = sToppings != "" ? sToppings : "No Toppings";
        }
        private void _UpdateWhereToEatLabel()
        {
            lblWhereToEat.Text = (rbEatIn.Checked ? rbEatIn:rbTakeOut).Text;
        }

        private void _UpdateCrustTypeLabel()
        {
            lblCrustType.Text =  (rbThinCrust.Checked? rbThinCrust:rbThickCrust).Text;
        }
        private void _UpdateOrderSummary()
        {
            _UpdateSizeLabel();
            _UpdateToppingsLabel();
            _UpdateWhereToEatLabel();
            _UpdateCrustTypeLabel();
        }

        private float _CalculateSizePrice()
        {
            RadioButton rbSelectedSize = rbSmall.Checked ? rbSmall : rbMedium.Checked ? rbMedium : rbLarge;
            if (float.TryParse(rbSelectedSize.Tag?.ToString(), out float Price))
            {
                return Price;
            }
            else
                return 0;
        }

        private float _CalculateCrustPrice()
        {
            RadioButton rbSelectedCrustType = rbThinCrust.Checked ? rbThinCrust : rbThickCrust;
            if (float.TryParse(rbSelectedCrustType.Tag?.ToString(), out float Price))
            {
                return Price;
            }
            else
                return 0;
        }

        private float _CalculateWhereToEatPrice()
        {
            RadioButton rbSelectedWhereToEat = rbEatIn.Checked ? rbEatIn : rbTakeOut;
            if (float.TryParse(rbSelectedWhereToEat.Tag?.ToString(), out float Price))
            {
                return Price;
            }
            else
                return 0;
        }

        private float  _GetToppingsCheckBoxPrice(CheckBox chk,bool IsChecked)
        {
            if (float.TryParse(chk.Tag?.ToString(), out float Price))
            {
                return Price;
            }
            else
                return 0;
        }
        private float _CalculateToppingsPrice()
        {
            float fToppingsPrice =0;
            fToppingsPrice += _GetToppingsCheckBoxPrice(chkExtraCheese, chkExtraCheese.Checked);
            fToppingsPrice += _GetToppingsCheckBoxPrice(chkGreenPeppers, chkGreenPeppers.Checked);
            fToppingsPrice += _GetToppingsCheckBoxPrice(chkMushrooms, chkMushrooms.Checked);
            fToppingsPrice += _GetToppingsCheckBoxPrice(chkOlives, chkOlives.Checked);
            fToppingsPrice += _GetToppingsCheckBoxPrice(chkOnion, chkOnion.Checked);
            fToppingsPrice += _GetToppingsCheckBoxPrice(chkTomato, chkTomato.Checked);

            return fToppingsPrice;
        }
        private float _CalculateTotalPrice()
        {
            return _CalculateSizePrice() + _CalculateCrustPrice() + _CalculateWhereToEatPrice() + _CalculateToppingsPrice();
        }
        private void _UpdateTotalPrice()
        {
            _TotalPrice = _CalculateTotalPrice();
            lblTotalPrice.Text = _TotalPrice.ToString("C1");
        }
        private void _ResetForm()
        {
            _ResetPizzaSize();
            _ResetCrustType();
            _ResetToppings();
            _ResetWhereToEat();
            _UpdateOrderSummary();
            _UpdateTotalPrice();
        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            _ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _UpdateOrderSummary();
            _UpdateTotalPrice();
        }
    }
}
