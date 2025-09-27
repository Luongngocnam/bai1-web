using System;
using System.Windows.Forms;
using CompoundInterestDLL;

namespace InterestWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal, rate;
            int years;
            if (double.TryParse(txtPrincipal.Text, out principal) && double.TryParse(txtRate.Text, out rate) && int.TryParse(txtYears.Text, out years))
            {
                InterestCalculator calculator = new InterestCalculator();
                calculator.Principal = principal;
                calculator.Rate = rate;
                calculator.Years = years;

                string result = calculator.CalculateInterest();
                lblResult.Text = result + "Luong Ngoc Nam";
            }
            else
            {
                lblResult.Text = "Input không hợp lệ.";
            }
        }
    }
}