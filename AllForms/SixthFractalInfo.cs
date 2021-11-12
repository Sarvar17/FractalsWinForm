using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class SixthFractalInfo : Form
    {
        /// <summary>
        /// Конструктор для шестого фрактала.
        /// </summary>
        public SixthFractalInfo()
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
            if (!Validate(coefTextBox.Text, angle1TextBox.Text, angle2TextBox.Text, out double coef, out double angle1, out double angle2))
            {
                errorLabel.Visible = true;
                MessageBox.Show("Error while entering values");
            }
            else
            {
                SixthFractal sixthFractal = new SixthFractal(coef, angle1, angle2);
                this.Close();
                sixthFractal.Show();
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
        private bool Validate(string a, string b, string c, out double aNum, out double bNum, out double cNum)
        {
            bool output = true;
            bNum = 0; cNum = 0;

            if (!double.TryParse(a, out aNum) || !double.TryParse(b, out bNum) || !double.TryParse(c, out cNum) ||
                aNum < 1.1 || aNum > 5 || bNum < 0 || cNum < 0 || bNum > 360 || cNum > 360)
            {
                output = false;
            }

            return output;
        }
    }
}
