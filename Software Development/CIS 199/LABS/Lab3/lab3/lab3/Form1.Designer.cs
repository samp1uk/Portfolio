namespace lab3
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
            this.toppicture = new System.Windows.Forms.PictureBox();
            this.spherelabel = new System.Windows.Forms.Label();
            this.diameterlabel = new System.Windows.Forms.Label();
            this.arealabel = new System.Windows.Forms.Label();
            this.volumelabel = new System.Windows.Forms.Label();
            this.volumeoutput = new System.Windows.Forms.TextBox();
            this.areaoutput = new System.Windows.Forms.TextBox();
            this.diameteroutput = new System.Windows.Forms.TextBox();
            this.spherevalue = new System.Windows.Forms.TextBox();
            this.calbutton = new System.Windows.Forms.Button();
            this.botpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.botpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // toppicture
            // 
            this.toppicture.Image = ((System.Drawing.Image)(resources.GetObject("toppicture.Image")));
            this.toppicture.Location = new System.Drawing.Point(20, 21);
            this.toppicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toppicture.Name = "toppicture";
            this.toppicture.Size = new System.Drawing.Size(150, 150);
            this.toppicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toppicture.TabIndex = 0;
            this.toppicture.TabStop = false;
            // 
            // spherelabel
            // 
            this.spherelabel.AutoSize = true;
            this.spherelabel.Location = new System.Drawing.Point(181, 74);
            this.spherelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.spherelabel.Name = "spherelabel";
            this.spherelabel.Size = new System.Drawing.Size(90, 13);
            this.spherelabel.TabIndex = 1;
            this.spherelabel.Text = "Radius of sphere:";
            // 
            // diameterlabel
            // 
            this.diameterlabel.AutoSize = true;
            this.diameterlabel.Location = new System.Drawing.Point(37, 204);
            this.diameterlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diameterlabel.Name = "diameterlabel";
            this.diameterlabel.Size = new System.Drawing.Size(49, 13);
            this.diameterlabel.TabIndex = 2;
            this.diameterlabel.Text = "Diameter";
            // 
            // arealabel
            // 
            this.arealabel.AutoSize = true;
            this.arealabel.Location = new System.Drawing.Point(17, 250);
            this.arealabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.arealabel.Name = "arealabel";
            this.arealabel.Size = new System.Drawing.Size(69, 13);
            this.arealabel.TabIndex = 3;
            this.arealabel.Text = "Surface Area";
            // 
            // volumelabel
            // 
            this.volumelabel.AutoSize = true;
            this.volumelabel.Location = new System.Drawing.Point(45, 297);
            this.volumelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volumelabel.Name = "volumelabel";
            this.volumelabel.Size = new System.Drawing.Size(42, 13);
            this.volumelabel.TabIndex = 4;
            this.volumelabel.Text = "Volume";
            // 
            // volumeoutput
            // 
            this.volumeoutput.Location = new System.Drawing.Point(113, 295);
            this.volumeoutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.volumeoutput.Name = "volumeoutput";
            this.volumeoutput.ReadOnly = true;
            this.volumeoutput.Size = new System.Drawing.Size(76, 20);
            this.volumeoutput.TabIndex = 5;
            // 
            // areaoutput
            // 
            this.areaoutput.Location = new System.Drawing.Point(113, 250);
            this.areaoutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.areaoutput.Name = "areaoutput";
            this.areaoutput.ReadOnly = true;
            this.areaoutput.Size = new System.Drawing.Size(76, 20);
            this.areaoutput.TabIndex = 6;
            // 
            // diameteroutput
            // 
            this.diameteroutput.Location = new System.Drawing.Point(113, 200);
            this.diameteroutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.diameteroutput.Name = "diameteroutput";
            this.diameteroutput.ReadOnly = true;
            this.diameteroutput.Size = new System.Drawing.Size(76, 20);
            this.diameteroutput.TabIndex = 7;
            // 
            // spherevalue
            // 
            this.spherevalue.Location = new System.Drawing.Point(275, 74);
            this.spherevalue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spherevalue.Name = "spherevalue";
            this.spherevalue.Size = new System.Drawing.Size(76, 20);
            this.spherevalue.TabIndex = 8;
            // 
            // calbutton
            // 
            this.calbutton.Location = new System.Drawing.Point(275, 115);
            this.calbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calbutton.Name = "calbutton";
            this.calbutton.Size = new System.Drawing.Size(66, 30);
            this.calbutton.TabIndex = 9;
            this.calbutton.Text = "Calculate";
            this.calbutton.UseVisualStyleBackColor = true;
            this.calbutton.Click += new System.EventHandler(this.calbutton_Click);
            // 
            // botpicture
            // 
            this.botpicture.Image = ((System.Drawing.Image)(resources.GetObject("botpicture.Image")));
            this.botpicture.Location = new System.Drawing.Point(223, 191);
            this.botpicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botpicture.Name = "botpicture";
            this.botpicture.Size = new System.Drawing.Size(150, 150);
            this.botpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.botpicture.TabIndex = 10;
            this.botpicture.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.botpicture);
            this.Controls.Add(this.calbutton);
            this.Controls.Add(this.spherevalue);
            this.Controls.Add(this.diameteroutput);
            this.Controls.Add(this.areaoutput);
            this.Controls.Add(this.volumeoutput);
            this.Controls.Add(this.volumelabel);
            this.Controls.Add(this.arealabel);
            this.Controls.Add(this.diameterlabel);
            this.Controls.Add(this.spherelabel);
            this.Controls.Add(this.toppicture);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.toppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.botpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox toppicture;
        private System.Windows.Forms.Label spherelabel;
        private System.Windows.Forms.Label diameterlabel;
        private System.Windows.Forms.Label arealabel;
        private System.Windows.Forms.Label volumelabel;
        private System.Windows.Forms.TextBox volumeoutput;
        private System.Windows.Forms.TextBox areaoutput;
        private System.Windows.Forms.TextBox diameteroutput;
        private System.Windows.Forms.TextBox spherevalue;
        private System.Windows.Forms.Button calbutton;
        private System.Windows.Forms.PictureBox botpicture;
    }
}

