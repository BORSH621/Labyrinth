using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Labyrinth
{
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }
        public void OpenGame(object obj)
        {
            Application.Run(new Game());
        }
        public void OpenAboutGame(object obj)
        {
            Application.Run(new AboutGame());
        }
        public void OpenChoiceLevel(object obj)
        {
            Application.Run(new ChoiceLevel());
        }

        //переход в новую фому
        private void Play_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //переход в новую фому
        private void AboutGame_Click(object sender,
            EventArgs e)
        {
            this.Close();
            th = new Thread(OpenAboutGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //переход в новую фому
        private void ChoiceLevel_Click(object sender,
            EventArgs e)
        {
            this.Close();
            th = new Thread(OpenChoiceLevel);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //закрытие игры
        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
