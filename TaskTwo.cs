using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgressBar = System.Windows.Forms.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SPHWModulThreeCastOne
{
    public partial class TaskTwo : Form
    {
        private readonly Random random = new Random();
        private bool raceStarted = false;
        public TaskTwo()
        {
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            if (raceStarted) return;
            raceStarted = true;
            listBoxResults.Items.Clear();
            ProgressBar[] horses = { progressBar1, progressBar2, progressBar3, progressBar4, progressBar5 };
            foreach (var horse in horses)
            {
                horse.Value = 0;
            }
            List<Task<(int horseIndex, int time)>> tasks = new List<Task<(int, int)>>();

            for (int i = 0; i < horses.Length; i++)
            {
                int index = i;
                tasks.Add(Task.Run(() => RunRace(horses[index], index)));
            }

            var results = await Task.WhenAll(tasks);
            raceStarted = false;

            Array.Sort(results, (x, y) => x.time.CompareTo(y.time));

            int place = 1;
            foreach (var result in results)
            {
                listBoxResults.Items.Add($"Место {place}: Лошадь {result.horseIndex + 1} — {result.time} мс");
                place++;
            }
        }

        private (int horseIndex, int time) RunRace(ProgressBar horse, int horseIndex)
        {
            int distance = 0;
            int timeElapsed = 0;

            while (distance < 100)
            {
                int step = random.Next(1, 5);
                Thread.Sleep(50);
                timeElapsed += 50;

                horse.Invoke(new Action(() =>
                {
                    horse.Value = Math.Min(horse.Value + step, 100);
                }));

                distance = horse.Value;
            }

            return (horseIndex, timeElapsed);
        }
    }
}