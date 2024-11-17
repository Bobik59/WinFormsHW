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
    public partial class TaskFour : Form
    {
        public string SelectedFilePath { get; private set; }
        public TaskFour()
        {
            InitializeComponent();
        }
        private async void btnFind_Click(object sender, EventArgs e)
        {
            string filePath = txtFilePath.Text;
            string wordToFind = txtWord.Text;

            if (string.IsNullOrWhiteSpace(filePath) || string.IsNullOrWhiteSpace(wordToFind))
            {
                MessageBox.Show("Пожалуйста, укажите файл и слово для поиска.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл не найден. Проверьте путь.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                lblResult.Text = "Идет поиск...";
                int count = await CountWordOccurrencesAsync(filePath, wordToFind);
                lblResult.Text = $"Слово \"{wordToFind}\" встретилось {count} раз(а).";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при поиске: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<int> CountWordOccurrencesAsync(string filePath, string word)
        {
            return await Task.Run(() =>
            {
                int count = 0;
                string content = File.ReadAllText(filePath);
                int index = content.IndexOf(word, StringComparison.OrdinalIgnoreCase);

                while (index != -1)
                {
                    count++;
                    index = content.IndexOf(word, index + word.Length, StringComparison.OrdinalIgnoreCase);
                }

                return count;
            });
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }
    }
}