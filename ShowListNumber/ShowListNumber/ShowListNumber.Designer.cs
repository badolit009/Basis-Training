namespace ShowListNumber
{
    partial class ShowListNumber
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
            this.addButton = new System.Windows.Forms.Button();
            this.itemnumberTextBox = new System.Windows.Forms.TextBox();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Number";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(211, 25);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemnumberTextBox
            // 
            this.itemnumberTextBox.Location = new System.Drawing.Point(85, 27);
            this.itemnumberTextBox.Name = "itemnumberTextBox";
            this.itemnumberTextBox.Size = new System.Drawing.Size(118, 20);
            this.itemnumberTextBox.TabIndex = 2;
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.Location = new System.Drawing.Point(15, 53);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(190, 108);
            this.showListBox.TabIndex = 3;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(211, 140);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(61, 21);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // ShowListNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.itemnumberTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "ShowListNumber";
            this.Text = "ShowItemNumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox itemnumberTextBox;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.Button showButton;
    }
}

