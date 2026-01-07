namespace MyEpicBTCCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bitcoinAmountInput = new TextBox();
            btclabel = new Label();
            currencySelector = new ComboBox();
            toCurrencyLabel = new Label();
            getRate = new Button();
            bitcoinResultLabel = new Label();
            resultDisplayLabel = new Label();
            SuspendLayout();
            // 
            // bitcoinAmountInput
            // 
            bitcoinAmountInput.Location = new Point(44, 34);
            bitcoinAmountInput.Name = "bitcoinAmountInput";
            bitcoinAmountInput.Size = new Size(258, 23);
            bitcoinAmountInput.TabIndex = 0;
            bitcoinAmountInput.TextChanged += textBox1_TextChanged;
            // 
            // btclabel
            // 
            btclabel.AutoSize = true;
            btclabel.Location = new Point(44, 16);
            btclabel.Name = "btclabel";
            btclabel.Size = new Size(85, 15);
            btclabel.TabIndex = 1;
            btclabel.Text = "Bitcoini kogus:";
            // 
            // currencySelector
            // 
            currencySelector.AutoCompleteCustomSource.AddRange(new string[] { "EUR", "USD" });
            currencySelector.FormattingEnabled = true;
            currencySelector.Items.AddRange(new object[] { "USD", "EUR" });
            currencySelector.Location = new Point(44, 92);
            currencySelector.Name = "currencySelector";
            currencySelector.Size = new Size(258, 23);
            currencySelector.TabIndex = 2;
            currencySelector.Text = "USD";
            // 
            // toCurrencyLabel
            // 
            toCurrencyLabel.AutoSize = true;
            toCurrencyLabel.Location = new Point(44, 74);
            toCurrencyLabel.Name = "toCurrencyLabel";
            toCurrencyLabel.Size = new Size(69, 15);
            toCurrencyLabel.TabIndex = 3;
            toCurrencyLabel.Text = "Sihtvaluuta:";
            toCurrencyLabel.Click += label1_Click;
            // 
            // getRate
            // 
            getRate.Location = new Point(114, 139);
            getRate.Name = "getRate";
            getRate.Size = new Size(113, 34);
            getRate.TabIndex = 4;
            getRate.Text = "Arvuta";
            getRate.UseVisualStyleBackColor = true;
            getRate.Click += getRate_Click;
            // 
            // bitcoinResultLabel
            // 
            bitcoinResultLabel.AutoSize = true;
            bitcoinResultLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 186);
            bitcoinResultLabel.ForeColor = SystemColors.ControlText;
            bitcoinResultLabel.Location = new Point(12, 412);
            bitcoinResultLabel.Name = "bitcoinResultLabel";
            bitcoinResultLabel.Size = new Size(52, 21);
            bitcoinResultLabel.TabIndex = 5;
            bitcoinResultLabel.Text = "label1";
            bitcoinResultLabel.Click += BitcoinResultLabel_Click;
            // 
            // resultDisplayLabel
            // 
            resultDisplayLabel.AutoSize = true;
            resultDisplayLabel.Location = new Point(10, 379);
            resultDisplayLabel.Name = "resultDisplayLabel";
            resultDisplayLabel.Size = new Size(103, 15);
            resultDisplayLabel.TabIndex = 6;
            resultDisplayLabel.Text = "Arvutuse tulemus:";
            resultDisplayLabel.Click += dddd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(351, 450);
            Controls.Add(resultDisplayLabel);
            Controls.Add(bitcoinResultLabel);
            Controls.Add(getRate);
            Controls.Add(toCurrencyLabel);
            Controls.Add(currencySelector);
            Controls.Add(btclabel);
            Controls.Add(bitcoinAmountInput);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bitcoinAmountInput;
        private Label btclabel;
        private ComboBox currencySelector;
        private Label toCurrencyLabel;
        private Button getRate;
        private Label bitcoinResultLabel;
        private Label resultDisplayLabel;
    }
}
