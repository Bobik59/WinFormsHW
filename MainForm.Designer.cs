namespace SPHWModulThreeCastOne
{
    partial class MainForm
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
            RunTask1 = new Button();
            TaskTwo = new Button();
            TaskThree = new Button();
            TaskFour = new Button();
            TaskFive = new Button();
            SuspendLayout();
            // 
            // RunTask1
            // 
            RunTask1.Location = new Point(12, 12);
            RunTask1.Name = "RunTask1";
            RunTask1.Size = new Size(189, 40);
            RunTask1.TabIndex = 0;
            RunTask1.Text = "TaskOne";
            RunTask1.UseVisualStyleBackColor = true;
            RunTask1.Click += RunTask1_Click;
            // 
            // TaskTwo
            // 
            TaskTwo.Location = new Point(12, 58);
            TaskTwo.Name = "TaskTwo";
            TaskTwo.Size = new Size(189, 40);
            TaskTwo.TabIndex = 1;
            TaskTwo.Text = "TaskTwo";
            TaskTwo.UseVisualStyleBackColor = true;
            TaskTwo.Click += TaskTwo_Click;
            // 
            // TaskThree
            // 
            TaskThree.Location = new Point(12, 104);
            TaskThree.Name = "TaskThree";
            TaskThree.Size = new Size(189, 40);
            TaskThree.TabIndex = 2;
            TaskThree.Text = "TaskThree";
            TaskThree.UseVisualStyleBackColor = true;
            TaskThree.Click += TaskThree_Click;
            // 
            // TaskFour
            // 
            TaskFour.Location = new Point(12, 150);
            TaskFour.Name = "TaskFour";
            TaskFour.Size = new Size(189, 40);
            TaskFour.TabIndex = 3;
            TaskFour.Text = "TaskFour";
            TaskFour.UseVisualStyleBackColor = true;
            TaskFour.Click += TaskFour_Click;
            // 
            // TaskFive
            // 
            TaskFive.Location = new Point(12, 196);
            TaskFive.Name = "TaskFive";
            TaskFive.Size = new Size(189, 40);
            TaskFive.TabIndex = 4;
            TaskFive.Text = "TaskFive";
            TaskFive.UseVisualStyleBackColor = true;
            TaskFive.Click += TaskFive_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 450);
            Controls.Add(TaskFive);
            Controls.Add(TaskFour);
            Controls.Add(TaskThree);
            Controls.Add(TaskTwo);
            Controls.Add(RunTask1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button RunTask1;
        private Button TaskTwo;
        private Button TaskThree;
        private Button TaskFour;
        private Button TaskFive;
    }
}