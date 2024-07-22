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
    public partial class ChoiceLevel : Form
    {
        Thread th;
        public ChoiceLevel()
        {
            InitializeComponent();
        }
        public void OpenMenu(object obj)
        {
            Application.Run(new Form1());
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        //запись выбранного уровня в класс
        private void FirstLevel_Click_1(object sender, 
            EventArgs e)
        {
            LevelSelect.Level = 1;

            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void SecondLevel_Click(object sender,
            EventArgs e)
        {
            LevelSelect.Level = 2;

            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void ThirdLevel_Click(object sender,
            EventArgs e)
        {
            LevelSelect.Level = 3;

            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void FourthLevel_Click(object sender,
            EventArgs e)
        {
            LevelSelect.Level = 4;

            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void FivethLevel_Click(object sender, 
            EventArgs e)
        {
            LevelSelect.Level = 5;

            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void SixthLevel_Click(object sender, 
            EventArgs e)
        {
            LevelSelect.Level = 6;

            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
