namespace Lab4
{
    partial class Lab4
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
            this.gpalabel = new System.Windows.Forms.Label();
            this.testlabel = new System.Windows.Forms.Label();
            this.gpatxt = new System.Windows.Forms.TextBox();
            this.testtxt = new System.Windows.Forms.TextBox();
            this.qualificationbutton = new System.Windows.Forms.Button();
            this.acceptlabel = new System.Windows.Forms.Label();
            this.rejectlabel = new System.Windows.Forms.Label();
            this.accepttxt = new System.Windows.Forms.TextBox();
            this.rejecttxt = new System.Windows.Forms.TextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Admissionslabel = new System.Windows.Forms.Label();
            this.Admissiontxt = new System.Windows.Forms.Label();
            this.Admissiontxt2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpalabel
            // 
            this.gpalabel.AutoSize = true;
            this.gpalabel.Location = new System.Drawing.Point(28, 39);
            this.gpalabel.Name = "gpalabel";
            this.gpalabel.Size = new System.Drawing.Size(82, 13);
            this.gpalabel.TabIndex = 0;
            this.gpalabel.Text = "Enter The GPA:";
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(28, 78);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(112, 13);
            this.testlabel.TabIndex = 1;
            this.testlabel.Text = "Enter The Test Score:";
            // 
            // gpatxt
            // 
            this.gpatxt.Location = new System.Drawing.Point(173, 32);
            this.gpatxt.Name = "gpatxt";
            this.gpatxt.Size = new System.Drawing.Size(100, 20);
            this.gpatxt.TabIndex = 2;
            // 
            // testtxt
            // 
            this.testtxt.Location = new System.Drawing.Point(174, 71);
            this.testtxt.Name = "testtxt";
            this.testtxt.Size = new System.Drawing.Size(100, 20);
            this.testtxt.TabIndex = 3;
            // 
            // qualificationbutton
            // 
            this.qualificationbutton.Location = new System.Drawing.Point(31, 112);
            this.qualificationbutton.Name = "qualificationbutton";
            this.qualificationbutton.Size = new System.Drawing.Size(172, 35);
            this.qualificationbutton.TabIndex = 4;
            this.qualificationbutton.Text = "Check Qualification";
            this.qualificationbutton.UseVisualStyleBackColor = true;
            this.qualificationbutton.Click += new System.EventHandler(this.qualificationbutton_Click);
            // 
            // acceptlabel
            // 
            this.acceptlabel.AutoSize = true;
            this.acceptlabel.Location = new System.Drawing.Point(28, 208);
            this.acceptlabel.Name = "acceptlabel";
            this.acceptlabel.Size = new System.Drawing.Size(183, 13);
            this.acceptlabel.TabIndex = 5;
            this.acceptlabel.Text = "Total Amout of Accepted Application:";
            // 
            // rejectlabel
            // 
            this.rejectlabel.AutoSize = true;
            this.rejectlabel.Location = new System.Drawing.Point(28, 254);
            this.rejectlabel.Name = "rejectlabel";
            this.rejectlabel.Size = new System.Drawing.Size(180, 13);
            this.rejectlabel.TabIndex = 6;
            this.rejectlabel.Text = "Total Amout of Rejected Application:";
            // 
            // accepttxt
            // 
            this.accepttxt.Location = new System.Drawing.Point(214, 208);
            this.accepttxt.Name = "accepttxt";
            this.accepttxt.ReadOnly = true;
            this.accepttxt.Size = new System.Drawing.Size(60, 20);
            this.accepttxt.TabIndex = 7;
            this.accepttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rejecttxt
            // 
            this.rejecttxt.Location = new System.Drawing.Point(214, 251);
            this.rejecttxt.Name = "rejecttxt";
            this.rejecttxt.ReadOnly = true;
            this.rejecttxt.Size = new System.Drawing.Size(60, 20);
            this.rejecttxt.TabIndex = 8;
            this.rejecttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Clearbutton
            // 
            this.Clearbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clearbutton.Location = new System.Drawing.Point(208, 112);
            this.Clearbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(65, 35);
            this.Clearbutton.TabIndex = 9;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Admissionslabel
            // 
            this.Admissionslabel.AutoSize = true;
            this.Admissionslabel.Location = new System.Drawing.Point(50, 169);
            this.Admissionslabel.Name = "Admissionslabel";
            this.Admissionslabel.Size = new System.Drawing.Size(90, 13);
            this.Admissionslabel.TabIndex = 10;
            this.Admissionslabel.Text = "Admission Status:";
            // 
            // Admissiontxt
            // 
            this.Admissiontxt.AutoSize = true;
            this.Admissiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admissiontxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Admissiontxt.Location = new System.Drawing.Point(203, 169);
            this.Admissiontxt.Name = "Admissiontxt";
            this.Admissiontxt.Size = new System.Drawing.Size(0, 13);
            this.Admissiontxt.TabIndex = 11;
            this.Admissiontxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admissiontxt2
            // 
            this.Admissiontxt2.AutoSize = true;
            this.Admissiontxt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admissiontxt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Admissiontxt2.Location = new System.Drawing.Point(203, 169);
            this.Admissiontxt2.Name = "Admissiontxt2";
            this.Admissiontxt2.Size = new System.Drawing.Size(0, 13);
            this.Admissiontxt2.TabIndex = 12;
            this.Admissiontxt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lab4
            // 
            this.AcceptButton = this.qualificationbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Clearbutton;
            this.ClientSize = new System.Drawing.Size(295, 307);
            this.Controls.Add(this.Admissiontxt2);
            this.Controls.Add(this.Admissiontxt);
            this.Controls.Add(this.Admissionslabel);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.rejecttxt);
            this.Controls.Add(this.accepttxt);
            this.Controls.Add(this.rejectlabel);
            this.Controls.Add(this.acceptlabel);
            this.Controls.Add(this.qualificationbutton);
            this.Controls.Add(this.testtxt);
            this.Controls.Add(this.gpatxt);
            this.Controls.Add(this.testlabel);
            this.Controls.Add(this.gpalabel);
            this.Name = "Lab4";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpalabel;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.TextBox gpatxt;
        private System.Windows.Forms.TextBox testtxt;
        private System.Windows.Forms.Button qualificationbutton;
        private System.Windows.Forms.Label acceptlabel;
        private System.Windows.Forms.Label rejectlabel;
        private System.Windows.Forms.TextBox accepttxt;
        private System.Windows.Forms.TextBox rejecttxt;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Label Admissionslabel;
        private System.Windows.Forms.Label Admissiontxt;
        private System.Windows.Forms.Label Admissiontxt2;
    }
}

