namespace Calculadora
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resultBotton = new System.Windows.Forms.Button();
            this.decimalButton = new System.Windows.Forms.Button();
            this.buttonNumber0 = new System.Windows.Forms.Button();
            this.signButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.buttonNumber3 = new System.Windows.Forms.Button();
            this.buttonNumber2 = new System.Windows.Forms.Button();
            this.buttonNumber1 = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.buttonNumber6 = new System.Windows.Forms.Button();
            this.buttonNumber5 = new System.Windows.Forms.Button();
            this.buttonNumber4 = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.buttonNumber9 = new System.Windows.Forms.Button();
            this.buttonNumber8 = new System.Windows.Forms.Button();
            this.buttonNumber7 = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.percentageButton = new System.Windows.Forms.Button();
            this.rootButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.numberDisplay = new System.Windows.Forms.TextBox();
            this.historyText = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.resultBotton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.decimalButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.signButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.plusButton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.minusButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.multiplicationButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNumber7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.divisionButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.percentageButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rootButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ceButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 75);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resultBotton
            // 
            this.resultBotton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resultBotton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBotton.Location = new System.Drawing.Point(219, 331);
            this.resultBotton.Name = "resultBotton";
            this.resultBotton.Size = new System.Drawing.Size(69, 77);
            this.resultBotton.TabIndex = 19;
            this.resultBotton.Text = "=";
            this.resultBotton.UseVisualStyleBackColor = true;
            this.resultBotton.Click += new System.EventHandler(this.resultBotton_Click);
            // 
            // decimalButton
            // 
            this.decimalButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalButton.Location = new System.Drawing.Point(147, 331);
            this.decimalButton.Name = "decimalButton";
            this.decimalButton.Size = new System.Drawing.Size(66, 77);
            this.decimalButton.TabIndex = 18;
            this.decimalButton.Text = ".";
            this.decimalButton.UseVisualStyleBackColor = true;
            this.decimalButton.Click += new System.EventHandler(this.decimalButton_Click);
            // 
            // buttonNumber0
            // 
            this.buttonNumber0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber0.Location = new System.Drawing.Point(75, 331);
            this.buttonNumber0.Name = "buttonNumber0";
            this.buttonNumber0.Size = new System.Drawing.Size(66, 77);
            this.buttonNumber0.TabIndex = 17;
            this.buttonNumber0.Text = "0";
            this.buttonNumber0.UseVisualStyleBackColor = true;
            this.buttonNumber0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // signButton
            // 
            this.signButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.signButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signButton.Location = new System.Drawing.Point(3, 331);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(66, 77);
            this.signButton.TabIndex = 16;
            this.signButton.Text = "+/-";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(219, 249);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(69, 76);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.mathOperatorButton_Click);
            // 
            // buttonNumber3
            // 
            this.buttonNumber3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber3.Location = new System.Drawing.Point(147, 249);
            this.buttonNumber3.Name = "buttonNumber3";
            this.buttonNumber3.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber3.TabIndex = 14;
            this.buttonNumber3.Text = "3";
            this.buttonNumber3.UseVisualStyleBackColor = true;
            this.buttonNumber3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber2
            // 
            this.buttonNumber2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber2.Location = new System.Drawing.Point(75, 249);
            this.buttonNumber2.Name = "buttonNumber2";
            this.buttonNumber2.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber2.TabIndex = 13;
            this.buttonNumber2.Text = "2";
            this.buttonNumber2.UseVisualStyleBackColor = true;
            this.buttonNumber2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber1
            // 
            this.buttonNumber1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber1.Location = new System.Drawing.Point(3, 249);
            this.buttonNumber1.Name = "buttonNumber1";
            this.buttonNumber1.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber1.TabIndex = 12;
            this.buttonNumber1.Text = "1";
            this.buttonNumber1.UseVisualStyleBackColor = true;
            this.buttonNumber1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // minusButton
            // 
            this.minusButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.minusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(219, 167);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(69, 76);
            this.minusButton.TabIndex = 11;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.mathOperatorButton_Click);
            // 
            // buttonNumber6
            // 
            this.buttonNumber6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber6.Location = new System.Drawing.Point(147, 167);
            this.buttonNumber6.Name = "buttonNumber6";
            this.buttonNumber6.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber6.TabIndex = 10;
            this.buttonNumber6.Text = "6";
            this.buttonNumber6.UseVisualStyleBackColor = true;
            this.buttonNumber6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber5
            // 
            this.buttonNumber5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber5.Location = new System.Drawing.Point(75, 167);
            this.buttonNumber5.Name = "buttonNumber5";
            this.buttonNumber5.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber5.TabIndex = 9;
            this.buttonNumber5.Text = "5";
            this.buttonNumber5.UseVisualStyleBackColor = true;
            this.buttonNumber5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber4
            // 
            this.buttonNumber4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber4.Location = new System.Drawing.Point(3, 167);
            this.buttonNumber4.Name = "buttonNumber4";
            this.buttonNumber4.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber4.TabIndex = 8;
            this.buttonNumber4.Text = "4";
            this.buttonNumber4.UseVisualStyleBackColor = true;
            this.buttonNumber4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.multiplicationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicationButton.Location = new System.Drawing.Point(219, 85);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(69, 76);
            this.multiplicationButton.TabIndex = 7;
            this.multiplicationButton.Text = "×";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.mathOperatorButton_Click);
            // 
            // buttonNumber9
            // 
            this.buttonNumber9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber9.Location = new System.Drawing.Point(147, 85);
            this.buttonNumber9.Name = "buttonNumber9";
            this.buttonNumber9.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber9.TabIndex = 6;
            this.buttonNumber9.Text = "9";
            this.buttonNumber9.UseVisualStyleBackColor = true;
            this.buttonNumber9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber8
            // 
            this.buttonNumber8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber8.Location = new System.Drawing.Point(75, 85);
            this.buttonNumber8.Name = "buttonNumber8";
            this.buttonNumber8.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber8.TabIndex = 5;
            this.buttonNumber8.Text = "8";
            this.buttonNumber8.UseVisualStyleBackColor = true;
            this.buttonNumber8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonNumber7
            // 
            this.buttonNumber7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNumber7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonNumber7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumber7.Location = new System.Drawing.Point(3, 85);
            this.buttonNumber7.Name = "buttonNumber7";
            this.buttonNumber7.Size = new System.Drawing.Size(66, 76);
            this.buttonNumber7.TabIndex = 4;
            this.buttonNumber7.Text = "7";
            this.buttonNumber7.UseVisualStyleBackColor = true;
            this.buttonNumber7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divisionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionButton.Location = new System.Drawing.Point(219, 3);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(69, 76);
            this.divisionButton.TabIndex = 3;
            this.divisionButton.Text = "÷";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.mathOperatorButton_Click);
            // 
            // percentageButton
            // 
            this.percentageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.percentageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percentageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageButton.Location = new System.Drawing.Point(147, 3);
            this.percentageButton.Name = "percentageButton";
            this.percentageButton.Size = new System.Drawing.Size(66, 76);
            this.percentageButton.TabIndex = 2;
            this.percentageButton.Text = "%";
            this.percentageButton.UseVisualStyleBackColor = true;
            this.percentageButton.Click += new System.EventHandler(this.percentageButton_Click);
            // 
            // rootButton
            // 
            this.rootButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rootButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rootButton.Location = new System.Drawing.Point(75, 3);
            this.rootButton.Name = "rootButton";
            this.rootButton.Size = new System.Drawing.Size(66, 76);
            this.rootButton.TabIndex = 1;
            this.rootButton.Text = "√";
            this.rootButton.UseVisualStyleBackColor = true;
            this.rootButton.Click += new System.EventHandler(this.rootButton_Click);
            // 
            // ceButton
            // 
            this.ceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceButton.Location = new System.Drawing.Point(3, 3);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(66, 76);
            this.ceButton.TabIndex = 0;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.ceButton_Click);
            // 
            // numberDisplay
            // 
            this.numberDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numberDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.numberDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberDisplay.Location = new System.Drawing.Point(12, 24);
            this.numberDisplay.MaxLength = 10;
            this.numberDisplay.Name = "numberDisplay";
            this.numberDisplay.ReadOnly = true;
            this.numberDisplay.Size = new System.Drawing.Size(285, 46);
            this.numberDisplay.TabIndex = 4;
            this.numberDisplay.Text = "0";
            this.numberDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // historyText
            // 
            this.historyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyText.Enabled = false;
            this.historyText.Location = new System.Drawing.Point(197, 5);
            this.historyText.Name = "historyText";
            this.historyText.ReadOnly = true;
            this.historyText.Size = new System.Drawing.Size(100, 13);
            this.historyText.TabIndex = 5;
            this.historyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.historyText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 497);
            this.Controls.Add(this.historyText);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.numberDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button resultBotton;
        private System.Windows.Forms.Button decimalButton;
        private System.Windows.Forms.Button buttonNumber0;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button buttonNumber3;
        private System.Windows.Forms.Button buttonNumber2;
        private System.Windows.Forms.Button buttonNumber1;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button buttonNumber6;
        private System.Windows.Forms.Button buttonNumber5;
        private System.Windows.Forms.Button buttonNumber4;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button buttonNumber9;
        private System.Windows.Forms.Button buttonNumber8;
        private System.Windows.Forms.Button buttonNumber7;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button percentageButton;
        private System.Windows.Forms.Button rootButton;
        private System.Windows.Forms.TextBox numberDisplay;
        private System.Windows.Forms.TextBox historyText;
    }
}

