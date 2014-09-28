namespace PlanetName
{
    partial class PlanetNameApp
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
            this.planetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PlanetComboBoxTextBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // planetButton
            // 
            this.planetButton.Location = new System.Drawing.Point(26, 98);
            this.planetButton.Name = "planetButton";
            this.planetButton.Size = new System.Drawing.Size(197, 31);
            this.planetButton.TabIndex = 0;
            this.planetButton.Text = "Show Planet Number";
            this.planetButton.UseVisualStyleBackColor = true;
            this.planetButton.Click += new System.EventHandler(this.planetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet";
            // 
            // PlanetComboBoxTextBox
            // 
            this.PlanetComboBoxTextBox.FormattingEnabled = true;
            this.PlanetComboBoxTextBox.Items.AddRange(new object[] {
            "Badol",
            "Foyez",
            "Moshiur",
            "Rocky"});
            this.PlanetComboBoxTextBox.Location = new System.Drawing.Point(77, 46);
            this.PlanetComboBoxTextBox.Name = "PlanetComboBoxTextBox";
            this.PlanetComboBoxTextBox.Size = new System.Drawing.Size(121, 21);
            this.PlanetComboBoxTextBox.TabIndex = 2;
            // 
            // PlanetNameApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 168);
            this.Controls.Add(this.PlanetComboBoxTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planetButton);
            this.Name = "PlanetNameApp";
            this.Text = "PlanetNameApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button planetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlanetComboBoxTextBox;
    }
}

