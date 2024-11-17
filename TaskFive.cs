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
    public partial class TaskFive : Form
    {
        public TaskFive()
        {
            InitializeComponent();
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string wordToSearch = txtWord.Text;
            string directoryPath = txtDirectory.Text;

            if (string.IsNullOrEmpty(wordToSearch) || string.IsNullOrEmpty(directoryPath))
            {
                MessageBox.Show("Пожалуйста, укажите слово для поиска и директорию.");
                return;
            }

            listBoxResults.Items.Clear();
            await SearchWordInFilesAsync(wordToSearch, directoryPath);
        }

        private async Task SearchWordInFilesAsync(string word, string directoryPath)
        {
            try
            {
                var files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    await Task.Run(() =>
                    {
                        int count = CountWordInFile(word, file);
                        if (count > 0)
                        {
                            Invoke(new Action(() =>
                            {
                                listBoxResults.Items.Add($"Название файла: {Path.GetFileName(file)}");
                                listBoxResults.Items.Add($"Путь к файлу: {file}");
                                listBoxResults.Items.Add($"Количество вхождений слова: {count}");
                                listBoxResults.Items.Add("------------------------------------");
                            }));
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private int CountWordInFile(string word, string filePath)
        {
            int count = 0;
            try
            {
                var content = File.ReadAllText(filePath);
                count = content.Split(new[] { word }, StringSplitOptions.None).Length - 1;
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show($"Ошибка чтения файла {filePath}: {ex.Message}")));
            }
            return count;
        }

        private void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Выберите директорию для поиска";
                folderBrowserDialog.UseDescriptionForTitle = true;
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDirectory.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}