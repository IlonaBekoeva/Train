using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Train
{
    public partial class FormGameOver : Form
    {
        public FormGameOver()
        {
            InitializeComponent();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGame formGame = new FormGame();
            formGame.Show();
        }
    }
}
