namespace SPHWModulThreeCastOne
{
    partial class TaskFour
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
            txtFilePath = new TextBox();
            txtWord = new TextBox();
            lblResult = new Label();
            button1 = new Button();
            openFileDialog = new OpenFileDialog();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 12);
            txtFilePath.Multiline = true;
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(296, 29);
            txtFilePath.TabIndex = 0;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(12, 47);
            txtWord.Multiline = true;
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(296, 29);
            txtWord.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 25F);
            lblResult.Location = new Point(12, 138);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(753, 44);
            lblResult.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(12, 82);
            button1.Name = "button1";
            button1.Size = new Size(77, 44);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnFind_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Location = new Point(218, 82);
            button2.Name = "button2";
            button2.Size = new Size(90, 44);
            button2.TabIndex = 4;
            button2.Text = "Puth";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnBrowse_Click;
            // 
            // TaskFour
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 201);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblResult);
            Controls.Add(txtWord);
            Controls.Add(txtFilePath);
            Name = "TaskFour";
            Text = "TaskFour";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private TextBox txtWord;
        private Label lblResult;
        private Button button1;
        private OpenFileDialog openFileDialog;
        private Button button2;
    }
}