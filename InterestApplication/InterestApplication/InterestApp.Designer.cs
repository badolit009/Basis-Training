namespace InterestApplication
{
    partial class InterestApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.principalAmountTextBox = new System.Windows.Forms.TextBox();
            this.interestPercentTextBox = new System.Windows.Forms.TextBox();
            this.timePeriodTextBox = new System.Windows.Forms.TextBox();
            this.calculatorButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual Interest Rate(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Period(In Year)";
            // 
            // principalAmountTextBox
            // 
            this.principalAmountTextBox.Location = new System.Drawing.Point(134, 26);
            this.principalAmountTextBox.Name = "principalAmountTextBox";
            this.principalAmountTextBox.Size = new System.Drawing.Size(140, 20);
            this.principalAmountTextBox.TabIndex = 3;
            // 
            // interestPercentTextBox
            // 
            this.interestPercentTextBox.Location = new System.Drawing.Point(134, 62);
            this.interestPercentTextBox.Name = "interestPercentTextBox";
            this.interestPercentTextBox.Size = new System.Drawing.Size(140, 20);
            this.interestPercentTextBox.TabIndex = 4;
            // 
            // timePeriodTextBox
            // 
            this.timePeriodTextBox.Location = new System.Drawing.Point(134, 104);
            this.timePeriodTextBox.Name = "timePeriodTextBox";
            this.timePeriodTextBox.Size = new System.Drawing.Size(140, 20);
            this.timePeriodTextBox.TabIndex = 5;
            // 
            // calculatorButton
            // 
            this.calculatorButton.Location = new System.Drawing.Point(137, 149);
            this.calculatorButton.Name = "calculatorButton";
            this.calculatorButton.Size = new System.Drawing.Size(75, 23);
            this.calculatorButton.TabIndex = 6;
            this.calculatorButton.Text = "Calculate";
            this.calculatorButton.UseVisualStyleBackColor = true;
            this.calculatorButton.Click += new System.EventHandler(this.calculatorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Amount (Result)";
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(132, 206);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(140, 20);
            this.totalAmountTextBox.TabIndex = 8;
            // 
            // InterestApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculatorButton);
            this.Controls.Add(this.timePeriodTextBox);
            this.Controls.Add(this.interestPercentTextBox);
            this.Controls.Add(this.principalAmountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterestApp";
            this.Text = "InterestApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox principalAmountTextBox;
        private System.Windows.Forms.TextBox interestPercentTextBox;
        private System.Windows.Forms.TextBox timePeriodTextBox;
        private System.Windows.Forms.Button calculatorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox totalAmountTextBox;
    }
}

