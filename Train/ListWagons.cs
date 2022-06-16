using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Train
{
    enum Languages
    {
        Ossetian,
        Armenian,
        Georgian
    };
    class Wagon : PictureBox
    {
        public int idPicture;
        Languages language;

        public Wagon(int idPicture, Languages language, Control control, int x, int y)
        {
            this.language = language;
            this.idPicture = idPicture;
            this.Tag = idPicture;

            this.Load($"Images/p{idPicture}{language}.png");
            control.Controls.Add(this);
            this.SizeMode = PictureBoxSizeMode.AutoSize;
            Location = new Point(x, y);
        }
        public new void Move(int speed)
        {
            this.Left += speed;
        }
    }
    class ListWagons
    {
        List<Wagon> lstWagon = new List<Wagon>();

        public ListWagons(List<int> arrayID, Languages language, Control control)
        {
            for (int j = 0; j < arrayID.Count; j++)
            {
                Wagon c = new Wagon(arrayID[j], language, control, 300 * (-1) * j, 10);
                lstWagon.Add(c);
            }
        }
        int life = 5;
        public static int counter = 0;
        public void Intersection(PictureBox pictureBoxLife, Card MovedCard)
        {
            foreach (var wagon in lstWagon)
            {
                if (FormGame.MovedCard != null)
                {
                    if (FormGame.MovedCard.Bounds.IntersectsWith(wagon.Bounds))
                    {
                        if (wagon.Tag.ToString() == FormGame.MovedCard.Tag.ToString())
                        {
                            FormGame.MovedCard = null;
                            counter++;
                            wagon.Image = Image.FromFile("Images/FilledWagon.png");
                            MovedCard.Dispose();
                            return;
                        }

                        FormGame.MovedCard = null;
                        if (life > 0)
                        {
                            life--;
                            pictureBoxLife.Image = Image.FromFile($"Life/{life}.png");
                            if (life < 1)
                            {
                                MessageBox.Show("Жизни закончились");
                                FormGameOver formGameOver = new FormGameOver();
                                formGameOver.Show();
                                return;
                            }
                            return;
                        }
                    }
                }
            }
        }

        public void Move(int speed)
        {
            foreach (var w in lstWagon)
                w.Move(speed);
        }
    }
}
