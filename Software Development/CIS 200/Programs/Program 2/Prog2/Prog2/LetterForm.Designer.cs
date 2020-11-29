namespace Prog2
{
    partial class LetterForm
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
            this.cancelLetterButton = new System.Windows.Forms.Button();
            this.addLetterButton = new System.Windows.Forms.Button();
            this.fixedCostTextBox = new System.Windows.Forms.TextBox();
            this.fixedCostLabel = new System.Windows.Forms.Label();
            this.destCombo = new System.Windows.Forms.ComboBox();
            this.originCombo = new System.Windows.Forms.ComboBox();
            this.destLabel = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.originErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.destErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.costErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.originErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelLetterButton
            // 
            this.cancelLetterButton.Location = new System.Drawing.Point(235, 203);
            this.cancelLetterButton.Margin = new System.Windows.Forms.Padding(1);
            this.cancelLetterButton.Name = "cancelLetterButton";
            this.cancelLetterButton.Size = new System.Drawing.Size(114, 28);
            this.cancelLetterButton.TabIndex = 15;
            this.cancelLetterButton.Text = "Cancel";
            this.cancelLetterButton.UseVisualStyleBackColor = true;
            this.cancelLetterButton.Click += new System.EventHandler(this.cancelLetterButton_Click);
            // 
            // addLetterButton
            // 
            this.addLetterButton.Location = new System.Drawing.Point(13, 203);
            this.addLetterButton.Margin = new System.Windows.Forms.Padding(1);
            this.addLetterButton.Name = "addLetterButton";
            this.addLetterButton.Size = new System.Drawing.Size(180, 28);
            this.addLetterButton.TabIndex = 14;
            this.addLetterButton.Text = "Add Letter";
            this.addLetterButton.UseVisualStyleBackColor = true;
            this.addLetterButton.Click += new System.EventHandler(this.addLetterButton_Click);
            // 
            // fixedCostTextBox
            // 
            this.fixedCostTextBox.Location = new System.Drawing.Point(190, 148);
            this.fixedCostTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.fixedCostTextBox.Name = "fixedCostTextBox";
            this.fixedCostTextBox.Size = new System.Drawing.Size(159, 22);
            this.fixedCostTextBox.TabIndex = 13;
            this.fixedCostTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTextBox_Validating);
            this.fixedCostTextBox.Validated += new System.EventHandler(this.fixedCostTextBox_Validated);
            // 
            // fixedCostLabel
            // 
            this.fixedCostLabel.AutoSize = true;
            this.fixedCostLabel.Location = new System.Drawing.Point(72, 148);
            this.fixedCostLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.fixedCostLabel.Name = "fixedCostLabel";
            this.fixedCostLabel.Size = new System.Drawing.Size(77, 17);
            this.fixedCostLabel.TabIndex = 12;
            this.fixedCostLabel.Text = "Fixed Cost:";
            // 
            // destCombo
            // 
            this.destCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destCombo.FormattingEnabled = true;
            this.destCombo.Location = new System.Drawing.Point(190, 86);
            this.destCombo.Margin = new System.Windows.Forms.Padding(1);
            this.destCombo.Name = "destCombo";
            this.destCombo.Size = new System.Drawing.Size(159, 24);
            this.destCombo.TabIndex = 11;
            this.destCombo.Validating += new System.ComponentModel.CancelEventHandler(this.destCombo_Validating);
            this.destCombo.Validated += new System.EventHandler(this.destCombo_Validated);
            // 
            // originCombo
            // 
            this.originCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originCombo.FormattingEnabled = true;
            this.originCombo.Location = new System.Drawing.Point(190, 36);
            this.originCombo.Margin = new System.Windows.Forms.Padding(1);
            this.originCombo.Name = "originCombo";
            this.originCombo.Size = new System.Drawing.Size(159, 24);
            this.originCombo.TabIndex = 10;
            this.originCombo.Validating += new System.ComponentModel.CancelEventHandler(this.originCombo_Validating);
            this.originCombo.Validated += new System.EventHandler(this.originCombo_Validated);
            // 
            // destLabel
            // 
            this.destLabel.AutoSize = true;
            this.destLabel.Location = new System.Drawing.Point(10, 89);
            this.destLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.destLabel.Name = "destLabel";
            this.destLabel.Size = new System.Drawing.Size(139, 17);
            this.destLabel.TabIndex = 9;
            this.destLabel.Text = "Destination Address:";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(43, 39);
            this.originLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(106, 17);
            this.originLabel.TabIndex = 8;
            this.originLabel.Text = "Origin Address:";
            // 
            // originErrorProvider
            // 
            this.originErrorProvider.ContainerControl = this;
            // 
            // destErrorProvider
            // 
            this.destErrorProvider.ContainerControl = this;
            // 
            // costErrorProvider
            // 
            this.costErrorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AcceptButton = this.addLetterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 260);
            this.Controls.Add(this.cancelLetterButton);
            this.Controls.Add(this.addLetterButton);
            this.Controls.Add(this.fixedCostTextBox);
            this.Controls.Add(this.fixedCostLabel);
            this.Controls.Add(this.destCombo);
            this.Controls.Add(this.originCombo);
            this.Controls.Add(this.destLabel);
            this.Controls.Add(this.originLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.originErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelLetterButton;
        private System.Windows.Forms.Button addLetterButton;
        private System.Windows.Forms.TextBox fixedCostTextBox;
        private System.Windows.Forms.Label fixedCostLabel;
        private System.Windows.Forms.ComboBox destCombo;
        private System.Windows.Forms.ComboBox originCombo;
        private System.Windows.Forms.Label destLabel;
        private System.Windows.Forms.Label originLabel;
        private System.Windows.Forms.ErrorProvider originErrorProvider;
        private System.Windows.Forms.ErrorProvider destErrorProvider;
        private System.Windows.Forms.ErrorProvider costErrorProvider;
    }
}