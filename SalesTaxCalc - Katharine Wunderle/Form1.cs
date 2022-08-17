using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesTaxCalc___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 02/21/2021
    //Goal: Calculate total price with sales tax
    public partial class LorainCountySalesTaxCalc : Form
    {
        //Tax rate constant
        private const decimal TAX_RATE = .0675m;
        public LorainCountySalesTaxCalc()
        {
            InitializeComponent();
        }
        private void calcBtn_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal salesAmount;
            decimal taxAmount;
            decimal totalAmount;

            //Get Sales Amount as input from user
            salesAmount = decimal.Parse(salesAmountInputTxtBx.Text);

            //Calculate Tax Amount
            taxAmount = salesAmount * TAX_RATE;

            //Calculate Total Price
            totalAmount = salesAmount + taxAmount;

            //Display Tax Amount
            taxAmountOutput.Text = taxAmount.ToString("c");

            //Display Total Price
            totalAmountOutput.Text = totalAmount.ToString("c");
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear text boxes
            salesAmountInputTxtBx.Text = "";
            taxAmountOutput.Text = "";
            totalAmountOutput.Text = "";
        }
        private void LorainCountySalesTaxCalc_Load(object sender, EventArgs e)
        {
            //Display current tax rate
            taxRateLbl.Text = "(@ " + TAX_RATE.ToString("p") + "):";
        }
    }
}
