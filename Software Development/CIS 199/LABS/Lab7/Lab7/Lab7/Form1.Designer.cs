namespace Lab7
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
            this.checkButton = new System.Windows.Forms.Button();
            this.wordLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.gradeTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(15, 133);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(298, 48);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(12, 33);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(196, 14);
            this.wordLabel.TabIndex = 1;
            this.wordLabel.Text = "Enter Your Nmber of Words Typed:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(73, 86);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(135, 24);
            this.gradeLabel.TabIndex = 2;
            this.gradeLabel.Text = "Your Grade :";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(221, 30);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(100, 20);
            this.inputTxt.TabIndex = 3;
            this.inputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gradeTxt
            // 
            this.gradeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeTxt.Location = new System.Drawing.Point(221, 91);
            this.gradeTxt.Name = "gradeTxt";
            this.gradeTxt.ReadOnly = true;
            this.gradeTxt.Size = new System.Drawing.Size(100, 20);
            this.gradeTxt.TabIndex = 4;
            this.gradeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AcceptButton = this.checkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 193);
            this.Controls.Add(this.gradeTxt);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Lab 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.TextBox gradeTxt;
    }
}

