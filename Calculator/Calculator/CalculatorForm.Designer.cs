namespace Calculator
{
    partial class CalculatorForm
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
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(28, 27);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(246, 20);
            this.outputTextBox.TabIndex = 0;
            this.outputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(30, 61);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(95, 20);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(48, 100);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(41, 26);
            this.plusButton.TabIndex = 2;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.binaryOperationButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Location = new System.Drawing.Point(95, 100);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(41, 26);
            this.minusButton.TabIndex = 2;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.binaryOperationButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(142, 100);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(41, 26);
            this.multiplyButton.TabIndex = 2;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.binaryOperationButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(189, 100);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(41, 26);
            this.divideButton.TabIndex = 2;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.binaryOperationButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.Location = new System.Drawing.Point(142, 144);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(87, 26);
            this.sinButton.TabIndex = 3;
            this.sinButton.Text = "sin(x)";
            this.sinButton.UseVisualStyleBackColor = true;
            this.sinButton.Click += new System.EventHandler(this.unaryOperationButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(38, 144);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(87, 26);
            this.squareButton.TabIndex = 3;
            this.squareButton.Text = "x^2";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.Click += new System.EventHandler(this.unaryOperationButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(38, 187);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(87, 26);
            this.powerButton.TabIndex = 3;
            this.powerButton.Text = "x^n";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.binaryOperationButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(148, 190);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 22);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.unaryOperationButton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button resetButton;
    }
}

