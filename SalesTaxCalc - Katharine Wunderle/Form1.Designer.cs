
namespace SalesTaxCalc___Katharine_Wunderle
{
    partial class LorainCountySalesTaxCalc
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
            this.enterSalesAmountLbl = new System.Windows.Forms.Label();
            this.salesAmountInputTxtBx = new System.Windows.Forms.TextBox();
            this.taxAmountLbl = new System.Windows.Forms.Label();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.taxRateLbl = new System.Windows.Forms.Label();
            this.taxAmountOutput = new System.Windows.Forms.Label();
            this.totalAmountOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterSalesAmountLbl
            // 
            this.enterSalesAmountLbl.Location = new System.Drawing.Point(21, 29);
            this.enterSalesAmountLbl.Name = "enterSalesAmountLbl";
            this.enterSalesAmountLbl.Size = new System.Drawing.Size(100, 29);
            this.enterSalesAmountLbl.TabIndex = 0;
            this.enterSalesAmountLbl.Text = " Please Enter Sales Amount:";
            this.enterSalesAmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salesAmountInputTxtBx
            // 
            this.salesAmountInputTxtBx.Location = new System.Drawing.Point(21, 64);
            this.salesAmountInputTxtBx.Name = "salesAmountInputTxtBx";
            this.salesAmountInputTxtBx.Size = new System.Drawing.Size(100, 20);
            this.salesAmountInputTxtBx.TabIndex = 1;
            // 
            // taxAmountLbl
            // 
            this.taxAmountLbl.AutoSize = true;
            this.taxAmountLbl.Location = new System.Drawing.Point(21, 106);
            this.taxAmountLbl.Name = "taxAmountLbl";
            this.taxAmountLbl.Size = new System.Drawing.Size(99, 13);
            this.taxAmountLbl.TabIndex = 2;
            this.taxAmountLbl.Text = "Your Tax Amount is";
            this.taxAmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAmountLbl
            // 
            this.totalAmountLbl.AutoSize = true;
            this.totalAmountLbl.Location = new System.Drawing.Point(21, 195);
            this.totalAmountLbl.Name = "totalAmountLbl";
            this.totalAmountLbl.Size = new System.Drawing.Size(101, 26);
            this.totalAmountLbl.TabIndex = 3;
            this.totalAmountLbl.Text = "The Total Amount\r\nYou Have to Pay is:";
            this.totalAmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(175, 73);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 6;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            this.calcBtn.Enter += new System.EventHandler(this.calcBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(175, 115);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 7;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // taxRateLbl
            // 
            this.taxRateLbl.AutoSize = true;
            this.taxRateLbl.Location = new System.Drawing.Point(40, 122);
            this.taxRateLbl.Name = "taxRateLbl";
            this.taxRateLbl.Size = new System.Drawing.Size(63, 13);
            this.taxRateLbl.TabIndex = 8;
            this.taxRateLbl.Text = "TAX_RATE";
            this.taxRateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxAmountOutput
            // 
            this.taxAmountOutput.BackColor = System.Drawing.Color.Yellow;
            this.taxAmountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.taxAmountOutput.Location = new System.Drawing.Point(32, 142);
            this.taxAmountOutput.Name = "taxAmountOutput";
            this.taxAmountOutput.Size = new System.Drawing.Size(78, 36);
            this.taxAmountOutput.TabIndex = 9;
            // 
            // totalAmountOutput
            // 
            this.totalAmountOutput.BackColor = System.Drawing.Color.Aqua;
            this.totalAmountOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalAmountOutput.Location = new System.Drawing.Point(32, 229);
            this.totalAmountOutput.Name = "totalAmountOutput";
            this.totalAmountOutput.Size = new System.Drawing.Size(78, 38);
            this.totalAmountOutput.TabIndex = 10;
            // 
            // LorainCountySalesTaxCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 282);
            this.Controls.Add(this.totalAmountOutput);
            this.Controls.Add(this.taxAmountOutput);
            this.Controls.Add(this.taxRateLbl);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.totalAmountLbl);
            this.Controls.Add(this.taxAmountLbl);
            this.Controls.Add(this.salesAmountInputTxtBx);
            this.Controls.Add(this.enterSalesAmountLbl);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "LorainCountySalesTaxCalc";
            this.Text = "Lorain County Sales Tax Calculator";
            this.Load += new System.EventHandler(this.LorainCountySalesTaxCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterSalesAmountLbl;
        private System.Windows.Forms.TextBox salesAmountInputTxtBx;
        private System.Windows.Forms.Label taxAmountLbl;
        private System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Label taxRateLbl;
        private System.Windows.Forms.Label taxAmountOutput;
        private System.Windows.Forms.Label totalAmountOutput;
    }
}

