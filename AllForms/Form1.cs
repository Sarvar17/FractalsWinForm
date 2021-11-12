using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class ChooseFractalForm : Form
    {
        /// <summary>
        /// Конструктор для меню выбора вида фракталов чтобы нарисовать.
        /// </summary>
        public ChooseFractalForm()
        {
            InitializeComponent();
        }

        FirstFractalInfo firstFractal = new FirstFractalInfo();
        /// <summary>
        /// Клик первой кнопки чтобы вывести на экран окно фрактального дерева.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FirstFractalButton_Click(object sender, EventArgs e)
        {
            if (firstFractal.IsDisposed)
            {
                firstFractal = new FirstFractalInfo();
            }
            firstFractal.Show();
        }

        SecondFractalInfo secondFractal = new SecondFractalInfo();
        /// <summary>
        /// Клик второй кнопки чтобы вывести на экран окно кривой Коха.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecondFractalButton_Click(object sender, EventArgs e)
        {
            if (secondFractal.IsDisposed)
            {
                secondFractal = new SecondFractalInfo();
            }
            secondFractal.Show();
        }

        ThirdFractalInfo thirdFractal = new ThirdFractalInfo();
        /// <summary>
        /// Клик третьей кнопки чтобы вывести на экран окно ковра Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThirdFractalButton_Click(object sender, EventArgs e)
        {
            if (thirdFractal.IsDisposed)
            {
                thirdFractal = new ThirdFractalInfo();
            }
            thirdFractal.Show();
        }

        FourthFractalInfo fourthFractal = new FourthFractalInfo();
        /// <summary>
        /// Клик четвертой кнопки чтобы вывести на экран окно треугольника Серпинского.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FourthFractalButton_Click(object sender, EventArgs e)
        {
            if (fourthFractal.IsDisposed)
            {
                fourthFractal = new FourthFractalInfo();
            }
            fourthFractal.Show();
        }

        FifthFractalInfo fifthFractal = new FifthFractalInfo();
        /// <summary>
        /// Клик пьятой кнопки чтобы вывести на экран окно множества Кантора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FifthFractalButton_Click(object sender, EventArgs e)
        {
            if (fifthFractal.IsDisposed)
            {
                fifthFractal = new FifthFractalInfo();
            }
            fifthFractal.Show();
        }

        SixthFractalInfo sixthFractal = new SixthFractalInfo();
        /// <summary>
        /// Клик шестой кнопки чтобы вывести на экран окно Красивое дерево.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SixthFractalButton_Click(object sender, EventArgs e)
        {
            if (sixthFractal.IsDisposed)
            {
                sixthFractal = new SixthFractalInfo();
            }
            sixthFractal.Show();
        }
    }
}
