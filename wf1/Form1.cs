using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf1
{
    public partial class Form1 : Form
    {
        double totalSum = 0;
        float[] OilPrices = { 10, 12, 14 };
        public Form1()
        {
            InitializeComponent();
            cbOil.SelectedIndex = 0;
            lbSumOil.Text = lbSumFood.Text = lbSumTotal.Text = "0";
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (/*e.KeyChar != Convert.ToChar(Keys.Delete) &&*/ e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
                    e.Handled = true;
                else if (!Char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                    e.Handled = true;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkboxState = (sender as CheckBox).Checked;
            TextBox tmp = null;
            switch ((sender as CheckBox).Tag.ToString())
            {
                case "1":
                    tmp = tbHotdog;
                    break;
                case "2":
                    tmp = tbBurger;
                    break;
                case "3":
                    tmp = tbFri;
                    break;
                case "4":
                    tmp = tbCola;
                    break;
                default:
                    break;
            }
            tmp.Enabled = checkboxState;
            tmp.Text = "";
            tmp.Focus();
        }

        private void CbOil_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbPriceOil.Text = OilPrices[(sender as ComboBox).SelectedIndex].ToString();
            if (!String.IsNullOrWhiteSpace(tbMoneyOil.Text) || !String.IsNullOrWhiteSpace(tbQuantityOil.Text))
                TbQuantityOil_TextChanged(null, null);
        }

        private void RbQuantity_CheckedChanged(object sender, EventArgs e)
        {
            tbMoneyOil.Enabled = !(tbQuantityOil.Enabled = rbQuantity.Checked);
        }

        private void TbQuantityOil_TextChanged(object sender, EventArgs e)
        {
            if ((!String.IsNullOrWhiteSpace(tbQuantityOil.Text) && tbQuantityOil.Enabled) || (!String.IsNullOrWhiteSpace(tbMoneyOil.Text) && tbMoneyOil.Enabled))
            {
                if (tbQuantityOil.Enabled)
                    tbMoneyOil.Text = Math.Round((Convert.ToDouble(tbPriceOil.Text) * Convert.ToDouble(tbQuantityOil.Text)), 2, MidpointRounding.AwayFromZero).ToString();
                else
                    tbQuantityOil.Text = (Convert.ToDouble(tbMoneyOil.Text) / Convert.ToDouble(tbPriceOil.Text)).ToString();
                lbSumOil.Text = tbMoneyOil.Text;
            }
            else
            {
                tbQuantityOil.Text = tbMoneyOil.Text = "";
                lbSumOil.Text = "0";
            }
        }

        private void TbFood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (!Char.IsDigit(e.KeyChar))
                    e.Handled = true;
            }
        }
        private double Recalc()
        {
            double sum = 0;
            if (tbHotdog.Enabled && !String.IsNullOrWhiteSpace(tbHotdog.Text))
                sum += Convert.ToDouble(tbHotdog.Text) * Convert.ToDouble(tbPriceHotdog.Text);
            if (tbBurger.Enabled && !String.IsNullOrWhiteSpace(tbBurger.Text))
                sum += Convert.ToDouble(tbBurger.Text) * Convert.ToDouble(tbPriceBurger.Text);
            if (tbFri.Enabled && !String.IsNullOrWhiteSpace(tbFri.Text))
                sum += Convert.ToDouble(tbFri.Text) * Convert.ToDouble(tbPriceFri.Text);
            if (tbCola.Enabled && !String.IsNullOrWhiteSpace(tbCola.Text))
                sum += Convert.ToDouble(tbCola.Text) * Convert.ToDouble(tbCola.Text);
            return sum;
        }
        private void TbFood_TextChanged_1(object sender, EventArgs e)
        {
            lbSumFood.Text = Recalc().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbSumTotal.Text = (Convert.ToDouble(lbSumOil.Text) + Convert.ToDouble(lbSumFood.Text)).ToString();
            timer1.Start();
        }
        private void Reset()
        {
            totalSum += Convert.ToDouble(lbSumTotal.Text);
            cbOil.SelectedIndex = 0;
            lbSumOil.Text = lbSumFood.Text = lbSumTotal.Text = "0";
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            CheckOut();
        }
        private void CheckOut()
        {
            if (MessageBox.Show("Check out?", "Checkout message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                Reset();
            else
                timer1.Start();
        }
    }
}
