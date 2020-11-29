namespace Lab8
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
            this.futureLabel = new System.Windows.Forms.Label();
            this.intrestLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.calButton = new System.Windows.Forms.Button();
            this.futureTxt = new System.Windows.Forms.TextBox();
            this.intrestTxt = new System.Windows.Forms.TextBox();
            this.yearTxt = new System.Windows.Forms.TextBox();
            this.valueTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // futureLabel
            // 
            this.futureLabel.AutoSize = true;
            this.futureLabel.Location = new System.Drawing.Point(12, 19);
            this.futureLabel.Name = "futureLabel";
            this.futureLabel.Size = new System.Drawing.Size(70, 13);
            this.futureLabel.TabIndex = 0;
            this.futureLabel.Text = "Future Value:";
            // 
            // intrestLabel
            // 
            this.intrestLabel.AutoSize = true;
            this.intrestLabel.Location = new System.Drawing.Point(12, 48);
            this.intrestLabel.Name = "intrestLabel";
            this.intrestLabel.Size = new System.Drawing.Size(107, 13);
            this.intrestLabel.TabIndex = 1;
            this.intrestLabel.Text = "Annual Interest Rate:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(12, 80);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(64, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "No. of Year:";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(12, 111);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(76, 13);
            this.valueLabel.TabIndex = 3;
            this.valueLabel.Text = "Present Value:";
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(60, 155);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(108, 30);
            this.calButton.TabIndex = 4;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // futureTxt
            // 
            this.futureTxt.Location = new System.Drawing.Point(131, 16);
            this.futureTxt.Name = "futureTxt";
            this.futureTxt.Size = new System.Drawing.Size(100, 20);
            this.futureTxt.TabIndex = 5;
            // 
            // intrestTxt
            // 
            this.intrestTxt.Location = new System.Drawing.Point(131, 45);
            this.intrestTxt.Name = "intrestTxt";
            this.intrestTxt.Size = new System.Drawing.Size(100, 20);
            this.intrestTxt.TabIndex = 6;
            // 
            // yearTxt
            // 
            this.yearTxt.Location = new System.Drawing.Point(131, 77);
            this.yearTxt.Name = "yearTxt";
            this.yearTxt.Size = new System.Drawing.Size(100, 20);
            this.yearTxt.TabIndex = 7;
            // 
            // valueTxt
            // 
            this.valueTxt.Location = new System.Drawing.Point(131, 108);
            this.valueTxt.Name = "valueTxt";
            this.valueTxt.ReadOnly = true;
            this.valueTxt.Size = new System.Drawing.Size(100, 20);
            this.valueTxt.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.calButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 193);
            this.Controls.Add(this.valueTxt);
            this.Controls.Add(this.yearTxt);
            this.Controls.Add(this.intrestTxt);
            this.Controls.Add(this.futureTxt);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.intrestLabel);
            this.Controls.Add(this.futureLabel);
            this.Name = "Form1";
            this.Text = "Lab 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label futureLabel;
        private System.Windows.Forms.Label intrestLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.TextBox futureTxt;
        private System.Windows.Forms.TextBox intrestTxt;
        private System.Windows.Forms.TextBox yearTxt;
        private System.Windows.Forms.TextBox valueTxt;
    }
}

