namespace SPHWModulThreeCastOne
{
    partial class TaskTwo
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
            listBoxResults = new ListBox();
            progressBar1 = new ProgressBar();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            progressBar4 = new ProgressBar();
            progressBar5 = new ProgressBar();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(515, 12);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(273, 424);
            listBoxResults.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(497, 23);
            progressBar1.TabIndex = 1;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(12, 41);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(497, 23);
            progressBar2.TabIndex = 2;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(12, 128);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(497, 23);
            progressBar3.TabIndex = 3;
            // 
            // progressBar4
            // 
            progressBar4.Location = new Point(12, 70);
            progressBar4.Name = "progressBar4";
            progressBar4.Size = new Size(497, 23);
            progressBar4.TabIndex = 3;
            // 
            // progressBar5
            // 
            progressBar5.Location = new Point(12, 99);
            progressBar5.Name = "progressBar5";
            progressBar5.Size = new Size(497, 23);
            progressBar5.TabIndex = 4;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 334);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(107, 48);
            buttonStart.TabIndex = 5;
            buttonStart.Text = "buttonStart";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // TaskTwo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStart);
            Controls.Add(progressBar5);
            Controls.Add(progressBar4);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(progressBar1);
            Controls.Add(listBoxResults);
            Name = "TaskTwo";
            Text = "TaskTwo";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResults;
        private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
        private ProgressBar progressBar4;
        private ProgressBar progressBar5;
        private Button buttonStart;
    }
}