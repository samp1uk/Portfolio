namespace Prog2
{
    partial class AddressForm
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
            this.zipErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cityErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cancelAddressButton = new System.Windows.Forms.Button();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateCombo = new System.Windows.Forms.ComboBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address1Label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.stateErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.address2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zipErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // zipErrorProvider
            // 
            this.zipErrorProvider.ContainerControl = this;
            // 
            // cityErrorProvider
            // 
            this.cityErrorProvider.ContainerControl = this;
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // cancelAddressButton
            // 
            this.cancelAddressButton.Location = new System.Drawing.Point(203, 334);
            this.cancelAddressButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelAddressButton.Name = "cancelAddressButton";
            this.cancelAddressButton.Size = new System.Drawing.Size(106, 26);
            this.cancelAddressButton.TabIndex = 25;
            this.cancelAddressButton.Text = "Cancel";
            this.cancelAddressButton.UseVisualStyleBackColor = true;
            this.cancelAddressButton.Click += new System.EventHandler(this.cancelAddressButton_Click);
            // 
            // addAddressButton
            // 
            this.addAddressButton.Location = new System.Drawing.Point(22, 334);
            this.addAddressButton.Margin = new System.Windows.Forms.Padding(1);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(144, 27);
            this.addAddressButton.TabIndex = 24;
            this.addAddressButton.Text = "Add Address";
            this.addAddressButton.UseVisualStyleBackColor = true;
            this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(110, 269);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(108, 22);
            this.zipTextBox.TabIndex = 23;
            this.zipTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTextBox_Validating);
            this.zipTextBox.Validated += new System.EventHandler(this.zipTextBox_Validated);
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(22, 269);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(69, 17);
            this.zipLabel.TabIndex = 22;
            this.zipLabel.Text = "Zip Code:";
            // 
            // stateCombo
            // 
            this.stateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCombo.FormattingEnabled = true;
            this.stateCombo.Location = new System.Drawing.Point(110, 227);
            this.stateCombo.Margin = new System.Windows.Forms.Padding(1);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(73, 24);
            this.stateCombo.TabIndex = 21;
            this.stateCombo.Validating += new System.ComponentModel.CancelEventHandler(this.stateCombo_Validating);
            this.stateCombo.Validated += new System.EventHandler(this.stateCombo_Validated);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(46, 227);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 20;
            this.stateLabel.Text = "State:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(110, 174);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(199, 22);
            this.cityTextBox.TabIndex = 19;
            this.cityTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTextBox_Validating);
            this.cityTextBox.Validated += new System.EventHandler(this.cityTextBox_Validated);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(56, 174);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 18;
            this.cityLabel.Text = "City:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(110, 131);
            this.address2TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(199, 22);
            this.address2TextBox.TabIndex = 17;
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(110, 85);
            this.address1TextBox.Margin = new System.Windows.Forms.Padding(1);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(199, 22);
            this.address1TextBox.TabIndex = 16;
            this.address1TextBox.Validating += new System.ComponentModel.CancelEventHandler(this.address1TextBox_Validating);
            this.address1TextBox.Validated += new System.EventHandler(this.address1TextBox_Validated);
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(19, 85);
            this.address1Label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(72, 17);
            this.address1Label.TabIndex = 15;
            this.address1Label.Text = "Address1:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Location = new System.Drawing.Point(110, 44);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 22);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            this.nameTextBox.Validated += new System.EventHandler(this.nameTextBox_Validated);
            // 
            // stateErrorProvider
            // 
            this.stateErrorProvider.ContainerControl = this;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(42, 44);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name:";
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(19, 131);
            this.address2Label.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(72, 17);
            this.address2Label.TabIndex = 15;
            this.address2Label.Text = "Address2:";
            // 
            // AddressForm
            // 
            this.AcceptButton = this.addAddressButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 392);
            this.Controls.Add(this.cancelAddressButton);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateCombo);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddressForm";
            this.Load += new System.EventHandler(this.AddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zipErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider zipErrorProvider;
        private System.Windows.Forms.Button cancelAddressButton;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.ComboBox stateCombo;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ErrorProvider cityErrorProvider;
        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider stateErrorProvider;
        private System.Windows.Forms.Label address2Label;
    }
}