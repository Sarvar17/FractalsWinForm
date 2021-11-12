using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class FourthFractalInfo : Form
    {
        /// <summary>
        /// Конструктор четвертого фрактала.
        /// </summary>
        public FourthFractalInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Клик по кнопке нарисовать фрактал треугольник Серпинского.
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
                FourthFractal fourthFractal = new FourthFractal(rec);
                this.Close();
                fourthFractal.Show();
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

                PointF left_point = new PointF(5f, 550);
                PointF right_point = new PointF(980, 550);
                PointF top_point = new PointF(495, 5);

                Fractal.DrawSierpinskiTriangle(rec, top_point, left_point, right_point, g, Brushes.Black);

                map.Save("TriangleFractal.png");
                MessageBox.Show("Your Sierpinski triangle fractal is saved in <<bin>> folder");
            }
        }
    }
}
