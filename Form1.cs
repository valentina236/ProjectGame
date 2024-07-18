using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab10
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        string name;

        private int totalTime = 60;
        private int currentTime;

        private int correctAnswersCount = 0;
        private int incorrectAnswersCount = 0;

        private Dictionary<string, string> fruitsDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> clothesDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> furnitureDictionary = new Dictionary<string, string>();
        private Dictionary<string, string> allItemsDictionary = new Dictionary<string, string>();

        private Dictionary<string, string> currentDictionary;

        List<PlayerData> playerDatas = new List<PlayerData>();

        public Form1()
        {
            InitializeComponent();
            NameGamer f = new NameGamer();
            f.ShowDialog();
            name = f.Nume;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

            // create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // bottom-left corner

            // create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
            InitializeDictionaries();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
                }
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeDictionaries()
        {
            fruitsDictionary.Add(@"..\..\fruits\apple.png", "apple");
            fruitsDictionary.Add(@"..\..\fruits\apricot.png", "apricot");
            fruitsDictionary.Add(@"..\..\fruits\banana.png", "banana");
            fruitsDictionary.Add(@"..\..\fruits\cherry.png", "cherry");
            fruitsDictionary.Add(@"..\..\fruits\grapes.png", "grapes");
            fruitsDictionary.Add(@"..\..\fruits\kiwi.png", "kiwi");
            fruitsDictionary.Add(@"..\..\fruits\lemon.png", "lemon");
            fruitsDictionary.Add(@"..\..\fruits\lime.png", "lime");
            fruitsDictionary.Add(@"..\..\fruits\melon.png", "melon");
            fruitsDictionary.Add(@"..\..\fruits\orange.png", "orange");
            fruitsDictionary.Add(@"..\..\fruits\peach.png", "peach");
            fruitsDictionary.Add(@"..\..\fruits\pear.png", "pear");
            fruitsDictionary.Add(@"..\..\fruits\pineapple.png", "pineapple");
            fruitsDictionary.Add(@"..\..\fruits\plum.png", "plum");
            fruitsDictionary.Add(@"..\..\fruits\watermelon.png", "watermelon");

            
            clothesDictionary.Add(@"..\..\clothes\cap.png", "cap");
            clothesDictionary.Add(@"..\..\clothes\cardigan.png", "cardigan");
            clothesDictionary.Add(@"..\..\clothes\dress.png", "dress");
            clothesDictionary.Add(@"..\..\clothes\hoodie.png", "hoodie");
            clothesDictionary.Add(@"..\..\clothes\jacket.png", "jacket");
            clothesDictionary.Add(@"..\..\clothes\jeans.png", "jeans");
            clothesDictionary.Add(@"..\..\clothes\overcoat.png", "overcoat");
            clothesDictionary.Add(@"..\..\clothes\pajamas.png", "pajamas");
            clothesDictionary.Add(@"..\..\clothes\shirt.png", "shirt");
            clothesDictionary.Add(@"..\..\clothes\shorts.png", "shorts");
            clothesDictionary.Add(@"..\..\clothes\skirt.png", "skirt");
            clothesDictionary.Add(@"..\..\clothes\socks.png", "socks");
            clothesDictionary.Add(@"..\..\clothes\t-shirt.png", "t-shirt");


            furnitureDictionary.Add(@"..\..\furniture\armchair.png", "armchair");
            furnitureDictionary.Add(@"..\..\furniture\bed.png", "bed");
            furnitureDictionary.Add(@"..\..\furniture\carpet.png", "carpet");
            furnitureDictionary.Add(@"..\..\furniture\chair.png", "chair");
            furnitureDictionary.Add(@"..\..\furniture\cupboard.png", "cupboard");
            furnitureDictionary.Add(@"..\..\furniture\floor-lamp.png", "floor lamp");
            furnitureDictionary.Add(@"..\..\furniture\sofa.png", "sofa");
            furnitureDictionary.Add(@"..\..\furniture\table.png", "table");
            furnitureDictionary.Add(@"..\..\furniture\wardrobe.png", "wardrobe");
            furnitureDictionary.Add(@"..\..\furniture\desk.png", "desk");
        }

        private void InitializeAllItemsDictionary()
        {
            allItemsDictionary.Clear();
            foreach (var pair in fruitsDictionary)
            {
                allItemsDictionary.Add(pair.Key, pair.Value);
            }
            foreach (var pair in clothesDictionary)
            {
                allItemsDictionary.Add(pair.Key, pair.Value);
            }
            foreach (var pair in furnitureDictionary)
            {
                allItemsDictionary.Add(pair.Key, pair.Value);
            }
        }

        private void toolStripButtonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Просматривайте изображения и вводите название объекта на английском языке.\n2. Для начала игры выберите категорию в меню настроек и нажмите кнопку 'Начать'.",
                "Правила игры", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            string selectedCategory = clickedItem.Text;

            switch (selectedCategory)
            {
                case "Фрукты":
                    currentDictionary = fruitsDictionary;
                    break;
                case "Одежда":
                    currentDictionary = clothesDictionary;
                    break;
                case "Мебель":
                    currentDictionary = furnitureDictionary;
                    break;
                case "Все":
                    InitializeAllItemsDictionary();
                    currentDictionary = allItemsDictionary;
                    break;
            }
            toolStripButtonStart.Enabled = true;
        }

        private void DisplayRandomImage()
        {
            if (currentDictionary == null || currentDictionary.Count == 0)
            {
                MessageBox.Show("Выберите категорию изображений.");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(currentDictionary.Count);
            string randomImagePath = currentDictionary.ElementAt(randomIndex).Key;
            pictureBox1.Image = Image.FromFile(randomImagePath);
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e)
        {
            currentTime = totalTime;
            timer.Start();
            DisplayRandomImage();
            labelSeconds.Text = $"Осталось времени: {currentTime} сек";
            toolStripButtonStop.Enabled = true;
            toolStripButtonSave.Enabled = true;
            TextBoxAnswer.Visible = true;
            ButtonAnswer.Visible = true;
            labelSeconds.Visible = true;
            ProgressBar.Visible = true;
            correctAnswersCount = 0;
            incorrectAnswersCount = 0;
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            toolStripButtonStop.Enabled = false;
            TextBoxAnswer.Clear();
            TextBoxAnswer.Visible = false;
            ButtonAnswer.Visible = false;
            labelSeconds.Visible = false;
            labelResult.Visible = false;
            ProgressBar.Visible = false;
            toolStripButtonStart.Enabled = false;
            labelCorrectAnswers.Visible = false;
            labelIncorrectAnswers.Visible = false;
            pictureBox1.Image = null;
            MessageBox.Show($"Правильных ответов: {correctAnswersCount}\nНеправильных ответов: {incorrectAnswersCount}",
                             "Игра остановлена", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTime--;

            ProgressBar.Value = totalTime - currentTime;
            labelSeconds.Text = $"Осталось времени: {currentTime} сек";

            if (currentTime <= 0)
            {
                timer.Stop();
                toolStripButtonStop.Enabled = false;
                TextBoxAnswer.Clear();
                TextBoxAnswer.Visible = false;
                ButtonAnswer.Visible = false;
                labelSeconds.Visible = false;
                labelResult.Visible = false;
                ProgressBar.Visible = false;
                toolStripButtonStart.Enabled = false;
                labelCorrectAnswers.Visible = false;
                labelIncorrectAnswers.Visible = false;
                pictureBox1.Image = null;
                MessageBox.Show($"Время истекло!\nПравильных ответов: {correctAnswersCount}\nНеправильных ответов: {incorrectAnswersCount}", "Игра окончена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonAnswer_Click(object sender, EventArgs e)
        {
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            string userAnswer = TextBoxAnswer.Texts.Trim().ToLower();

            string correctAnswer = currentDictionary.FirstOrDefault(x => x.Value == userAnswer).Key;

            if (!string.IsNullOrEmpty(correctAnswer))
            {
                correctAnswersCount++;
                DisplayRandomImage();
                TextBoxAnswer.Clear();
                labelResult.Visible = false;
            }
            else
            {
                incorrectAnswersCount++;
                labelResult.Text = "Неверный ответ!";
                labelResult.Visible = true;
                TextBoxAnswer.Clear();
                DisplayRandomImage();
            }
            UpdateStatisticsLabels();
        }

        private void UpdateStatisticsLabels()
        {
            labelCorrectAnswers.Text = $"Правильных ответов: {correctAnswersCount}";
            labelIncorrectAnswers.Text = $"Неправильных ответов: {incorrectAnswersCount}";
            labelCorrectAnswers.Visible = true;
            labelIncorrectAnswers.Visible = true;
        }

        private void TextBoxAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CheckAnswer();
                e.Handled = true;
            }

            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string file = @"..\..\DataOfGamers.txt";
                DateTime startTime = DateTime.Now;
                using (StreamWriter writer = new StreamWriter(file, true))
                {
                    writer.WriteLine($"{DateTime.Now},{name},{correctAnswersCount},{incorrectAnswersCount}");
                    writer.Close();
                }
                MessageBox.Show("Данные успешно сохранены в файле.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                correctAnswersCount = 0;
                incorrectAnswersCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении в файл: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonDiagram_Click(object sender, EventArgs e)
        {
            string file = @"..\..\DataOfGamers.txt";
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string line;
                    string[] ar = new string[355];

                    while ((line = sr.ReadLine()) != null)
                    {
                        ar = line.Split(',');
                        playerDatas.Add(new PlayerData()
                        {
                            DateTime = DateTime.Parse(ar[0]),
                            PlayerName = ar[1],
                            CorrectAnswers = Convert.ToInt32(ar[2]),
                            IncorrectAnswers = Convert.ToInt32(ar[3])
                        });
                    }
                    sr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Cannot open a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Diagrama f = new Diagrama(playerDatas);
            f.ShowDialog();
        }
    }
}