using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class FifthFractalInfo : Form
    {
        /// <summary>
        /// Конструктор пьятого фрактала.
        /// </summary>
        public FifthFractalInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Клик по кнопке нарисовать фрактал множество Кантора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(distanceTextBox.Text, out float distance) || !int.TryParse(recTextBox.Text, out int rec) 
                || distance < 0 || distance > 100 || rec < 0 || rec > 10)
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                errorLabel.Visible = false;
                FifthFractal fifthFractal = new FifthFractal(rec, distance);
                this.Close();
                fifthFractal.Show();
            }
        }

        /// <summary>
        /// Клик по кнопке сохранить фрактал в формате PNG.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(distanceTextBox.Text, out float distance) || !int.TryParse(recTextBox.Text, out int rec)
                || distance < 0 || distance > 100 || rec < 0 || rec > 10)
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                errorLabel.Visible = false;
                Bitmap map = new Bitmap(1000, 600);
                Graphics g = Graphics.FromImage(map);

                Fractal.DrawCantorsSet(rec, distance, new RectangleF(10f, 10f, 1000 - 32f, 25f), g, Brushes.Black, false);

                map.Save("CantorFractal.png");
                MessageBox.Show("Your Cantor's set fractal is saved in <<bin>> folder");
            }
        }
    }
}
