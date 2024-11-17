namespace SPHWModulThreeCastOne
{
    partial class TaskThree
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
            txtLimit = new TextBox();
            progressBar = new ProgressBar();
            btnCalculate = new Button();
            lstResults = new ListBox();
            SuspendLayout();
            // 
            // txtLimit
            // 
            txtLimit.Location = new Point(12, 12);
            txtLimit.Multiline = true;
            txtLimit.Name = "txtLimit";
            txtLimit.Size = new Size(228, 37);
            txtLimit.TabIndex = 0;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 248);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(534, 23);
            progressBar.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(13, 55);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(227, 23);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "button1";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lstResults
            // 
            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(561, 12);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(227, 424);
            lstResults.TabIndex = 3;
            // 
            // TaskThree
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstResults);
            Controls.Add(btnCalculate);
            Controls.Add(progressBar);
            Controls.Add(txtLimit);
            Name = "TaskThree";
            Text = "TaskThree";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLimit;
        private ProgressBar progressBar;
        private Button btnCalculate;
        private ListBox lstResults;
    }
}