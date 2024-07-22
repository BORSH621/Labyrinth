using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace Labyrinth
{
    public partial class Game : Form
    {
        Thread th;

        //Добавление путей к изображениям
        string FirstFileName = System.IO.Path.Combine
            (Environment.CurrentDirectory,
            "FirstLevel.txt");
        string SecondFileName = System.IO.Path.Combine
            (Environment.CurrentDirectory, 
            "SecondLevel.txt");
        string ThirdFileName = System.IO.Path.Combine
            (Environment.CurrentDirectory, 
            "ThirdLevel.txt");
        string FourthFileName = System.IO.Path.Combine
            (Environment.CurrentDirectory,
            "FourthLevel.txt");
        string FivethFileName = System.IO.Path.Combine
            (Environment.CurrentDirectory,
            "FivethLevel.txt");
        string SixthFileName = System.IO.Path.Combine
            (Environment.CurrentDirectory,
            "SixthLevel.txt");

        DateTime date1 = new DateTime(0, 0);

        public Game()
        {
            InitializeComponent();
        }
        public void OpenMenu(object obj)
        {
            Application.Run(new Form1());
        }
        public void OpenGame(object obj)
        {
            Application.Run(new Game());
        }
        private void Game_Load(object sender, EventArgs e)
        {
            //Скрытие элементов
            Start.Hide();
            Finish.Hide();
            Next.Hide();
            Finish.Enabled = false;
            pictureBox1.Hide();
            label3.Hide();
            
            //скрытие рамки кнопки
            MainWall2.FlatAppearance.BorderSize = 0;
            MainWall2.FlatStyle = FlatStyle.Flat;

            //во пермя загрузки уровня,
            //выбирается нужная для него локация
            if (LevelSelect.Level == 1)
            {
                //Сощдание кнопок для стен лабиринта
                Button[] GameWall = new Button[16];
                var sr = new StreamReader(FirstFileName);

                //считывание с текстового файла
                //значений для создания стен лабиринта 
                for (int i = 1; i < 16; i++)
                {
                    string[] AllWord = sr.ReadLine().
                        Split(' ', '\t');
                    int[] text = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        text[j] = int.Parse(AllWord[j]);
                    }

                    //создание самих стен лабиринта
                    GameWall[i] = new Button();
                    GameWall[i].Location = new Point
                        (text[0] - 60, text[1] - 45);
                    GameWall[i].Size = new Size
                        (text[2], text[3]);
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].BackColor = 
                        Color.DarkGreen;
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].FlatStyle = FlatStyle.Flat;
                    Controls.Add(GameWall[i]);
                }

                //добавление конца лабиринта
                Finish.Location = new Point(320, 295);
                Finish.Size = new Size(50, 20);
                Finish.BackColor = Color.Orange;
                Finish.Text = "Конец";
                Finish.FlatAppearance.BorderSize = 0;
                Finish.FlatStyle = FlatStyle.Flat;
                Finish.Show();

                //добавление начала лабиринта
                Start.Location = new Point(40 - 30, 55);
                Start.Size = new Size(50, 20);
                Start.BackColor = Color.Orange;
                Start.Text = "Старт";
                Start.FlatAppearance.BorderSize = 0;
                Start.FlatStyle = FlatStyle.Flat;
                Start.Show();

                //постановка курсора на кнопку старт
                Cursor.Position = 
                    PointToScreen(Start.Location);

                //добавление изображений
                //в определенные стены при
                //соприкосновении с ними
                GameWall[9].MouseEnter += 
                    Game_MouseEnterFirst;
                GameWall[9].MouseLeave += 
                    Game_MouseLeave;
                GameWall[7].MouseEnter += 
                    Game_MouseEnterSecond;
                GameWall[7].MouseLeave += 
                    Game_MouseLeave;
            }
            else if(LevelSelect.Level == 2)
            {
                Button[] GameWall = new Button[16];
                var sr = new StreamReader(SecondFileName);
                for (int i = 1; i < 16; i++)
                {
                    string[] AllWord = sr.ReadLine().
                        Split(' ', '\t');
                    int[] text = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        text[j] = int.Parse(AllWord[j]);
                    }

                    GameWall[i] = new Button();
                    GameWall[i].Location = new Point
                        (text[0] - 60, text[1] - 45);
                    GameWall[i].Size = new Size
                        (text[2], text[3]);
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].BackColor = 
                        Color.DarkGreen;
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].FlatStyle = FlatStyle.Flat;
                    Controls.Add(GameWall[i]);
                }

                Finish.Location = new Point(320, 295);
                Finish.Size = new Size(50, 20);
                Finish.BackColor = Color.Orange;
                Finish.Text = "Конец";
                Finish.FlatAppearance.BorderSize = 0;
                Finish.FlatStyle = FlatStyle.Flat;
                Finish.Show();

                Start.Location = new Point(40 - 30, 55);
                Start.Size = new Size(50, 20);
                Start.BackColor = Color.Orange;
                Start.Text = "Старт";
                Start.FlatAppearance.BorderSize = 0;
                Start.FlatStyle = FlatStyle.Flat;
                Start.Show();

                Cursor.Position = 
                    PointToScreen(Start.Location);

                GameWall[9].MouseEnter +=
                    Game_MouseEnterFirst;
                GameWall[9].MouseLeave += 
                    Game_MouseLeave;
                GameWall[7].MouseEnter += 
                    Game_MouseEnterSecond;
                GameWall[7].MouseLeave += 
                    Game_MouseLeave;
            }
            else if (LevelSelect.Level == 3)
            {
                Button[] GameWall = new Button[29];
                var sr = new StreamReader(ThirdFileName);
                for (int i = 1; i < 29; i++)
                {
                    string[] AllWord = sr.ReadLine().
                        Split(' ', '\t');
                    int[] text = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        text[j] = int.Parse(AllWord[j]);
                    }

                    GameWall[i] = new Button();
                    GameWall[i].Location = new Point
                        (text[0] - 60, text[1] - 45);
                    GameWall[i].Size = new Size
                        (text[2], text[3]);
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].BackColor =
                        Color.CornflowerBlue;
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].FlatStyle = FlatStyle.Flat;
                    Controls.Add(GameWall[i]);
                }
                
                Finish.Location = new Point(320, 295);
                Finish.Size = new Size(50, 20);
                Finish.BackColor = Color.Orange;
                Finish.Text = "Конец";
                Finish.FlatAppearance.BorderSize = 0;
                Finish.FlatStyle = FlatStyle.Flat;
                Finish.Show();

                Start.Location = new Point(40 - 30, 55);
                Start.Size = new Size(50, 20);
                Start.BackColor = Color.Orange;
                Start.Text = "Старт";
                Start.FlatAppearance.BorderSize = 0;
                Start.FlatStyle = FlatStyle.Flat;
                Start.Show();

                Cursor.Position = PointToScreen
                    (Start.Location);

                //выбор случайной стены
                //в которой появится изображение
                Random rnd = new Random();
                int RandomIndex = rnd.Next(0,28);
                GameWall[RandomIndex].MouseEnter += 
                    Game_MouseEnterFirst;
                GameWall[RandomIndex].MouseLeave +=
                    Game_MouseLeave;
                RandomIndex = rnd.Next(0, 28);
                GameWall[RandomIndex].MouseEnter += 
                    Game_MouseEnterSecond;
                GameWall[RandomIndex].MouseLeave += 
                    Game_MouseLeave;
                RandomIndex = rnd.Next(0, 28);
                GameWall[RandomIndex].MouseEnter +=
                    Game_MouseEnterThird;
                GameWall[RandomIndex].MouseLeave += 
                    Game_MouseLeave;
            }
            else if (LevelSelect.Level == 4)
            {
                Button[] GameWall = new Button[24];
                var sr = new StreamReader(FourthFileName);
                for (int i = 1; i < 24; i++)
                {
                    string[] AllWord = sr.ReadLine().
                        Split(' ', '\t');
                    int[] text = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        text[j] = int.Parse(AllWord[j]);
                    }

                    GameWall[i] = new Button();
                    GameWall[i].Location = new Point
                        (text[0] - 60, text[1] - 45);
                    GameWall[i].Size = new Size
                        (text[2], text[3]);
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].BackColor = Color.
                        CornflowerBlue;
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].FlatStyle = FlatStyle.Flat;
                    Controls.Add(GameWall[i]);
                }

                Finish.Location = new Point(320, 295);
                Finish.Size = new Size(50, 20);
                Finish.BackColor = Color.Orange;
                Finish.Text = "Конец";
                Finish.FlatAppearance.BorderSize = 0;
                Finish.FlatStyle = FlatStyle.Flat;
                Finish.Show();

                Start.Location = new Point(40 - 30, 55);
                Start.Size = new Size(50, 20);
                Start.BackColor = Color.Orange;
                Start.Text = "Старт";
                Start.FlatAppearance.BorderSize = 0;
                Start.FlatStyle = FlatStyle.Flat;
                Start.Show();

                Cursor.Position = PointToScreen
                    (Start.Location);

                Random rnd = new Random();
                int RandomIndex = rnd.Next(0, 23);
                GameWall[RandomIndex].MouseEnter +=
                    Game_MouseEnterFirst;
                GameWall[RandomIndex].MouseLeave +=
                    Game_MouseLeave;
                RandomIndex = rnd.Next(0, 23);
                GameWall[RandomIndex].MouseEnter +=
                    Game_MouseEnterSecond;
                GameWall[RandomIndex].MouseLeave +=
                    Game_MouseLeave;
                RandomIndex = rnd.Next(0, 23);
                GameWall[RandomIndex].MouseEnter +=
                    Game_MouseEnterThird;
                GameWall[RandomIndex].MouseLeave +=
                    Game_MouseLeave;
                RandomIndex = rnd.Next(0, 23);
                GameWall[RandomIndex].MouseEnter +=
                    Game_MouseEnterFourth;
                GameWall[RandomIndex].MouseLeave +=
                    Game_MouseLeave;
            }
            else if (LevelSelect.Level == 5)
            {
                Button[] GameWall = new Button[49];
                var sr = new StreamReader(FivethFileName);
                for (int i = 1; i < 49; i++)
                {
                    string[] AllWord = sr.ReadLine().
                        Split(' ', '\t');
                    int[] text = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        text[j] = int.Parse(AllWord[j]);
                    }

                    GameWall[i] = new Button();
                    GameWall[i].Location = new Point
                        (text[0] - 60, text[1] - 55);
                    GameWall[i].Size = new Size
                        (text[2], text[3]);
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].BackColor = 
                        Color.DarkViolet;
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].FlatStyle = FlatStyle.Flat;
                    Controls.Add(GameWall[i]);
                }

                Finish.Location = new Point(340, 309);
                Finish.Size = new Size(50, 19);
                Finish.BackColor = Color.Orange;
                Finish.Text = "Конец";
                Finish.FlatAppearance.BorderSize = 0;
                Finish.FlatStyle = FlatStyle.Flat;
                Finish.Show();

                Start.Location = new Point(40 - 35, 39);
                Start.Size = new Size(50, 19);
                Start.BackColor = Color.Orange;
                Start.Text = "Старт";
                Start.FlatAppearance.BorderSize = 0;
                Start.FlatStyle = FlatStyle.Flat;
                Start.Show();

                Cursor.Position = PointToScreen
                    (Start.Location);

                Random rnd = new Random();
                
                for(int i = 0; i < 4; i++)
                {
                    int RandomIndex = rnd.Next(0, 48);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterFirst;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                    RandomIndex = rnd.Next(0, 48);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterSecond;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                    RandomIndex = rnd.Next(0, 48);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterThird;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                    RandomIndex = rnd.Next(0, 48);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterFourth;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                }
            }
            

            else if (LevelSelect.Level == 6)
            {
                Button[] GameWall = new Button[55];
                var sr = new StreamReader(SixthFileName);
                for (int i = 1; i < 55; i++)
                {
                    string[] AllWord = sr.ReadLine().
                        Split(' ', '\t');
                    int[] text = new int[4];

                    for (int j = 0; j < 4; j++)
                    {
                        text[j] = int.Parse(AllWord[j]);
                    }
                    
                    GameWall[i] = new Button();
                    GameWall[i].Location = new Point
                        (text[0] - 60, text[1] - 55);
                    GameWall[i].Size = new Size
                        (text[2], text[3]);
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].BackColor = 
                        Color.DarkViolet;
                    GameWall[i].FlatAppearance.
                        BorderSize = 0;
                    GameWall[i].FlatStyle = FlatStyle.Flat;
                    Controls.Add(GameWall[i]);
                }

                Finish.Location = new Point(340, 309);
                Finish.Size = new Size(50, 19);
                Finish.BackColor = Color.Orange;
                Finish.Text = "Конец";
                Finish.FlatAppearance.BorderSize = 0;
                Finish.FlatStyle = FlatStyle.Flat;
                Finish.Show();

                Start.Location = new Point(40 - 35, 39);
                Start.Size = new Size(50, 19);
                Start.BackColor = Color.Orange;
                Start.Text = "Старт";
                Start.FlatAppearance.BorderSize = 0;
                Start.FlatStyle = FlatStyle.Flat;
                Start.Show();

                Cursor.Position = PointToScreen
                    (Start.Location);

                Random rnd = new Random();
                int RandomIndex = rnd.Next(0, 54);
                GameWall[RandomIndex].MouseEnter +=
                    Game_MouseEnterFirst;
                GameWall[RandomIndex].MouseLeave +=
                    Game_MouseLeave;
                for (int i = 0; i < 4; i++)
                {
                    RandomIndex = rnd.Next(0, 54);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterSecond;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                    RandomIndex = rnd.Next(0, 54);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterThird;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                    RandomIndex = rnd.Next(0, 54);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterFourth;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                    RandomIndex = rnd.Next(0, 54);
                    GameWall[RandomIndex].MouseEnter +=
                        Game_MouseEnterFiveth;
                    GameWall[RandomIndex].MouseLeave +=
                        Game_MouseLeave;
                }
            }
        }

        //метод для выхода в меню
        private void BackToMenu_Click(object sender, 
            EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //метод для игры сначала
        private void RestartGame(object sender,
            EventArgs e)
        {
            this.Close();
            th = new Thread(OpenGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //при вызове метода появляется изображение
        private void Game_MouseEnterFirst(object sender,
            EventArgs eventArgs)
        {
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile
                ("C:\\Users\\User\\Desktop\\" +
                "Photo\\First.png");
            pictureBox1.BringToFront();
        }
        private void Game_MouseEnterSecond
            (object sender, EventArgs eventArgs)
        {
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile
                ("C:\\Users\\User\\Desktop\\" +
                "Photo\\Second.png");
            pictureBox1.BringToFront();
        }
        private void Game_MouseEnterThird
            (object sender, EventArgs eventArgs)
        {
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile
                ("C:\\Users\\User\\Desktop\\" +
                "Photo\\Third.png");
            pictureBox1.BringToFront();
        }
        private void Game_MouseEnterFourth
            (object sender, EventArgs eventArgs)
        {
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile
                ("C:\\Users\\User\\Desktop\\" +
                "Photo\\Fourth.png");
            pictureBox1.BringToFront();
        }
        private void Game_MouseEnterFiveth
            (object sender, EventArgs eventArgs)
        {
            pictureBox1.Show();
            pictureBox1.Image = Image.FromFile
                ("C:\\Users\\User\\Desktop\\" +
                "Photo\\Fiveth.png");
            pictureBox1.BringToFront();
        }

        //при вызове метода изображение пропадает
        private void Game_MouseLeave(object sender,
            EventArgs eventArgs)
        {
            pictureBox1.Hide();
        }

        //при завершении уровня воп=спроизводится музыка
        //и показывается кнопка с предложением
        //перейти на следующий уровень
        private void Finish_Click(object sender, 
            EventArgs e)
        {
            timer1.Enabled = false;

            if(LevelSelect.Level == 6)
            {
                LevelSelect.Level = 1;
            }
            label2.Text = "Вы прошли за: ";
            Next.Show();
            Cursor.Show();
            label3.Show();

            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer
                ("C:\\Users\\User\\Desktop\\Photo" +
                "\\WinMusic.wav");
            Audio.Load();
            Audio.Play();
        }

        //запуск таймера и начало игры
        private void Start_Click(object sender,
            EventArgs e)
        {
            timer1.Enabled = true;
            
            Finish.Enabled = true;
        }

        //таймер 
        private void Timer1_Tick(object sender,
            EventArgs e)
        {
            date1 = date1.AddSeconds(1);
            label1.Text = date1.ToString("mm:ss");

            //указывает время в какое исчезает курсор
            if(LevelSelect.Level == 5 || 
                LevelSelect.Level == 6)
            {
                if (date1.Second == 7 ||
                    date1.Second == 14 ||
                    date1.Second == 25 ||
                    date1.Second == 33 || 
                    date1.Second == 42 || 
                    date1.Second == 56)
                {
                    Cursor.Hide();
                }
                if (date1.Second % 10 == 0)
                {
                    Cursor.Show();
                }
            }
        }

        //предложение перейти на новый уровень
        private void NextLevel(object sender, 
            EventArgs e)
        {
            LevelSelect.Level++;

            this.Close();
            th = new Thread(OpenGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
