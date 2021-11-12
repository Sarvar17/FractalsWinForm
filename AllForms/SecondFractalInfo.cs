using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class SecondFractalInfo : Form
    {
        /// <summary>
        /// Конструктор второго фрактала.
        /// </summary>
        public SecondFractalInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Клик по кнопка нарисовать фрактал Коха.
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
                SecondFractal secondFractal = new SecondFractal(rec);
                this.Close();
                secondFractal.Show();
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
                Fractal.DrawFractalKoch(rec, 0, 400, 0, 1000, g, Color.Black);
                map.Save("KochFractal.png");
                MessageBox.Show("Your Koch fractal is saved in <<bin>> folder");
            }
        }
    }
}
