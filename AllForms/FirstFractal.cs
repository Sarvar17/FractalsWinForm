using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FractalsWinForm
{
    public partial class FirstFractal : Form
    {
        /// <summary>
        /// Количество шагов.
        /// </summary>
        public int Steps { get; set; }

        /// <summary>
        /// Коэффициент.
        /// </summary>
        public double Coef { get; set; }

        /// <summary>
        /// Первый угол.
        /// </summary>
        public double Angle1 { get; set; }

        /// <summary>
        /// Второй угол.
        /// </summary>
        public double Angle2 { get; set; }
        readonly Fractal fractal = new Fractal();

        /// <summary>
        /// Конструктор для первого фрактала.
        /// </summary>
        /// <param name="steps">Количество шагов.</param>
        /// <param name="coef">Коэффициент.</param>
        /// <param name="angleOne">Первый угол.</param>
        /// <param name="angleTwo">Второй угол.</param>
        public FirstFractal(int steps, double coef, double angleOne, double angleTwo)
        {
            InitializeComponent();
            ResizeRedraw = true;
            Steps = steps;
            Coef = coef;
            Angle1 = angleOne;
            Angle2 = angleTwo;
            fractal.Steps = steps;
            fractal.Coef = coef;
            fractal.Angle1 = angleOne;
            fractal.Angle2 = angleTwo;
        }

        /// <summary>
        /// Метод перерисовки фрактального дерева.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            Fractal.DrawTreeFractal(Steps, this.Width / 2, 20, (int)(this.Height / 4.5), 0, g, this.Height, Coef, Angle1, Angle2, Color.White);
        }
    }
}
