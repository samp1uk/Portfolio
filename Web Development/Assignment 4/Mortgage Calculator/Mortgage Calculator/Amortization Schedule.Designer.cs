namespace Mortgage_Calculator
{
    partial class Amortization_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amortization_Schedule));
            this.amortizationView = new System.Windows.Forms.DataGridView();
            this.monthlyPaymentLbl = new System.Windows.Forms.Label();
            this.totalOfPayLbl = new System.Windows.Forms.Label();
            this.totalInterestPaidLbl = new System.Windows.Forms.Label();
            this.payOffDateLbl = new System.Windows.Forms.Label();
            this.monthlyPaymentTxt = new System.Windows.Forms.TextBox();
            this.totalOfPayTxt = new System.Windows.Forms.TextBox();
            this.totalInterestPaidTxt = new System.Windows.Forms.TextBox();
            this.payOffDateTxt = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amortizationView)).BeginInit();
            this.SuspendLayout();
            // 
            // amortizationView
            // 
            this.amortizationView.AllowUserToAddRows = false;
            this.amortizationView.AllowUserToDeleteRows = false;
            this.amortizationView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.amortizationView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.amortizationView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amortizationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.amortizationView.Location = new System.Drawing.Point(12, 91);
            this.amortizationView.Name = "amortizationView";
            this.amortizationView.ReadOnly = true;
            this.amortizationView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.amortizationView.Size = new System.Drawing.Size(614, 336);
            this.amortizationView.TabIndex = 0;
            // 
            // monthlyPaymentLbl
            // 
            this.monthlyPaymentLbl.AutoSize = true;
            this.monthlyPaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPaymentLbl.Location = new System.Drawing.Point(24, 19);
            this.monthlyPaymentLbl.Name = "monthlyPaymentLbl";
            this.monthlyPaymentLbl.Size = new System.Drawing.Size(120, 15);
            this.monthlyPaymentLbl.TabIndex = 1;
            this.monthlyPaymentLbl.Text = "Monthly Payment:";
            // 
            // totalOfPayLbl
            // 
            this.totalOfPayLbl.AutoSize = true;
            this.totalOfPayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOfPayLbl.Location = new System.Drawing.Point(336, 20);
            this.totalOfPayLbl.Name = "totalOfPayLbl";
            this.totalOfPayLbl.Size = new System.Drawing.Size(125, 15);
            this.totalOfPayLbl.TabIndex = 2;
            this.totalOfPayLbl.Text = "Total of Payments:";
            // 
            // totalInterestPaidLbl
            // 
            this.totalInterestPaidLbl.AutoSize = true;
            this.totalInterestPaidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestPaidLbl.Location = new System.Drawing.Point(24, 59);
            this.totalInterestPaidLbl.Name = "totalInterestPaidLbl";
            this.totalInterestPaidLbl.Size = new System.Drawing.Size(128, 15);
            this.totalInterestPaidLbl.TabIndex = 3;
            this.totalInterestPaidLbl.Text = "Total Interest Paid:";
            // 
            // payOffDateLbl
            // 
            this.payOffDateLbl.AutoSize = true;
            this.payOffDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payOffDateLbl.Location = new System.Drawing.Point(336, 59);
            this.payOffDateLbl.Name = "payOffDateLbl";
            this.payOffDateLbl.Size = new System.Drawing.Size(89, 15);
            this.payOffDateLbl.TabIndex = 4;
            this.payOffDateLbl.Text = "Pay-off Date:";
            // 
            // monthlyPaymentTxt
            // 
            this.monthlyPaymentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyPaymentTxt.Location = new System.Drawing.Point(176, 16);
            this.monthlyPaymentTxt.Name = "monthlyPaymentTxt";
            this.monthlyPaymentTxt.ReadOnly = true;
            this.monthlyPaymentTxt.Size = new System.Drawing.Size(117, 22);
            this.monthlyPaymentTxt.TabIndex = 5;
            // 
            // totalOfPayTxt
            // 
            this.totalOfPayTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOfPayTxt.Location = new System.Drawing.Point(495, 17);
            this.totalOfPayTxt.Name = "totalOfPayTxt";
            this.totalOfPayTxt.ReadOnly = true;
            this.totalOfPayTxt.Size = new System.Drawing.Size(115, 22);
            this.totalOfPayTxt.TabIndex = 6;
            // 
            // totalInterestPaidTxt
            // 
            this.totalInterestPaidTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalInterestPaidTxt.Location = new System.Drawing.Point(176, 56);
            this.totalInterestPaidTxt.Name = "totalInterestPaidTxt";
            this.totalInterestPaidTxt.ReadOnly = true;
            this.totalInterestPaidTxt.Size = new System.Drawing.Size(115, 22);
            this.totalInterestPaidTxt.TabIndex = 7;
            // 
            // payOffDateTxt
            // 
            this.payOffDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payOffDateTxt.Location = new System.Drawing.Point(495, 56);
            this.payOffDateTxt.Name = "payOffDateTxt";
            this.payOffDateTxt.ReadOnly = true;
            this.payOffDateTxt.Size = new System.Drawing.Size(115, 22);
            this.payOffDateTxt.TabIndex = 8;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(12, 433);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(614, 34);
            this.close.TabIndex = 9;
            this.close.Text = "Close Window";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Amortization_Schedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 475);
            this.Controls.Add(this.close);
            this.Controls.Add(this.payOffDateTxt);
            this.Controls.Add(this.totalInterestPaidTxt);
            this.Controls.Add(this.totalOfPayTxt);
            this.Controls.Add(this.monthlyPaymentTxt);
            this.Controls.Add(this.payOffDateLbl);
            this.Controls.Add(this.totalInterestPaidLbl);
            this.Controls.Add(this.totalOfPayLbl);
            this.Controls.Add(this.monthlyPaymentLbl);
            this.Controls.Add(this.amortizationView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Amortization_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Amortization Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.amortizationView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label monthlyPaymentLbl;
        private System.Windows.Forms.Label totalOfPayLbl;
        private System.Windows.Forms.Label totalInterestPaidLbl;
        private System.Windows.Forms.Label payOffDateLbl;
        private System.Windows.Forms.TextBox monthlyPaymentTxt;
        private System.Windows.Forms.TextBox totalOfPayTxt;
        private System.Windows.Forms.TextBox totalInterestPaidTxt;
        private System.Windows.Forms.TextBox payOffDateTxt;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView amortizationView;
    }
}