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
    public partial class AboutGame : Form
    {
        Thread th;
        public AboutGame()
        {
            InitializeComponent();
        }
        public void OpenMenu(object obj)
        {
            Application.Run(new Form1());
        }
        private void Exit_Click(object sender,
            EventArgs e)
        {
            this.Close();
            th = new Thread(OpenMenu);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
