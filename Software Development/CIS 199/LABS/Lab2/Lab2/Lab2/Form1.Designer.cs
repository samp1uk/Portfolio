namespace Lab2
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
            this.Calculatebut = new System.Windows.Forms.Button();
            this.meallabel = new System.Windows.Forms.Label();
            this.fifteen = new System.Windows.Forms.Label();
            this.eighteenlabel = new System.Windows.Forms.Label();
            this.twentylabel = new System.Windows.Forms.Label();
            this.mealtext = new System.Windows.Forms.TextBox();
            this.fifteentext = new System.Windows.Forms.TextBox();
            this.eighteentext = new System.Windows.Forms.TextBox();
            this.twentytext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calculatebut
            // 
            this.Calculatebut.Location = new System.Drawing.Point(110, 183);
            this.Calculatebut.Name = "Calculatebut";
            this.Calculatebut.Size = new System.Drawing.Size(132, 34);
            this.Calculatebut.TabIndex = 0;
            this.Calculatebut.Text = "Calculate Tip";
            this.Calculatebut.UseVisualStyleBackColor = true;
            this.Calculatebut.Click += new System.EventHandler(this.button1_Click);
            // 
            // meallabel
            // 
            this.meallabel.AutoSize = true;
            this.meallabel.Location = new System.Drawing.Point(27, 33);
            this.meallabel.Name = "meallabel";
            this.meallabel.Size = new System.Drawing.Size(131, 17);
            this.meallabel.TabIndex = 1;
            this.meallabel.Text = "Enter price of meal:";
            // 
            // fifteen
            // 
            this.fifteen.AutoSize = true;
            this.fifteen.Location = new System.Drawing.Point(118, 73);
            this.fifteen.Name = "fifteen";
            this.fifteen.Size = new System.Drawing.Size(40, 17);
            this.fifteen.TabIndex = 2;
            this.fifteen.Text = "15 %";
            // 
            // eighteenlabel
            // 
            this.eighteenlabel.AutoSize = true;
            this.eighteenlabel.Location = new System.Drawing.Point(118, 105);
            this.eighteenlabel.Name = "eighteenlabel";
            this.eighteenlabel.Size = new System.Drawing.Size(40, 17);
            this.eighteenlabel.TabIndex = 3;
            this.eighteenlabel.Text = "18 %";
            // 
            // twentylabel
            // 
            this.twentylabel.AutoSize = true;
            this.twentylabel.Location = new System.Drawing.Point(118, 142);
            this.twentylabel.Name = "twentylabel";
            this.twentylabel.Size = new System.Drawing.Size(40, 17);
            this.twentylabel.TabIndex = 4;
            this.twentylabel.Text = "20 %";
            // 
            // mealtext
            // 
            this.mealtext.Location = new System.Drawing.Point(164, 33);
            this.mealtext.Name = "mealtext";
            this.mealtext.Size = new System.Drawing.Size(100, 22);
            this.mealtext.TabIndex = 5;
            // 
            // fifteentext
            // 
            this.fifteentext.Location = new System.Drawing.Point(164, 68);
            this.fifteentext.Name = "fifteentext";
            this.fifteentext.ReadOnly = true;
            this.fifteentext.Size = new System.Drawing.Size(100, 22);
            this.fifteentext.TabIndex = 6;
            // 
            // eighteentext
            // 
            this.eighteentext.Location = new System.Drawing.Point(164, 102);
            this.eighteentext.Name = "eighteentext";
            this.eighteentext.ReadOnly = true;
            this.eighteentext.Size = new System.Drawing.Size(100, 22);
            this.eighteentext.TabIndex = 7;
            // 
            // twentytext
            // 
            this.twentytext.Location = new System.Drawing.Point(164, 137);
            this.twentytext.Name = "twentytext";
            this.twentytext.ReadOnly = true;
            this.twentytext.Size = new System.Drawing.Size(100, 22);
            this.twentytext.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 244);
            this.Controls.Add(this.twentytext);
            this.Controls.Add(this.eighteentext);
            this.Controls.Add(this.fifteentext);
            this.Controls.Add(this.mealtext);
            this.Controls.Add(this.twentylabel);
            this.Controls.Add(this.eighteenlabel);
            this.Controls.Add(this.fifteen);
            this.Controls.Add(this.meallabel);
            this.Controls.Add(this.Calculatebut);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculatebut;
        private System.Windows.Forms.Label meallabel;
        private System.Windows.Forms.Label fifteen;
        private System.Windows.Forms.Label eighteenlabel;
        private System.Windows.Forms.Label twentylabel;
        private System.Windows.Forms.TextBox mealtext;
        private System.Windows.Forms.TextBox fifteentext;
        private System.Windows.Forms.TextBox eighteentext;
        private System.Windows.Forms.TextBox twentytext;
    }
}

