using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPHWModulThreeCastOne
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RunTask1_Click(object sender, EventArgs e)
        {
            TaskOne taskOne = new TaskOne();
            taskOne.Show();
        }

        private void TaskTwo_Click(object sender, EventArgs e)
        {
            TaskTwo taskTwo = new TaskTwo();
            taskTwo.Show();
        }

        private void TaskThree_Click(object sender, EventArgs e)
        {
            TaskThree taskTwo = new TaskThree();
            taskTwo.Show();
        }
        private void TaskFour_Click(object sender, EventArgs e)
        {
            TaskFour taskTwo = new TaskFour();
            taskTwo.Show();
        }

        private void TaskFive_Click(object sender, EventArgs e)
        {
            TaskFive taskTwo = new TaskFive();
            taskTwo.Show();
        }
    }
}
