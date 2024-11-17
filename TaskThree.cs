using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SPHWModulThreeCastOne
{
    public partial class TaskThree : Form
    {
        public TaskThree()
        {
            InitializeComponent();
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLimit.Text, out int limit) || limit < 0)
            {
                MessageBox.Show("Введите корректное положительное число.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnCalculate.Enabled = false;
            progressBar.Value = 0;

            lstResults.Items.Clear();

            try
            {
                var results = await Task.Run(() => CalculateFibonacci(limit));
                foreach (var number in results)
                {
                    lstResults.Items.Add(number);
                }
                progressBar.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnCalculate.Enabled = true;
            }
        }

        private List<long> CalculateFibonacci(int limit)
        {
            var fibNumbers = new List<long> { 0, 1 };
            while (true)
            {
                var next = fibNumbers[^1] + fibNumbers[^2];
                if (next > limit) break;
                fibNumbers.Add(next);
            }
            return fibNumbers;
        }
    }
}