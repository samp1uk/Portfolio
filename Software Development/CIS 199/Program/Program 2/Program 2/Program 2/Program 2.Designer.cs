namespace Program_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.filingstatuslabel = new System.Windows.Forms.Label();
            this.incomelabel = new System.Windows.Forms.Label();
            this.singleRadio = new System.Windows.Forms.RadioButton();
            this.marriedFilingJointlyRadio = new System.Windows.Forms.RadioButton();
            this.headOfHouseholdRadio = new System.Windows.Forms.RadioButton();
            this.marriedFilingSeparatelyRadio = new System.Windows.Forms.RadioButton();
            this.taxButton = new System.Windows.Forms.Button();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.outputlabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.incomeTxt = new System.Windows.Forms.TextBox();
            this.paylabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filingstatuslabel
            // 
            this.filingstatuslabel.AutoSize = true;
            this.filingstatuslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filingstatuslabel.Location = new System.Drawing.Point(26, 22);
            this.filingstatuslabel.Name = "filingstatuslabel";
            this.filingstatuslabel.Size = new System.Drawing.Size(234, 16);
            this.filingstatuslabel.TabIndex = 0;
            this.filingstatuslabel.Text = "Please Select Your Filing Status:";
            // 
            // incomelabel
            // 
            this.incomelabel.AutoSize = true;
            this.incomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomelabel.Location = new System.Drawing.Point(26, 162);
            this.incomelabel.Name = "incomelabel";
            this.incomelabel.Size = new System.Drawing.Size(256, 16);
            this.incomelabel.TabIndex = 1;
            this.incomelabel.Text = "Please Enter Your Taxable Iincome:";
            // 
            // singleRadio
            // 
            this.singleRadio.AutoSize = true;
            this.singleRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleRadio.Location = new System.Drawing.Point(29, 61);
            this.singleRadio.Name = "singleRadio";
            this.singleRadio.Size = new System.Drawing.Size(66, 22);
            this.singleRadio.TabIndex = 2;
            this.singleRadio.TabStop = true;
            this.singleRadio.Text = "Single";
            this.singleRadio.UseVisualStyleBackColor = true;
            // 
            // marriedFilingJointlyRadio
            // 
            this.marriedFilingJointlyRadio.AutoSize = true;
            this.marriedFilingJointlyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marriedFilingJointlyRadio.Location = new System.Drawing.Point(29, 106);
            this.marriedFilingJointlyRadio.Name = "marriedFilingJointlyRadio";
            this.marriedFilingJointlyRadio.Size = new System.Drawing.Size(160, 22);
            this.marriedFilingJointlyRadio.TabIndex = 3;
            this.marriedFilingJointlyRadio.TabStop = true;
            this.marriedFilingJointlyRadio.Text = "Married Filing Jointly";
            this.marriedFilingJointlyRadio.UseVisualStyleBackColor = true;
            // 
            // headOfHouseholdRadio
            // 
            this.headOfHouseholdRadio.AutoSize = true;
            this.headOfHouseholdRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headOfHouseholdRadio.Location = new System.Drawing.Point(192, 106);
            this.headOfHouseholdRadio.Name = "headOfHouseholdRadio";
            this.headOfHouseholdRadio.Size = new System.Drawing.Size(154, 22);
            this.headOfHouseholdRadio.TabIndex = 4;
            this.headOfHouseholdRadio.TabStop = true;
            this.headOfHouseholdRadio.Text = "Head of Household";
            this.headOfHouseholdRadio.UseVisualStyleBackColor = true;
            // 
            // marriedFilingSeparatelyRadio
            // 
            this.marriedFilingSeparatelyRadio.AutoSize = true;
            this.marriedFilingSeparatelyRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marriedFilingSeparatelyRadio.Location = new System.Drawing.Point(192, 61);
            this.marriedFilingSeparatelyRadio.Name = "marriedFilingSeparatelyRadio";
            this.marriedFilingSeparatelyRadio.Size = new System.Drawing.Size(187, 22);
            this.marriedFilingSeparatelyRadio.TabIndex = 5;
            this.marriedFilingSeparatelyRadio.TabStop = true;
            this.marriedFilingSeparatelyRadio.Text = "Married Filing Separately";
            this.marriedFilingSeparatelyRadio.UseVisualStyleBackColor = true;
            // 
            // taxButton
            // 
            this.taxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxButton.Location = new System.Drawing.Point(29, 201);
            this.taxButton.Name = "taxButton";
            this.taxButton.Size = new System.Drawing.Size(253, 32);
            this.taxButton.TabIndex = 7;
            this.taxButton.Text = "Check Your 2019 Tax Bracket";
            this.taxButton.UseVisualStyleBackColor = true;
            this.taxButton.Click += new System.EventHandler(this.taxButton_Click);
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.AutoSize = true;
            this.taxOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.taxOutputLabel.Location = new System.Drawing.Point(481, 18);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(197, 20);
            this.taxOutputLabel.TabIndex = 8;
            this.taxOutputLabel.Text = "Your 2019 Tax Bracket:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // outputlabel
            // 
            this.outputlabel.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputlabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputlabel.Location = new System.Drawing.Point(461, 162);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(217, 79);
            this.outputlabel.TabIndex = 10;
            this.outputlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(288, 201);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 32);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // incomeTxt
            // 
            this.incomeTxt.Location = new System.Drawing.Point(288, 162);
            this.incomeTxt.Name = "incomeTxt";
            this.incomeTxt.Size = new System.Drawing.Size(112, 20);
            this.incomeTxt.TabIndex = 12;
            // 
            // paylabel
            // 
            this.paylabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paylabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.paylabel.Location = new System.Drawing.Point(462, 49);
            this.paylabel.Name = "paylabel";
            this.paylabel.Size = new System.Drawing.Size(215, 79);
            this.paylabel.TabIndex = 13;
            this.paylabel.Text = "The Amount of Tax that would be Due is:";
            this.paylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountBox.Location = new System.Drawing.Point(466, 132);
            this.amountBox.Name = "amountBox";
            this.amountBox.ReadOnly = true;
            this.amountBox.Size = new System.Drawing.Size(211, 26);
            this.amountBox.TabIndex = 14;
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.taxButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(689, 250);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.paylabel);
            this.Controls.Add(this.incomeTxt);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.taxOutputLabel);
            this.Controls.Add(this.taxButton);
            this.Controls.Add(this.marriedFilingSeparatelyRadio);
            this.Controls.Add(this.headOfHouseholdRadio);
            this.Controls.Add(this.marriedFilingJointlyRadio);
            this.Controls.Add(this.singleRadio);
            this.Controls.Add(this.incomelabel);
            this.Controls.Add(this.filingstatuslabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outputlabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filingstatuslabel;
        private System.Windows.Forms.Label incomelabel;
        private System.Windows.Forms.RadioButton singleRadio;
        private System.Windows.Forms.RadioButton marriedFilingJointlyRadio;
        private System.Windows.Forms.RadioButton headOfHouseholdRadio;
        private System.Windows.Forms.RadioButton marriedFilingSeparatelyRadio;
        private System.Windows.Forms.Button taxButton;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox incomeTxt;
        private System.Windows.Forms.Label paylabel;
        private System.Windows.Forms.TextBox amountBox;
    }
}

