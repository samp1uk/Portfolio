namespace guidemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tempf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tempinclabel = new System.Windows.Forms.Label();
            this.calbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entertempf";
            // 
            // tempf
            // 
            this.tempf.Location = new System.Drawing.Point(137, 13);
            this.tempf.Name = "tempf";
            this.tempf.Size = new System.Drawing.Size(100, 22);
            this.tempf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "TempC";
            // 
            // tempinclabel
            // 
            this.tempinclabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tempinclabel.Location = new System.Drawing.Point(137, 55);
            this.tempinclabel.Name = "tempinclabel";
            this.tempinclabel.Size = new System.Drawing.Size(100, 23);
            this.tempinclabel.TabIndex = 3;
            // 
            // calbutton
            // 
            this.calbutton.Location = new System.Drawing.Point(137, 151);
            this.calbutton.Name = "calbutton";
            this.calbutton.Size = new System.Drawing.Size(100, 30);
            this.calbutton.TabIndex = 4;
            this.calbutton.Text = "button1";
            this.calbutton.UseVisualStyleBackColor = true;
            this.calbutton.Click += new System.EventHandler(this.calbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calbutton);
            this.Controls.Add(this.tempinclabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temp Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempinclabel;
        private System.Windows.Forms.Button calbutton;
    }
}

