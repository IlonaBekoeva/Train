using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Train
{
    public partial class FormGame : Form
    {
        int speed = 1;
        Level Level;
        public int lev;
        ListCards ListCards;
        ListWagons ListWagons;
        Languages Language;

        public static Card MovedCard = null;

        public FormGame()
        {
            InitializeComponent();
            //buttonStart.Location = new Point(10, 900);
            //buttonCheck.Location = new Point(185, 900);
            //buttonExit.Location = new Point(325, 900);
            //pictureBoxLife.Location = new Point(1500, 900);
            lev = Level.level;

        }
        private void FormGame_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void timerTrainMove_Tick(object sender, EventArgs e)
        {
            ListWagons.Move(speed);
            ListWagons.Intersection(pictureBoxLife, MovedCard);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            Language = FormMenu.Languages;
            timerTrainMove.Start();
            Level = new Level(lev);
            ListCards = new ListCards(Level.IndexesCards, this);
            ListWagons = new ListWagons(Level.IndexesWagons, Language, this);
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (ListWagons.counter == Level.level_lst[Level.level])
            {
                Level.level++;
                if (Level.level == 3)
                {
                    MessageBox.Show("Поздравляю!!! Вы прошли игру!!!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Поздравляю!!! Вы успешно прошли уровень!!!");
                    ListWagons.counter = 0;
                    this.Close();
                    new FormGame().Show();
                }
            }
            else
            {
                this.Close();
                new FormGameOver().Show();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
