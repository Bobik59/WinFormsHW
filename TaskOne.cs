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
    public class CustomProgressBar : ProgressBar
    {
        public Color BarColor { get; set; } = Color.Blue;

        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = e.ClipRectangle;

            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), rect);

            rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));
            e.Graphics.FillRectangle(new SolidBrush(this.BarColor), rect);

            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
        }
    }

    public partial class TaskOne : Form
    {
        private NumericUpDown numericUpDown;
        private Button startButton;
        private FlowLayoutPanel progressPanel;
        private List<(ProgressBar, int)> progressBars = new List<(ProgressBar, int)>();
        private Random random = new Random();

        public TaskOne()
        {
            this.Text = "Прогресс-бары с многопоточностью";
            this.Size = new Size(600, 400);

            numericUpDown = new NumericUpDown
            {
                Minimum = 1,
                Maximum = 20,
                Value = 5,
                Location = new Point(20, 20),
                Width = 100
            };
            this.Controls.Add(numericUpDown);

            startButton = new Button
            {
                Text = "Запустить",
                Location = new Point(140, 20),
                Width = 100
            };
            startButton.Click += StartButton_Click;
            this.Controls.Add(startButton);

            progressPanel = new FlowLayoutPanel
            {
                Location = new Point(20, 60),
                Size = new Size(540, 300),
                AutoScroll = true
            };
            this.Controls.Add(progressPanel);


            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            progressPanel.Controls.Clear();
            progressBars.Clear();

            int count = (int)numericUpDown.Value;
            for (int i = 0; i < count; i++)
            {
                var progressBar = new CustomProgressBar
                {
                    Minimum = 0,
                    Maximum = random.Next(50, 200),
                    Value = 0,
                    Width = 500,
                    Height = 20,
                    BarColor = GetRandomColor()
                };

                progressBars.Add((progressBar, progressBar.Maximum));
                progressPanel.Controls.Add(progressBar);
            }

            StartProgressBars();
        }

        private void StartProgressBars()
        {
            foreach (var (progressBar, max) in progressBars)
            {
                Task.Run(() =>
                {
                    while (progressBar.Value < max)
                    {
                        Thread.Sleep(random.Next(50, 200));
                        progressBar.Invoke(new Action(() =>
                        {
                            progressBar.Value = Math.Min(progressBar.Value + 1, max);
                        }));
                    }
                });
            }
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

    }
}
