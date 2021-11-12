using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class SecondFractal : Form
    {
        /// <summary>
        /// Количество шагов.
        /// </summary>
        public static int Step { get; set; }

        /// <summary>
        /// Конструктор для второго фрактала.
        /// </summary>
        /// <param name="step">Количество шагов.</param>
        public SecondFractal(int step)
        {
            Step = step;
            InitializeComponent();
            ResizeRedraw = true;
        }

        /// <summary>
        /// Метод перерисовки кривой Коха.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            Fractal.DrawFractalKoch(Step, 0, 2 * this.Height / 3, 0, this.Width, g, Color.White);
        }
    }
}
