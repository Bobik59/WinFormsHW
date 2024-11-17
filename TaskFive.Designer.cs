namespace SPHWModulThreeCastOne
{
    partial class TaskFive
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
            txtWord = new TextBox();
            txtDirectory = new TextBox();
            listBoxResults = new ListBox();
            button1 = new Button();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // txtWord
            // 
            txtWord.Location = new Point(12, 12);
            txtWord.Multiline = true;
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(269, 27);
            txtWord.TabIndex = 0;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new Point(12, 45);
            txtDirectory.Multiline = true;
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(269, 27);
            txtDirectory.TabIndex = 1;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(12, 78);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(269, 364);
            listBoxResults.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(287, 12);
            button1.Name = "button1";
            button1.Size = new Size(177, 27);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSearch_Click;
            // 
            // button2
            // 
            button2.Location = new Point(287, 45);
            button2.Name = "button2";
            button2.Size = new Size(177, 27);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSelectDirectory_Click;
            // 
            // TaskFive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBoxResults);
            Controls.Add(txtDirectory);
            Controls.Add(txtWord);
            Name = "TaskFive";
            Text = "TaskFive";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWord;
        private TextBox txtDirectory;
        private ListBox listBoxResults;
        private Button button1;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}