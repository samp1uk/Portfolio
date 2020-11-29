namespace Mortgage_Calculator
{
    partial class MortgageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MortgageCalculator));
            this.principallbl = new System.Windows.Forms.Label();
            this.interestRateLbl = new System.Windows.Forms.Label();
            this.monthsLbl = new System.Windows.Forms.Label();
            this.principalTxt = new System.Windows.Forms.TextBox();
            this.interestRateTxt = new System.Windows.Forms.TextBox();
            this.monthsTxt = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.monthlyPaymentLbl = new System.Windows.Forms.Label();
            this.monthlyPaymentTxt = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // principallbl
            // 
            this.principallbl.AutoSize = true;
            this.principallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principallbl.Location = new System.Drawing.Point(22, 24);
            this.principallbl.Name = "principallbl";
            this.principallbl.Size = new System.Drawing.Size(72, 20);
            this.principallbl.TabIndex = 0;
            this.principallbl.Text = "Principal:";
            // 
            // interestRateLbl
            // 
            this.interestRateLbl.AutoSize = true;
            this.interestRateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateLbl.Location = new System.Drawing.Point(22, 72);
            this.interestRateLbl.Name = "interestRateLbl";
            this.interestRateLbl.Size = new System.Drawing.Size(107, 20);
            this.interestRateLbl.TabIndex = 1;
            this.interestRateLbl.Text = "Interest Rate:";
            // 
            // monthsLbl
            // 
            this.monthsLbl.AutoSize = true;
            this.monthsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsLbl.Location = new System.Drawing.Point(22, 117);
            this.monthsLbl.Name = "monthsLbl";
            this.monthsLbl.Size = new System.Drawing.Size(66, 20);
            this.monthsLbl.TabIndex = 2;
            this.monthsLbl.Text = "Months:";
            // 
            // principalTxt
            // 
            this.principalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principalTxt.Location = new System.Drawing.Point(158, 22);
            this.principalTxt.Name = "principalTxt";
            this.principalTxt.Size = new System.Drawing.Size(127, 26);
            this.principalTxt.TabIndex = 3;
            // 
            // interestRateTxt
            // 
            this.interestRateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestRateTxt.Location = new System.Drawing.Point(158, 70);
            this.interestRateTxt.Name = "interestRateTxt";
            this.interestRateTxt.Size = new System.Drawing.Size(127, 26);
            this.interestRateTxt.TabIndex = 4;
            // 
            // monthsTxt
            // 
            this.monthsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsTxt.Location = new System.Drawing.Point(158, 115);
            this.monthsTxt.Name = "monthsTxt";
            this.monthsTxt.Size = new System.Drawing.Size(127, 26);
            this.monthsTxt.TabIndex = 5;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(16, 165);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(269, 33);
            this.submitBtn.TabIndex = 6;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // monthlyPaymentLbl
            // 
            this.monthlyPaymentLbl.AutoSize = true;
            this.monthlyPaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPaymentLbl.Location = new System.Drawing.Point(12, 218);
            this.monthlyPaymentLbl.Name = "monthlyPaymentLbl";
            this.monthlyPaymentLbl.Size = new System.Drawing.Size(134, 20);
            this.monthlyPaymentLbl.TabIndex = 7;
            this.monthlyPaymentLbl.Text = "Monthly Payment:";
            // 
            // monthlyPaymentTxt
            // 
            this.monthlyPaymentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPaymentTxt.Location = new System.Drawing.Point(158, 215);
            this.monthlyPaymentTxt.Name = "monthlyPaymentTxt";
            this.monthlyPaymentTxt.ReadOnly = true;
            this.monthlyPaymentTxt.Size = new System.Drawing.Size(127, 26);
            this.monthlyPaymentTxt.TabIndex = 9;
            // 
            // viewBtn
            // 
            this.viewBtn.BackColor = System.Drawing.Color.Coral;
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.viewBtn.Location = new System.Drawing.Point(16, 257);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(269, 29);
            this.viewBtn.TabIndex = 10;
            this.viewBtn.Text = "View Your Amortization Schedule ";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Visible = false;
            this.viewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // MortgageCalculator
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 305);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.monthlyPaymentTxt);
            this.Controls.Add(this.monthlyPaymentLbl);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.monthsTxt);
            this.Controls.Add(this.interestRateTxt);
            this.Controls.Add(this.principalTxt);
            this.Controls.Add(this.monthsLbl);
            this.Controls.Add(this.interestRateLbl);
            this.Controls.Add(this.principallbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MortgageCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mortgage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label principallbl;
        private System.Windows.Forms.Label interestRateLbl;
        private System.Windows.Forms.Label monthsLbl;
        private System.Windows.Forms.TextBox principalTxt;
        private System.Windows.Forms.TextBox interestRateTxt;
        private System.Windows.Forms.TextBox monthsTxt;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label monthlyPaymentLbl;
        private System.Windows.Forms.TextBox monthlyPaymentTxt;
        private System.Windows.Forms.Button viewBtn;
    }
}

