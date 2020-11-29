namespace Prog3
{
    partial class SelectAddressForm
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
            this.components = new System.ComponentModel.Container();
            this.editAddressButton = new System.Windows.Forms.Button();
            this.editAddressCombo = new System.Windows.Forms.ComboBox();
            this.selectAddressLabel = new System.Windows.Forms.Label();
            this.editAddressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.editAddressErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // editAddressButton
            // 
            this.editAddressButton.Location = new System.Drawing.Point(9, 67);
            this.editAddressButton.Margin = new System.Windows.Forms.Padding(1);
            this.editAddressButton.Name = "editAddressButton";
            this.editAddressButton.Size = new System.Drawing.Size(138, 28);
            this.editAddressButton.TabIndex = 5;
            this.editAddressButton.Text = "Edit Address";
            this.editAddressButton.UseVisualStyleBackColor = true;
            this.editAddressButton.Click += new System.EventHandler(this.editAddressButton_Click);
            // 
            // editAddressCombo
            // 
            this.editAddressCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editAddressCombo.FormattingEnabled = true;
            this.editAddressCombo.Location = new System.Drawing.Point(149, 35);
            this.editAddressCombo.Margin = new System.Windows.Forms.Padding(1);
            this.editAddressCombo.Name = "editAddressCombo";
            this.editAddressCombo.Size = new System.Drawing.Size(142, 21);
            this.editAddressCombo.TabIndex = 4;
            this.editAddressCombo.Validating += new System.ComponentModel.CancelEventHandler(this.SelectAddressForm_Validating);
            this.editAddressCombo.Validated += new System.EventHandler(this.SelectAddressForm_Validated);
            // 
            // selectAddressLabel
            // 
            this.selectAddressLabel.AutoSize = true;
            this.selectAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAddressLabel.Location = new System.Drawing.Point(6, 36);
            this.selectAddressLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.selectAddressLabel.Name = "selectAddressLabel";
            this.selectAddressLabel.Size = new System.Drawing.Size(141, 16);
            this.selectAddressLabel.TabIndex = 3;
            this.selectAddressLabel.Text = "Select address to edit:";
            // 
            // editAddressErrorProvider
            // 
            this.editAddressErrorProvider.ContainerControl = this;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(208, 67);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(83, 28);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancelBtn_MouseDown);
            // 
            // SelectAddressForm
            // 
            this.AcceptButton = this.editAddressButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 108);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.editAddressButton);
            this.Controls.Add(this.editAddressCombo);
            this.Controls.Add(this.selectAddressLabel);
            this.Name = "SelectAddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit an Address";
            this.Load += new System.EventHandler(this.SelectAddressForm_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SelectAddressForm_Validating);
            this.Validated += new System.EventHandler(this.SelectAddressForm_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.editAddressErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editAddressButton;
        private System.Windows.Forms.ComboBox editAddressCombo;
        private System.Windows.Forms.Label selectAddressLabel;
        private System.Windows.Forms.ErrorProvider editAddressErrorProvider;
        private System.Windows.Forms.Button cancelBtn;
    }
}