using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class ThirdFractalInfo : Form
    {
        /// <summary>
        /// Конструктор третьего фрактала.
        /// </summary>
        public ThirdFractalInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Клик по кнопке нарисовать ковер Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(recTextBox.Text, out int rec) || rec < 0 || rec > 10)
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                ThirdFractal thirdFractal = new ThirdFractal(rec);
                this.Close();
                thirdFractal.Show();
            }
        }

        /// <summary>
        /// Клик по кнопке сохранить фрактал в формате PNG.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(recTextBox.Text, out int rec) || rec < 0 || rec > 10)
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                errorLabel.Visible = false;
                Bitmap map = new Bitmap(1000, 600);
                Graphics g = Graphics.FromImage(map);
                RectangleF rectangle = new RectangleF(250, 1, 550, 550);
                Fractal.DrawRectangle(g, rec, rectangle, Brushes.Black);
                map.Save("CarpetFractal.png");
                MessageBox.Show("Your Sierpinski carpet fractal is saved in <<bin>> folder");
            }
        }
    }
}
