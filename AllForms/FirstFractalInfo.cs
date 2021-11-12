using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class FirstFractalInfo : Form
    {
        /// <summary>
        /// Конструктор для первого фрактала.
        /// </summary>
        public FirstFractalInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Клик по кнопке рисовать.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (!Validate(coefTextBox.Text, angle1TextBox.Text, angle2TextBox.Text, out double coef, out double angle1, out double angle2, numTextBox.Text, out int iteration))
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                FirstFractal firstFractal = new FirstFractal(iteration, coef, angle1, angle2);
                this.Close();
                firstFractal.Show();
            }
        }

        /// <summary>
        /// Метод чтобы проверить значения которое ввел пользователь.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <param name="aNum">Число.</param>
        /// <param name="bNum">Число.</param>
        /// <param name="cNum">Число.</param>
        /// <param name="dNum">Число.</param>
        /// <returns></returns>
        private bool Validate(string a, string b, string c, out double aNum, out double bNum, out double cNum, string d, out int dNum)
        {
            bool output = true;
            bNum = 0; cNum = 0; dNum = 0;

            if (!double.TryParse(a, out aNum) || !double.TryParse(b, out bNum) || !double.TryParse(c, out cNum) || !int.TryParse(d, out dNum) ||
                aNum < 1.1 || aNum > 5 || bNum < 0 || cNum < 0 || bNum > 360 || cNum > 360 || dNum < 0 || dNum > 15)
            {
                output = false;
            }

            return output;
        }

        /// <summary>
        /// Клик по кнопке сохранить фрактал в формате PNG.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!Validate(coefTextBox.Text, angle1TextBox.Text, angle2TextBox.Text, out double coef, out double angle1, out double angle2, numTextBox.Text, out int iteration))
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                errorLabel.Visible = false;
                Bitmap map = new Bitmap(1000, 600);
                Graphics g = Graphics.FromImage(map);
                Fractal.DrawTreeFractal(iteration, 500, 20, (int)(600 / 4.5), 0, g, 600, coef, angle1, angle2, Color.Green);
                map.Save("TreeFractal.png");
                MessageBox.Show("Your Tree fractal is saved in <<bin>> folder");
            }
        }
    }
}
