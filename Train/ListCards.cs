using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Train
{
    public class Card : PictureBox
    {
        public int id;
        int startX, startY;
        public Card(int id, Control control, int x, int y)
        {
            this.id = id;
            this.Tag = id;

            this.Load($"Cards/p{id}.png");
            control.Controls.Add(this);
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            Location = new Point(x, y);
            this.MouseDown += Card_MouseDown;
            this.MouseMove += Card_MouseMove;
            this.MouseUp += Card_MouseUp;
        }

        private void Card_MouseUp(object sender, MouseEventArgs e)
        {
            FormGame.MovedCard = null;
        }

        private void Card_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - startX;
                this.Top += e.Y - startY;
            }
        }

        private void Card_MouseDown(object sender, MouseEventArgs e)
        {
            startX = e.X;
            startY = e.Y;
            FormGame.MovedCard = this;
            this.BringToFront();
        }
    }
    class ListCards
    {
        public List<Card> lstCard = new List<Card>();

        public ListCards(List<int> arrayID, Control control)
        {
            int col = 0;
            int row = 1;
            for (int i = 0; i < arrayID.Count; i++)
            {
                Card c = new Card(arrayID[i], control, col * 190, row * 250);
                lstCard.Add(c);
                col++;
                if (i % 8 == 0 && i != 0) { col = 0; row++; }
            }
        }
    }
}

