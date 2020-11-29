namespace Lab_9
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
            this.monthButton = new System.Windows.Forms.Button();
            this.dayButton = new System.Windows.Forms.Button();
            this.yearButton = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.dateOutputTxt = new System.Windows.Forms.TextBox();
            this.monthInputTxt = new System.Windows.Forms.TextBox();
            this.dayInputTxt = new System.Windows.Forms.TextBox();
            this.yearInputTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthButton
            // 
            this.monthButton.Location = new System.Drawing.Point(185, 68);
            this.monthButton.Name = "monthButton";
            this.monthButton.Size = new System.Drawing.Size(90, 23);
            this.monthButton.TabIndex = 0;
            this.monthButton.Text = "Update Month";
            this.monthButton.UseVisualStyleBackColor = true;
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // dayButton
            // 
            this.dayButton.Location = new System.Drawing.Point(185, 106);
            this.dayButton.Name = "dayButton";
            this.dayButton.Size = new System.Drawing.Size(90, 23);
            this.dayButton.TabIndex = 1;
            this.dayButton.Text = "Update Day";
            this.dayButton.UseVisualStyleBackColor = true;
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(185, 141);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(90, 23);
            this.yearButton.TabIndex = 2;
            this.yearButton.Text = "Update Year";
            this.yearButton.UseVisualStyleBackColor = true;
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(76, 34);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(33, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(30, 73);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(43, 13);
            this.monthLabel.TabIndex = 4;
            this.monthLabel.Text = "Month :";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(30, 111);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(32, 13);
            this.dayLabel.TabIndex = 5;
            this.dayLabel.Text = "Day :";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(30, 147);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(35, 13);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year :";
            // 
            // dateOutputTxt
            // 
            this.dateOutputTxt.Location = new System.Drawing.Point(115, 31);
            this.dateOutputTxt.Name = "dateOutputTxt";
            this.dateOutputTxt.ReadOnly = true;
            this.dateOutputTxt.Size = new System.Drawing.Size(100, 20);
            this.dateOutputTxt.TabIndex = 7;
            // 
            // monthInputTxt
            // 
            this.monthInputTxt.Location = new System.Drawing.Point(79, 70);
            this.monthInputTxt.Name = "monthInputTxt";
            this.monthInputTxt.Size = new System.Drawing.Size(100, 20);
            this.monthInputTxt.TabIndex = 8;
            // 
            // dayInputTxt
            // 
            this.dayInputTxt.Location = new System.Drawing.Point(79, 108);
            this.dayInputTxt.Name = "dayInputTxt";
            this.dayInputTxt.Size = new System.Drawing.Size(100, 20);
            this.dayInputTxt.TabIndex = 9;
            // 
            // yearInputTxt
            // 
            this.yearInputTxt.Location = new System.Drawing.Point(79, 144);
            this.yearInputTxt.Name = "yearInputTxt";
            this.yearInputTxt.Size = new System.Drawing.Size(100, 20);
            this.yearInputTxt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 182);
            this.Controls.Add(this.yearInputTxt);
            this.Controls.Add(this.dayInputTxt);
            this.Controls.Add(this.monthInputTxt);
            this.Controls.Add(this.dateOutputTxt);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.dayButton);
            this.Controls.Add(this.monthButton);
            this.Name = "Form1";
            this.Text = "Lab 9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthButton;
        private System.Windows.Forms.Button dayButton;
        private System.Windows.Forms.Button yearButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox dateOutputTxt;
        private System.Windows.Forms.TextBox monthInputTxt;
        private System.Windows.Forms.TextBox dayInputTxt;
        private System.Windows.Forms.TextBox yearInputTxt;
    }
}

