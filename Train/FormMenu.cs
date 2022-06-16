using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Train
{
    public partial class FormMenu : Form
    {
        private static Languages languages = Languages.Ossetian;

        internal static Languages Languages { get => languages; set => languages = value; }

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            buttonArmenian.Tag = Languages.Armenian;
            buttonOssetian.Tag = Languages.Ossetian;
            buttonGeorgian.Tag = Languages.Georgian;
        }

        private void buttonLanguage_Click(object sender, EventArgs e)
        {
            Languages = (Languages)(sender as Button).Tag;
            this.Hide();
            FormGame formGame = new FormGame();
            formGame.Show();
        }
    }
}
