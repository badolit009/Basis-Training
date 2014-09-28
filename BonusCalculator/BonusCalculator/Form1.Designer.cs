namespace BonusCalculator
{
    partial class BonusCulculator
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
            this.selaryTextBox = new System.Windows.Forms.TextBox();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary";
            // 
            // selaryTextBox
            // 
            this.selaryTextBox.Location = new System.Drawing.Point(93, 49);
            this.selaryTextBox.Name = "selaryTextBox";
            this.selaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.selaryTextBox.TabIndex = 1;
            // 
            // calculatorButton
            // 
            this.calculatorButton.Location = new System.Drawing.Point(93, 93);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(100, 29);
            this.calculatorButton.TabIndex = 2;
            this.calculatorButton.Text = "Calculator";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // BonusCulculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 135);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.selaryTextBox);
            this.Controls.Add(this.label1);
            this.Name = "BonusCulculator";
            this.Text = "BonusCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selaryTextBox;
        private System.Windows.Forms.Button calculatorButton;
    }
}

