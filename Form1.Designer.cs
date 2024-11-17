namespace SPHWModulThreeCastOne
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
            txtLowerBound = new TextBox();
            txtUpperBound = new TextBox();
            listBoxPrimes = new ListBox();
            listBoxFibonacci = new ListBox();
            btnStartPrimes = new Button();
            btnStopPrimes = new Button();
            btnPausePrimes = new Button();
            btnResumePrimes = new Button();
            btnStartFibonacci = new Button();
            btnStopFibonacci = new Button();
            btnPauseFibonacci = new Button();
            btnResumeFibonacci = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtLowerBound
            // 
            txtLowerBound.Location = new Point(12, 50);
            txtLowerBound.Multiline = true;
            txtLowerBound.Name = "txtLowerBound";
            txtLowerBound.Size = new Size(371, 32);
            txtLowerBound.TabIndex = 0;
            // 
            // txtUpperBound
            // 
            txtUpperBound.Location = new Point(12, 12);
            txtUpperBound.Multiline = true;
            txtUpperBound.Name = "txtUpperBound";
            txtUpperBound.Size = new Size(371, 32);
            txtUpperBound.TabIndex = 2;
            // 
            // listBoxPrimes
            // 
            listBoxPrimes.FormattingEnabled = true;
            listBoxPrimes.ItemHeight = 15;
            listBoxPrimes.Location = new Point(423, 12);
            listBoxPrimes.Name = "listBoxPrimes";
            listBoxPrimes.Size = new Size(218, 544);
            listBoxPrimes.TabIndex = 3;
            // 
            // listBoxFibonacci
            // 
            listBoxFibonacci.FormattingEnabled = true;
            listBoxFibonacci.ItemHeight = 15;
            listBoxFibonacci.Location = new Point(788, 12);
            listBoxFibonacci.Name = "listBoxFibonacci";
            listBoxFibonacci.Size = new Size(218, 544);
            listBoxFibonacci.TabIndex = 4;
            // 
            // btnStartPrimes
            // 
            btnStartPrimes.Location = new Point(12, 88);
            btnStartPrimes.Name = "btnStartPrimes";
            btnStartPrimes.Size = new Size(371, 23);
            btnStartPrimes.TabIndex = 5;
            btnStartPrimes.Text = "Старт простые числа";
            btnStartPrimes.UseVisualStyleBackColor = true;
            btnStartPrimes.Click += btnStartPrimes_Click;
            // 
            // btnStopPrimes
            // 
            btnStopPrimes.Location = new Point(12, 117);
            btnStopPrimes.Name = "btnStopPrimes";
            btnStopPrimes.Size = new Size(371, 23);
            btnStopPrimes.TabIndex = 6;
            btnStopPrimes.Text = "Остановить простые числа";
            btnStopPrimes.UseVisualStyleBackColor = true;
            btnStopPrimes.Click += btnStopPrimes_Click;
            // 
            // btnPausePrimes
            // 
            btnPausePrimes.Location = new Point(12, 146);
            btnPausePrimes.Name = "btnPausePrimes";
            btnPausePrimes.Size = new Size(371, 23);
            btnPausePrimes.TabIndex = 7;
            btnPausePrimes.Text = "Пауза простые числа";
            btnPausePrimes.UseVisualStyleBackColor = true;
            btnPausePrimes.Click += btnPausePrimes_Click;
            // 
            // btnResumePrimes
            // 
            btnResumePrimes.Location = new Point(12, 175);
            btnResumePrimes.Name = "btnResumePrimes";
            btnResumePrimes.Size = new Size(371, 23);
            btnResumePrimes.TabIndex = 8;
            btnResumePrimes.Text = "Возобновить простые числа";
            btnResumePrimes.UseVisualStyleBackColor = true;
            btnResumePrimes.Click += btnResumePrimes_Click;
            // 
            // btnStartFibonacci
            // 
            btnStartFibonacci.Location = new Point(1012, 12);
            btnStartFibonacci.Name = "btnStartFibonacci";
            btnStartFibonacci.Size = new Size(232, 32);
            btnStartFibonacci.TabIndex = 9;
            btnStartFibonacci.Text = "Старт Фибоначчи";
            btnStartFibonacci.UseVisualStyleBackColor = true;
            btnStartFibonacci.Click += btnStartFibonacci_Click;
            // 
            // btnStopFibonacci
            // 
            btnStopFibonacci.Location = new Point(1012, 50);
            btnStopFibonacci.Name = "btnStopFibonacci";
            btnStopFibonacci.Size = new Size(232, 32);
            btnStopFibonacci.TabIndex = 10;
            btnStopFibonacci.Text = "Остановить Фибоначчи";
            btnStopFibonacci.UseVisualStyleBackColor = true;
            btnStopFibonacci.Click += btnStopFibonacci_Click;
            // 
            // btnPauseFibonacci
            // 
            btnPauseFibonacci.Location = new Point(1012, 88);
            btnPauseFibonacci.Name = "btnPauseFibonacci";
            btnPauseFibonacci.Size = new Size(232, 32);
            btnPauseFibonacci.TabIndex = 10;
            btnPauseFibonacci.Text = "Пауза Фибоначчи";
            btnPauseFibonacci.UseVisualStyleBackColor = true;
            btnPauseFibonacci.Click += btnPauseFibonacci_Click;
            // 
            // btnResumeFibonacci
            // 
            btnResumeFibonacci.Location = new Point(1012, 126);
            btnResumeFibonacci.Name = "btnResumeFibonacci";
            btnResumeFibonacci.Size = new Size(232, 32);
            btnResumeFibonacci.TabIndex = 11;
            btnResumeFibonacci.Text = "Возобновить Фибоначчи";
            btnResumeFibonacci.UseVisualStyleBackColor = true;
            btnResumeFibonacci.Click += btnResumeFibonacci_Click;
            // 
            // button1
            // 
            button1.Location = new Point(647, 12);
            button1.Name = "button1";
            button1.Size = new Size(135, 23);
            button1.TabIndex = 12;
            button1.Text = "очистить list";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 566);
            Controls.Add(button1);
            Controls.Add(btnResumeFibonacci);
            Controls.Add(btnStopFibonacci);
            Controls.Add(btnPauseFibonacci);
            Controls.Add(btnStartFibonacci);
            Controls.Add(btnResumePrimes);
            Controls.Add(btnPausePrimes);
            Controls.Add(btnStopPrimes);
            Controls.Add(btnStartPrimes);
            Controls.Add(listBoxFibonacci);
            Controls.Add(listBoxPrimes);
            Controls.Add(txtUpperBound);
            Controls.Add(txtLowerBound);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLowerBound;
        private TextBox txtUpperBound;
        private ListBox listBoxPrimes;
        private ListBox listBoxFibonacci;
        private Button btnStartPrimes;
        private Button btnStopPrimes;
        private Button btnPausePrimes;
        private Button btnResumePrimes;
        private Button btnStartFibonacci;
        private Button btnStopFibonacci;
        private Button btnPauseFibonacci;
        private Button btnResumeFibonacci;
        private Button button1;
    }
}
